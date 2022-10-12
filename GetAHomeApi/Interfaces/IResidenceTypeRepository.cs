using GetAHomeApi.Models;

namespace GetAHomeApi.Interfaces;

public interface IResidenceTypeRepository
{
    public Task<ResidenceType?> GetResidenceTypeAsync(int id);
    public Task<List<ResidenceType>> GetAllResidenceTypesAsync();
    public Task<bool> CreateResidenceTypeAsync(ResidenceType residenceType);
    public Task<bool> DeleteResidenceType(int id);
    public bool UpdateResidenceType(ResidenceType residenceType);
    public Task<bool> SaveChangesAsync();
}
