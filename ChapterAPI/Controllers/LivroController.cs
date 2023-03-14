using ChapterAPI.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChapterAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly ILivroRepository _IlivroRepository;

        public LivroController(ILivroRepository ILivroRepository)
        {
            _IlivroRepository = ILivroRepository;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(_IlivroRepository.Ler());
            }
            catch (Exception e) 
            {
                throw new Exception(e.Message);
            }
        }

    }
}
