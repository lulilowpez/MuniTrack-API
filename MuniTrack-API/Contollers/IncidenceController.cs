using Application.Dtos;
using Application.Interfaces;
using Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MuniTrack_API.Contollers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncidenceController : ControllerBase
    {
        private readonly IIncidenceService _incidenceService;
        
        public IncidenceController (IIncidenceService incidenceService)
        {
            _incidenceService = incidenceService;
        }

        [HttpPost]
        public IActionResult CreateIncidence([FromBody] CreateIncidenceDTO Dto)
        {
            try
            {
                _incidenceService.CreateIncidence(Dto);
                return Ok(Dto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetAllIncidences()
        {
            var incidences = _incidenceService.GetIncidences();
            return Ok(incidences);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateIncidence(int id, [FromBody] UpdateIncidenceDTO dto)
        {
            try
            {
                var updateIncidence = _incidenceService.UpdateIncidence(id, dto);
                return Ok(updateIncidence);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{idToDelete}")]
        public IActionResult DeleteOperator(int idToDelete)
        {
            var deleteIncidence = _incidenceService.DeleteIncidence(idToDelete);
            if (deleteIncidence)
                return Ok();

            return BadRequest($"La Incidencia:{idToDelete} no pudo ser eliminada");
        }



    }
}
