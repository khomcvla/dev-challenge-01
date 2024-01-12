using dev_challenge_01.Data.Models;
using dev_challenge_01.Interfaces;

namespace dev_challenge_01.Repository;

public class FacilityRepository : IFacilityRepository
{
    private readonly List<Facility> _facilities;

    public FacilityRepository(List<Facility> facilities)
    {
        _facilities = facilities;
    }

    public async Task<List<Facility>> GetAll()
    {
        return await Task.FromResult(_facilities);
    }
}
