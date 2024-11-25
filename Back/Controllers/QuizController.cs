using Ynov.QuizYnov.Controllers.Mappers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ynov.QuizYnov.Business;
using Ynov.QuizYnov.Controllers.Dtos;

namespace Ynov.QuizYnov.Controllers
{
    [Route("api/quiz")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private readonly IQuizService _service;
        private readonly QuizMapper _mapper;
        
        public QuizController(IQuizService service, QuizMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet(Name = "GetAllQuiz")]
        [ProducesResponseType(typeof(IEnumerable<QuizDto>), 200)]
        public IActionResult GetAll()
        {
            IEnumerable<QuizDto> dtos = _service.GetAll()
                                                .Select(quiz => _mapper.ToDto(quiz));

            return Ok(dtos);
        }
        
    }
}