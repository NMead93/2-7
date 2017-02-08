using System.Collections.Generic;
using board.Objects;

namespace board.Objects
{
    public class Job
    {
        private string _title;
        private string _description;
        private Contact newContact;
        private static List<Job> applications = new List<Job>() { };

        public Job(string title, string description, Contact contact)
        {
            _title = title;
            _description = description;
            newContact = contact;
        }

        public string GetTitle()
        {
            return _title;
        }

        public void SetTitle(string title)
        {
            _title = title;
        }

        public void SetDescription(string description)
        {
            _description = description;
        }

        public string GetDescription()
        {
            return _description;
        }

        public Contact GetContact()
        {
            return newContact;
        }

        public void Save()
        {
            applications.Add(this);
        }

        public static List<Job> GetApplications()
        {
            return applications;
        }
    }
}