using AutoMapper;
using GetAHomeApi.Interfaces;
using GetAHomeApi.Models;
using GetAHomeApi.ViewModels.ResidenceType;
using Microsoft.AspNetCore.Mvc;

namespace GetAHomeApi.Controllers;

[Route("api/ResidenceType")]
[ApiController]
public class ResidenceTypeController : ControllerBase
{
    private readonly IResidenceTypeRepository _repo;
    private readonly IMapper _mapper;

    public ResidenceTypeController(IResidenceTypeRepository repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }



    // GET api/ResidenceType/5
    [HttpGet("{id}")]
    public async Task<ActionResult<ResidenceTypeViewModel>> GetResidenceTypeById(int id)
    {
        var residenceType = await _repo.GetResidenceTypeAsync(id);
        if (residenceType == null)
            return NotFound(); // 404
        var model = _mapper.Map<ResidenceTypeViewModel>(residenceType);
        return Ok(model); // 200
    }

    // GET: api/ResidenceType
    [HttpGet]
    public async Task<ActionResult<List<ResidenceTypeViewModel>>> GetAllResidenceTypes()
    {
        var residenceTypes = await _repo.GetAllResidenceTypesAsync();
        var models = _mapper.Map<List<ResidenceTypeViewModel>>(residenceTypes);
        return Ok(models); // 200
    }

    // POST api/ResidenceType
    [HttpPost]
    public async Task<ActionResult> CreateResidenceType(PostResidenceTypeViewModel model)
    {
        var residenceType = _mapper.Map<ResidenceType>(model);
        await _repo.CreateResidenceTypeAsync(residenceType);
        return (await _repo.SaveChangesAsync())
            ? StatusCode(201) // Created
            : StatusCode(500, "Fail: Create residence type"); // Internal server error
    }

    // PUT api/ResidenceType/5
    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateResidenceType(int id, UpdateResidenceTypeViewModel model)
    {
        var residenceType = await _repo.GetResidenceTypeAsync(id);
        if (residenceType == null)
            return NotFound(); // 404
        _mapper.Map(model, residenceType);
        _repo.UpdateResidenceTypeAsync(residenceType);
        return (await _repo.SaveChangesAsync())
            ? Ok("Updated") // 200
            : StatusCode(500, "Fail: Update residence type"); // Internal server error
    }

    // DELETE api/ResidenceType/5
    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteResidenceType(int id)
    {
        await _repo.DeleteResidenceTypeAsync(id);
        return (await _repo.SaveChangesAsync())
            ? Ok("Deleted") // 200
            : StatusCode(500, "Fail: Delete residence type"); // Internal server error
    }
}
