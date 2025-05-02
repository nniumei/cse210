using System;

class Program
{
    static void Main(string[] args)
    {
        Experience exp1 = new Experience();
        exp1._position = "Backend Developer";
        exp1._organization = "OpenTech Solutions";
        exp1._yearStarted = 2020;
        exp1._yearEnded = 2022;

        Experience exp2 = new Experience();
        exp2._position = "Systems Analyst";
        exp2._organization = "CyberCore Inc.";
        exp2._yearStarted = 2022;
        exp2._yearEnded = 2024;

        CareerProfile profile = new CareerProfile();
        profile._fullName = "Jordan Miles";
        profile._experienceList.Add(exp1);
        profile._experienceList.Add(exp2);

        profile.ShowProfile();
    }
}
