﻿using InstaGama.Application.AppUser.Input;
using InstaGama.Application.AppUser.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstaGama.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserAppService _userAppService;

        public UserController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserInput userInput)
        {
            try
            {
                var user = await _userAppService
                                    .InsertAsync(userInput)
                                    .ConfigureAwait(false);

                return Created("", user);
            }
            catch(ArgumentException arg)
            {
                return BadRequest(arg.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var user = await _userAppService
                                .GetByIdAsync(id)
                                .ConfigureAwait(false);

            if (user is null)
                return NotFound();

            return Ok(user);
        }
    }
}
