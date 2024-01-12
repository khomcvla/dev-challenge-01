using dev_challenge_01.Models;

namespace dev_challenge_01.Interfaces;

public interface IFacilityRepository
{
    Task<List<Facility>> GetAll();
}
