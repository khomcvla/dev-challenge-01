using dev_challenge_01.Dtos;
using dev_challenge_01.Interfaces;
using dev_challenge_01.Models;
using dev_challenge_01.Utils.Responses;
using Microsoft.AspNetCore.Mvc;

namespace dev_challenge_01.Controllers;

[ApiController]
public class FacilityController : ControllerBase
{
    private readonly IFacilityService _facilityService;

    public FacilityController(IFacilityService facilityService)
    {
        _facilityService = facilityService;
    }

    //GET
    [HttpGet("api/trucks")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Facility>))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorDetailsResponse))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorDetailsResponse))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorDetailsResponse))]
    public async Task<IActionResult> GetAll()
    {
        var response = await _facilityService.GetAll();
        return StatusCode(response.StatusCode, response.Value);
    }

    //POST
    [HttpPost("api/trucks")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Facility>))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorDetailsResponse))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorDetailsResponse))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorDetailsResponse))]
    public async Task<IActionResult> GetFacilities([FromBody] InputPostDto inputPostDto)
    {
        var response = await _facilityService.GetFacilities(inputPostDto);
        return StatusCode(response.StatusCode, response.Value);
    }
}
