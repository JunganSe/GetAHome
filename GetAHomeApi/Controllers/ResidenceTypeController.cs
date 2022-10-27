using GetAHomeApi.Interfaces;
using GetAHomeApi.Models;
using GetAHomeApi.ViewModels.ResidenceType;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GetAHomeApi.Controllers;
[Route("api/ResidenceType")]
[ApiController]
public class ResidenceTypeController : ControllerBase
{
    private readonly IResidenceTypeRepository _repo;

    public ResidenceTypeController(IResidenceTypeRepository repo)
    {
        _repo = repo;
    }



    // GET: api/ResidenceType
    [HttpGet]
    public async Task<ActionResult<List<ResidenceTypeViewModel>>> Get()
    {
        var residenceTypes = await _repo.GetAllResidenceTypesAsync();
        var models = new List<ResidenceTypeViewModel>(); // TODO: Mappa med automapper
        return Ok(models); // 200
    }

    // GET api/ResidenceType/5
    [HttpGet("{id}")]
    public async Task<ActionResult<ResidenceTypeViewModel>> Get(int id)
    {
        var residencyType = await _repo.GetResidenceTypeAsync(id);
        var model = new ResidenceTypeViewModel(); // TODO: Mappa med automapper
        return Ok(model); // 200
    }

    // POST api/ResidenceType
    [HttpPost]
    public async Task<ActionResult> Post(PostResidenceTypeViewModel model)
    {
        var residenceType = new ResidenceType() { Description = model.Description }; // TODO: Mappa med automapper
        await _repo.CreateResidenceTypeAsync(residenceType);
        return (await _repo.SaveChangesAsync())
            ? StatusCode(201) // Created
            : StatusCode(500, "Fail: Create residence type"); // Internal server error
    }

    // PUT api/ResidenceType/5
    [HttpPut("{id}")]
    public async Task<ActionResult> Put(int id)
    {
        // TODO: Update residence type
        throw new NotImplementedException();
    }

    // DELETE api/ResidenceType/5
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        await _repo.DeleteResidenceTypeAsync(id);
        return (await _repo.SaveChangesAsync())
            ? StatusCode(204) // No content
            : StatusCode(500, "Fail: Delete residence type"); // Internal server error
    }
}
