// Controllers/EmailController.cs
using Microsoft.AspNetCore.Mvc;
using RoKa.Application.DTOs;
using RoKa.Application.Interfaces;

namespace RoKa.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmailController : ControllerBase
{
    private readonly IEmailService _emailService;

    public EmailController(IEmailService emailService)
    {
        _emailService = emailService;
    }

    [HttpPost("send")]
    public async Task<IActionResult> SendEmail([FromBody] EmailRequest request)
    {
        await _emailService.SendEmailAsync(request.ToEmail, request.Subject, request.Message, request.FromName, request.FromEmail);
        return Ok();
    }
}
