using GetAHomeApi.Models;

namespace GetAHomeApi.Interfaces;

public interface IResidenceTypeRepository
{
    public Task<List<ResidenceType>> GetResidenceTypesAsync();
}
