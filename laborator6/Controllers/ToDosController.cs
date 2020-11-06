using laborator6.Data;
using laborator6.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace laborator6.Controllers
{
    [Route("api/ToDos")]
    [ApiController]
    public class ToDosController : ControllerBase
    {
        private readonly IToDoRepository _repository;

        public ToDosController(IToDoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ToDo>> GetToDos()
        {
            return _repository.GetAll().ToList();
        }

        [HttpGet("active")]
        public ActionResult<IEnumerable<ToDo>> GetActiveToDos()
        {
            return _repository.GetActiveToDos().ToList();
        }

        [HttpGet("done")]
        public ActionResult<IEnumerable<ToDo>> GetDoneToDos()
        {
            return _repository.GetDoneToDos().ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<ToDo> GetToDo(int id)
        {
            return _repository.GetById(id);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] ToDo newToDo)
        {
            if (id != newToDo.Id)
            {
                return BadRequest();
            }
            _repository.Update(id, newToDo);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.Remove(id);
            return NoContent();
        }

        [HttpPost]
        public IActionResult PostToDo([FromBody] ToDo toDo)
        {
            _repository.Create(toDo);
            return CreatedAtAction("GetToDo", new { id = toDo.Id }, toDo);
        }
    }
}
