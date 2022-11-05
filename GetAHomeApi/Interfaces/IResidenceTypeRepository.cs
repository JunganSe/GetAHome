using GetAHomeApi.Models;

namespace GetAHomeApi.Interfaces;

public interface IResidenceTypeRepository
{
    public Task<ResidenceType?> GetResidenceTypeAsync(int id);
    public Task<List<ResidenceType>> GetAllResidenceTypesAsync();
    public Task CreateResidenceTypeAsync(ResidenceType residenceType);
    public Task DeleteResidenceTypeAsync(int id);
    public void UpdateResidenceTypeAsync(ResidenceType residenceType);
    public Task<bool> SaveChangesAsync();
}
