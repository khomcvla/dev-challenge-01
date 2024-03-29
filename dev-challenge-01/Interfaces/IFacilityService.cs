using dev_challenge_01.Dtos;
using dev_challenge_01.Utils.Responses;

namespace dev_challenge_01.Interfaces;

public interface IFacilityService
{
    Task<ServiceResponse> GetAll();
    Task<ServiceResponse> GetFacilities(InputPostDto inputPostDto);
}
