using GetAHomeApi.Interfaces;
using GetAHomeApi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GetAHomeApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ResidenceTypeController : ControllerBase
{
    private readonly IResidenceTypeRepository _repo;

    public ResidenceTypeController(IResidenceTypeRepository repo)
    {
        _repo = repo;
    }



    // GET: api/<ResidenceTypeController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/<ResidenceTypeController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<ResidenceTypeController>
    [HttpPost]
    public async Task Post()
    {
        var grej = new ResidenceType() { Description = "Nananana" };
        await _repo.CreateResidenceTypeAsync(grej);
        await _repo.SaveChangesAsync();
    }

    // PUT api/<ResidenceTypeController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    [HttpPatch("{id}")]
    public void Patch(int id, [FromBody] string value)
    {
    }

    // DELETE api/<ResidenceTypeController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
