using AutoMapper;
using CodeSubmissionTool.Server.IRepositories;
using CodeSubmissionTool.Server.Models;
using CodeSubmissionTool.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeSubmissionTool.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitTestsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UnitTestsController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // GET: api/<UnitTestsController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetUnitTests()
        {
            try
            {
                //Expression<Func<UnitTest, bool>> expression = null
                var unitTests = await _unitOfWork.UnitTests.GetAll();
                var results = _mapper.Map<IList<UnitTestDto>>(unitTests);
                return Ok(results);

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }



        // GET api/<UnitTestsController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetUnitTest(int id)
        {
            try
            {
                var unitTest = await _unitOfWork.UnitTests.Get(q => q.Id == id);
                var result = _mapper.Map<UnitTestDto>(unitTest);
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }


        [HttpGet("challenge/{id}")]
        public async Task<IActionResult> GetUnitTestsByChallenge(int id)
        {
            
            var unitTests = await _unitOfWork.UnitTests.GetAll(q => q.ChallengeId == id);
            var results = _mapper.Map<IList<UnitTestDto>>(unitTests);
            
            if (results == null)
            {
                return NotFound();
            }

            return Ok(results);
        }


        // POST api/<UnitTestsController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateUnitTest([FromBody] UnitTestDto unitTestDto)
        {

            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }


            try
            {


                var unitTest = _mapper.Map<UnitTest>(unitTestDto);
                await _unitOfWork.UnitTests.Insert(unitTest);
                await _unitOfWork.Save();

                return CreatedAtAction("GetUnitTest", new { id = unitTest.Id }, unitTest);

            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    e.InnerException);
            }


        }


        // PUT api/<UnitTestsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUnitTest(int id, [FromBody] UnitTestDto unitTestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var originalUnitTest = await _unitOfWork.UnitTests.Get(q => q.Id == id);

                if (originalUnitTest == null)
                {
                    return BadRequest("Submitted data is invalid");
                }

                _mapper.Map(unitTestDto, originalUnitTest);
                _unitOfWork.UnitTests.Update(originalUnitTest);
                await _unitOfWork.Save();

                return NoContent();

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }

        }


        // DELETE api/<UnitTestsController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteUnitTest(int id)
        {
            if (id < 1)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var unitTest = await _unitOfWork.UnitTests.Get(q => q.Id == id);

                if (unitTest == null)
                {
                    return BadRequest("Submitted data is invalid");
                }

                await _unitOfWork.UnitTests.Delete(id);
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
