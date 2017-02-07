using System.Collections.Generic;

namespace ToDoList.objects
{
    public class Task
    {
        private string _title;
        private static List<string> title = new List<string> { };

        public Task(string task)
        {
            _title = task;
        }

        public void SetTitle(string task)
        {
            _title = task;
        }

        public string GetTitle()
        {
            return _title;
        }

        public void Save()
        {
            title.Add(_title);
        }

        public static void ClearAll()
        {
            title.Clear();
        }

        public static List<string> GetAll()
        {
            return title;
        }
    }
}