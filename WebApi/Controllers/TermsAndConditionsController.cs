using Microsoft.AspNetCore.Mvc;
using WebApi.Services;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TermsAndConditionsController(ITermAndConditionService termService) : ControllerBase
{
    private readonly ITermAndConditionService _termService = termService;

    #region Read
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _termService.GetTermsAsync();
        return Ok(result);
    }

    #endregion
}
