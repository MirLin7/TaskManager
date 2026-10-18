using System;
using System.Threading.Tasks;
namespace TaskManager
{
    class Task
{   
        public Task(string description, string name, bool IsFavourite, bool IsDone)
        {
            this.description = description;
            this.name = name;
            this.IsFavourite = IsFavourite;
            this.IsDone = IsDone;
            this.Createdat = DateTime.Now;
        }
        public string description;
        public string name;
        public bool IsFavourite = false;
        public bool IsDone = false;
        public DateTime Createdat;
}
}