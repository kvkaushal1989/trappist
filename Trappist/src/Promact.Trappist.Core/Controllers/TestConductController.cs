﻿using Microsoft.AspNetCore.Mvc;
using Promact.Trappist.DomainModel.Models.TestConduct;
using Promact.Trappist.Repository.TestConduct;
using System.Threading.Tasks;

namespace Promact.Trappist.Core.Controllers
{
    [Route("api/conduct")]
    public class TestConductController : Controller
    {
        #region Private Variables
        #region Dependencies
        private readonly ITestConductRepository _testConductRepository;
        #endregion
        #endregion

        #region Constructor
        public TestConductController(ITestConductRepository testConductRepository)
        {
            _testConductRepository = testConductRepository;
        }
        #endregion

        #region Public method
        /// <summary>
        /// This method used for register test attendee for the current test.
        /// </summary>
        /// <param name="testAttendee">This model object contain test attendee credential which are first name, last name, email, roll number, contact number</param>
        /// <param name="magicString">This parameter contain test link</param>
        /// <returns>It will return true response if test attendee successfully registered else it will return bad request.</returns>
        [HttpPost("{magicString}/register")]
        public async Task<IActionResult> RegisterTestAttendeesAsync([FromBody]TestAttendees testAttendee, [FromRoute]string magicString)
        {
            if (ModelState.IsValid)
            {
                if (!await _testConductRepository.IsTestAttendeeExistAsync(testAttendee, magicString))
                {
                    await _testConductRepository.RegisterTestAttendeesAsync(testAttendee, magicString);
                    return Ok(true);
                }
                return BadRequest();
            }
            return BadRequest();
        }
        #endregion
    }
}