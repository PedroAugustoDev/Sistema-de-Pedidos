using System;


namespace IFood.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; private set; }
        public DateTime BrithDate { get; private set; }

        public Client() { }

        public Client(string name, string email, DateTime brithDate)
        {
            Name = name;
            Email = email;
            BrithDate = brithDate;
        }

        public override string ToString()
        {
            return $"{Name} - {BrithDate} - {Email}";
        }
    }
}
