using Application.Dtos;
using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MuniTrack_API.Contollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperatorController : ControllerBase
    {
        private readonly IOperatorService _operatorService;
        public OperatorController(IOperatorService operatorService)
        {
            _operatorService = operatorService;
        }


        [HttpPost]
        public IActionResult CreateOperator([FromBody] CreateOperatorDto Dto)
        {
            _operatorService.CreateOperator(Dto);
            return Ok(Dto);
        }
        [HttpGet]
        public IActionResult GetAllOperator()
        {
            var operators = _operatorService.GetOperators();
            return Ok(operators);
        }
    }
}
