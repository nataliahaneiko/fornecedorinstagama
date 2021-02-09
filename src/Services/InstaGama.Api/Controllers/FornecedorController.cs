using InstaGama.Application.AppFornecedor.Input;
using InstaGama.Application.AppFornecedor.Interfaces;
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
    public class FornecedorController : ControllerBase
    {
        private readonly IFornecedorAppService _fornecedorAppService;

        public FornecedorController(IFornecedorAppService fornecedorAppService)
        {
            _fornecedorAppService = fornecedorAppService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] FornecedorInput fornecedorInput)
        {
            try
            {
                var fornecedor = _fornecedorAppService
                                    .Insert(fornecedorInput);

                return Created("", fornecedor);
            }
            catch (ArgumentException arg)
            {
                return BadRequest(arg.Message);
            }
        }
    }
}
