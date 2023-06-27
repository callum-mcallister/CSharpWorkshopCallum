// See https://aka.ms/new-console-template for more information
using CSharpWorkshopDay5;

//student called Bruce Wayne 

Student BruceWayne = new Student();
Student SelinaKyle = new Student();

BruceWayne.NameOfStudent = "Bruce Wayne";
BruceWayne.StudyHoursPerWeek = 20;
BruceWayne.StudyWeeksCompleted = 0;

BruceWayne.NameOfStudent = "Bruce Wayne";
BruceWayne.StudyHoursPerWeek = 20;
BruceWayne.StudyWeeksCompleted = 0;

BruceWayne.BuildDisplayStudentInformation();
BruceWayne.DisplayStudentInformation();

SelinaKyle.NameOfStudent = "Selina Kyle";
SelinaKyle.StudyHoursPerWeek = 10;
SelinaKyle.StudyWeeksCompleted = 10;

SelinaKyle.NameOfStudent = "Selina Kyle";
SelinaKyle.StudyHoursPerWeek = 10;
SelinaKyle.StudyWeeksCompleted = 10;

SelinaKyle.BuildDisplayStudentInformation();
SelinaKyle.DisplayStudentInformation();
#region
//string outputForBatman = $" Student Name : {BruceWayne.NameOfStudent} Study Hours : {BruceWayne.StudyHoursPerWeek} Number of Weeks Completed : {BruceWayne.StudyWeeksCompleted}";

//string outputForCatwoman = $" Student Name : {SelinaKyle.NameOfStudent} Study Hours : {SelinaKyle.StudyHoursPerWeek} Number of Weeks Completed : {SelinaKyle.StudyWeeksCompleted}";

//Console.WriteLine(outputForBatman);
//Console.WriteLine(outputForCatwoman);
#endregion


//Super hero guy called the phantom 

Student KitWalker = new Student();
KitWalker.NameOfStudent = "KitWalker";
KitWalker.StudyHoursPerWeek= 30;
KitWalker.StudyWeeksCompleted = 30;

KitWalker.BuildDisplayStudentInformation();
KitWalker.DisplayStudentInformation();

//500 hours is the amount of time it takers to become a begginer developer 

int TotalNumberOfHoursToBecomeDevelepor = 500;

//20 hours per week
// 25 weeks to become a beginner developer 
//number of weeks already completed is 0
// remaining 25 - 0 = 25 weeks
// batman will become a develepor in 25 weeks 


// 10 hours per week
// 50 weeks to become a beginner developer 
// number of weeks already completed is 10 weeks
// remaining 50 - 10 = 40 weeks
// catwomen will be a developer in 40 weeks 