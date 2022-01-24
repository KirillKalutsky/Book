using System;

namespace _3
{
    public class Person
    {
        public Person(string name, string surname, DateTime dateOfBirth, DateTime? dateOfDeath)
        {
            Name = name;
            Surename = surname;
            DateOfBirth = dateOfBirth;
            DateOfDeath = dateOfDeath;
        }
        public DateTime DateOfBirth { get; set; }
        public DateTime? DateOfDeath { get; set; }
        public string Name { get; set; }
        public string Surename { get; set; }
    }
}