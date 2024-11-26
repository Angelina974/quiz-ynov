using Ynov.QuizYnov.Controllers.Mappers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ynov.QuizYnov.Business;
using Ynov.QuizYnov.Controllers.Dtos;
using Ynov.QuizYnov.Business.Models;

namespace Ynov.QuizYnov.Controllers
{
    [Route("api/quizzes")]
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

        [HttpGet("{id}", Name = "GetQuizById")]
        [ProducesResponseType(typeof(QuizDto), 200)]
        public IActionResult Get(Guid id)
        {
            var quiz = _service.Get(id);
            if (quiz == null){ 
                return NotFound(); 
            }
            
            QuizDto dto = _mapper.ToDto(quiz);
            return Ok(dto);
        }

        
    }
}