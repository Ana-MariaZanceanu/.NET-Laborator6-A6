using laborator6.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace laborator6.Data
{
    public interface IToDoRepository
    {
        IEnumerable<ToDo> GetAll();
        IEnumerable<ToDo> GetActiveToDos();
        IEnumerable<ToDo> GetDoneToDos();
        void Create(ToDo toDo);
        ToDo GetById(int id);
        void Remove(int id);
        void Update(int id, ToDo newToDo);
    }
}
