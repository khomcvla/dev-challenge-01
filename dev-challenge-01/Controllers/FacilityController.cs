using dev_challenge_01.Data.Models;
using dev_challenge_01.Dtos;
using dev_challenge_01.Interfaces;
using dev_challenge_01.Utils.Responses;
using Microsoft.AspNetCore.Mvc;

namespace dev_challenge_01.Controllers;

[ApiController]
public class FacilityController : ControllerBase
{
    private readonly IFacilityService _facilityService;
    private readonly ILogger<FacilityController> _logger;

    public FacilityController(
        IFacilityService facilityService,
        ILogger<FacilityController> logger
    )
    {
        _logger = logger;
        _facilityService = facilityService;
    }

    //GET
    [HttpGet("api/trucks")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Facility>))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorDetails))]
    [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(ErrorDetails))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorDetails))]
    public async Task<IActionResult> GetAll()
    {
        var response = await _facilityService.GetAll();
        return StatusCode(response.StatusCode, response.Value);
    }
}
