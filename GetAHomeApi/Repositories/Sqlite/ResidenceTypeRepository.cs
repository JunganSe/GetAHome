using GetAHomeApi.Data;
using GetAHomeApi.Interfaces;
using GetAHomeApi.Models;
using Microsoft.EntityFrameworkCore;

namespace GetAHomeApi.Repositories.Sqlite;

public class ResidenceTypeRepository : IResidenceTypeRepository
{
    private readonly Context _context;

    public ResidenceTypeRepository(Context context)
    {
        _context = context;
    }



    public async Task<ResidenceType?> GetResidenceTypeAsync(int id)
    {
        return await _context.ResidenceTypes.FindAsync(id);
    }

    public async Task<List<ResidenceType>> GetAllResidenceTypesAsync()
    {
        return await _context.ResidenceTypes.ToListAsync();
    }

    public async Task CreateResidenceTypeAsync(ResidenceType residenceType)
    {
        await _context.ResidenceTypes.AddAsync(residenceType);
    }

    public void UpdateResidenceTypeAsync(ResidenceType residenceType)
    {
        _context.ResidenceTypes.Update(residenceType);
    }

    public async Task DeleteResidenceTypeAsync(int id)
    {
        var result = await _context.ResidenceTypes.FindAsync(id);
        if (result != null)
            _context.ResidenceTypes.Remove(result);
    }



    public async Task<bool> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }
}
