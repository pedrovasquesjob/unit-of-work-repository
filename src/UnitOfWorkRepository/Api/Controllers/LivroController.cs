using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LivroController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;

    public LivroController(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;

    [HttpGet]
    public async Task<IActionResult> GetAll()
        => Ok(await _unitOfWork.LivrosRepo.GetAll());

    [HttpPost]
    public async Task<IActionResult> Post() 
    {
        await _unitOfWork.LivrosRepo.Add(new(1, "Teste"));
        await _unitOfWork.Commit();

        return Ok();
    }
}