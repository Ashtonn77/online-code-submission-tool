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
    public class ChallengesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ChallengesController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        // GET: api/<ChallengesController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetChallenges()
        {
            try
            {
                //Expression<Func<Challenge, bool>> expression = null
                var challenges = await _unitOfWork.Challenges.GetAll();
                var results = _mapper.Map<IList<ChallengeDto>>(challenges);
                return Ok(results);

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }



        // GET api/<ChallengesController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetChallenge(int id)
        {
            try
            {
                var challenge = await _unitOfWork.Challenges.Get(q => q.Id == id);
                var result = _mapper.Map<ChallengeDto>(challenge);
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }

        // POST api/<ChallengesController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateChallenge([FromBody] ChallengeDto challengeDto)
        {

            if (!ModelState.IsValid)
            {

                return BadRequest(ModelState);
            }


            try
            {


                var challenge = _mapper.Map<Challenge>(challengeDto);
                await _unitOfWork.Challenges.Insert(challenge);
                await _unitOfWork.Save();

                return CreatedAtAction("GetChallenge", new { id = challenge.Id }, challenge);

            }
            catch (Exception e)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    e.InnerException);
            }


        }


        // PUT api/<ChallengesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateChallenge(int id, [FromBody] ChallengeDto challengeDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var originalChallenge = await _unitOfWork.Challenges.Get(q => q.Id == id);

                if (originalChallenge == null)
                {
                    return BadRequest("Submitted data is invalid");
                }

                _mapper.Map(challengeDto, originalChallenge);
                _unitOfWork.Challenges.Update(originalChallenge);
                await _unitOfWork.Save();

                return NoContent();

            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }

        }


        // DELETE api/<ChallengesController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteChallenge(int id)
        {
            if (id < 1)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var challenge = await _unitOfWork.Challenges.Get(q => q.Id == id);

                if (challenge == null)
                {
                    return BadRequest("Submitted data is invalid");
                }

                await _unitOfWork.Challenges.Delete(id);
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
