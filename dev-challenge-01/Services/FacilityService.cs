using dev_challenge_01.Interfaces;
using dev_challenge_01.Utils.Responses;

namespace dev_challenge_01.Services;

public class FacilityService : IFacilityService
{
    private readonly IFacilityRepository _facilityRepository;

    public FacilityService(
        IFacilityRepository facilityRepository)
    {
        _facilityRepository = facilityRepository;
    }

    public async Task<ServiceResponse> GetAll()
    {
        var facilities = await _facilityRepository.GetAll();
        return new ServiceResponse(StatusCodes.Status200OK, facilities);
    }
}
