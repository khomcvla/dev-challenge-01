using dev_challenge_01.Dtos;
using dev_challenge_01.Interfaces;
using dev_challenge_01.Models;
using dev_challenge_01.Utils.Helpers;
using dev_challenge_01.Utils.Responses;

namespace dev_challenge_01.Services;

public class FacilityService : IFacilityService
{
    private readonly IFacilityRepository _facilityRepository;

    public FacilityService(IFacilityRepository facilityRepository)
    {
        _facilityRepository = facilityRepository;
    }

    public async Task<ServiceResponse> GetAll()
    {
        var facilities = await _facilityRepository.GetAll();
        return new ServiceResponse(StatusCodes.Status200OK, facilities);
    }

    public async Task<ServiceResponse> GetFacilities(InputPostDto inputPostDto)
    {
        //GET
        var facilities = await _facilityRepository.GetAll();

        //FILTER
        if (!string.IsNullOrEmpty(inputPostDto.PreferredFood))
        {
            string[] searchItems = inputPostDto.PreferredFood.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

            facilities = (List<Facility>)facilities
                .Where(f => searchItems.All(item => f.FoodItems != null && f.FoodItems.Contains(item.Trim())));
        }

        // SORT
        //NOTE: Get rid off List?
        List<Facility> sorted = facilities
            .OrderBy(facility =>
                DistanceHelper.CalculateHaversineDistance(inputPostDto.Latitude, inputPostDto.Longitude, facility.Latitude, facility.Longitude))
            .ToList();

        //RESULT
        //NOTE: Get rid off List?
        if (inputPostDto.AmountOfResults.HasValue)
        {
            sorted = sorted.Take(inputPostDto.AmountOfResults.Value).ToList();
        }
        var result = sorted.ToList();

        return new ServiceResponse(StatusCodes.Status200OK, result);
    }
}
