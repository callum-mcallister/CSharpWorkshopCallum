using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWorkshopDay5
{
    public class Student
    {
        // fields or properties 
        public int StudyHoursPerWeek { get; set; }

        public int StudyWeeksCompleted { get; set; }

        public string NameOfStudent { get; set; }
        
        // For The sake of the output
        public string OutPutStorage { get; set; }   

        // Functions or methods or behaviours or actions

        public void BuildDisplayStudentInformation() 
        {
            this.OutPutStorage = $" Student Name : {this.NameOfStudent} Study Hours : {this.StudyHoursPerWeek} Number of Weeks Completed : {this.StudyWeeksCompleted}";

        }
        
        public void DisplayStudentInformation() 
        {
            Console.WriteLine(this.OutPutStorage);
        }
    }
}