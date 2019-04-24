using System;
using System;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Allocatr.Model
{
    [Table("projects_employees")]
    public class ProjectEmployee
    {
        [ForeignKey(typeof(Project))]
        public int IdProject { get; set; }
        [ForeignKey(typeof(Employee))]
        public int IdEmployee { get; set; }

        public ProjectEmployee()
        {
        }


    }
}