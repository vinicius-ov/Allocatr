using System;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Allocatr
{
    [Table("employees")]
    public class Employee
    {
        [PrimaryKey, AutoIncrement, Column("id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Skill { get; set; }

        public Employee(string name, string skill)
        {
            Name = name;
            Skill = skill;
        }

        public Employee()
        {

        }
        public override string ToString()
        {
            return "Employee: " + Name + " " + Skill;
        }
}
}
