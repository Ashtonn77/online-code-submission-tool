using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AutoMapper;
using CodeSubmissionTool.Server.Compilers;
using CodeSubmissionTool.Server.ICompilers;
using CodeSubmissionTool.Server.IRepositories;
using CodeSubmissionTool.Server.Models;
using CodeSubmissionTool.Shared;
using Microsoft.AspNetCore.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodeSubmissionTool.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ICompilerOfWork _compiler;
        private readonly string fileName = $"{Environment.CurrentDirectory}\\sample.py";

        public TestsController(IUnitOfWork unitOfWork, IMapper mapper, ICompilerOfWork compiler)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _compiler = compiler;
        }

        // GET: api/<TestsController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetTests()
        {
            try
            {
                //Expression<Func<Test, bool>> expression = null
                var tests = await _unitOfWork.Tests.GetAll();
                var results = _mapper.Map<IList<TestDto>>(tests);
                return Ok(results);

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }



        // GET api/<TestsController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetTest(int id)
        {
            try
            {
                var test = await _unitOfWork.Tests.Get(q => q.Id == id);
                var result = _mapper.Map<TestDto>(test);
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        // POST api/<TestsController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateTest([FromBody] TestDto testDto)
        {

            if (!ModelState.IsValid)
            {
               
                return BadRequest(ModelState);
            }


            try
            {

               

                var test = _mapper.Map<Test>(testDto);
                await _unitOfWork.Tests.Insert(test);
                await _unitOfWork.Save();

                _compiler.Python.CreateFile(testDto.Code, fileName);
                var executionOutput = _compiler.Python.ExecuteScript(fileName, "Nebula");
                bool executionResult = executionOutput.Trim().Equals("alubeN");

                Submission submission = new Submission
                {
                    Id = 1,
                    Output = executionOutput,
                    Result = executionResult
                };

                _unitOfWork.Submissions.Update(submission);
                await _unitOfWork.Save();

                return CreatedAtAction("GetTest", new { id = test.Id }, test);

            }
            catch (Exception e)
            {
                
                return StatusCode(StatusCodes.Status500InternalServerError,
                    e.InnerException);
            }


        }

     
        // PUT api/<TestsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTest(int id, [FromBody] TestDto testDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var originalTest = await _unitOfWork.Tests.Get(q => q.Id == id);

                if (originalTest == null)
                {
                    return BadRequest("Submitted data is invalid");
                }

                _mapper.Map(testDto, originalTest);
                _unitOfWork.Tests.Update(originalTest);
                await _unitOfWork.Save();

                return NoContent();

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }

        }


        // DELETE api/<TestsController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteTest(int id)
        {
            if (id < 1)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var test = await _unitOfWork.Tests.Get(q => q.Id == id);

                if (test == null)
                {
                    return BadRequest("Submitted data is invalid");
                }

                await _unitOfWork.Tests.Delete(id);
                await _unitOfWork.Save();

                return NoContent();


            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }

        }

    }
}
