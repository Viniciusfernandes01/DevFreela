using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        private readonly OpeningTimeOption _option;

        public ProjectsController(IOptions<OpeningTimeOption> option)
        {
            _option = option.Value;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Teste");
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            return Ok(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateProjectModel createProject)
        {
            return CreatedAtAction(nameof(GetById), new { id = createProject.Id });
        }

        [HttpPut("id")]
        public IActionResult Put(int id, [FromBody] UpdateProjectModel updateProject)
        {
            return NoContent();
        }

        [HttpDelete("id")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }

    }
}
