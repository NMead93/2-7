using System.Collections.Generic;

namespace board.Objects
{
    public class Contact
    {
        private string _name;
        private string _email;
        private string _phone;


        public Contact(string name, string email, string phone)
        {
            _name = name;
            _email = email;
            _phone = phone;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetEmail(string email)
        {
            _email = email;
        }

        public string GetEmail()
        {
            return _email;
        }

        public void SetPhone(string phone)
        {
            _phone = phone;
        }

        public string GetPhone()
        {
            return _phone;
        }
    }

}