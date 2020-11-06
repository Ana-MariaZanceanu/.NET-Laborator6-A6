using laborator6.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace laborator6.Data
{
    public class ToDoRepository : IToDoRepository
    {
        private readonly DataContext _context;
        public ToDoRepository(DataContext context)
        {
            _context = context;
        }

        public void Create(ToDo toDo)
        {
            _context.Add(toDo);
            _context.SaveChanges();
        }

        public IEnumerable<ToDo> GetAll()
        {
            return _context.ToDos.ToList();
        }

        public IEnumerable<ToDo> GetActiveToDos()
        {
            DateTime localDate = DateTime.Now;
            var activeToDos = _context.ToDos.Where(t => (t.Created.CompareTo(localDate) <= 0 && t.IsDone == false));
            return activeToDos.ToList();
        }

        public IEnumerable<ToDo> GetDoneToDos()
        {
            var activeToDos = _context.ToDos.Where(t => t.IsDone == true);
            return activeToDos.ToList();
        }

        public ToDo GetById(int id)
        {
            return _context.ToDos.Where(t => t.Id == id).FirstOrDefault();
        }

        public void Remove(int id)
        {
            ToDo toDo = GetById(id);
            _context.Remove(toDo);
            _context.SaveChanges();
        }

        public void Update(int id, ToDo newToDo)
        {
            _context.Update(newToDo);
            _context.SaveChanges();
        }
    }
}
