using Microsoft.AspNetCore.Mvc;
using RegistroPontoAPI.Models;

namespace RegistroPontoAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CheckInController : ControllerBase
{
    private static List<CheckInModel> _checkIns = new();

    [HttpPost]
    public IActionResult Post([FromBody] CheckInModel checkIn)
    {
        _checkIns.Add(checkIn);
        return Ok("Check-in sincronizado com sucesso!");
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_checkIns);
    }
}