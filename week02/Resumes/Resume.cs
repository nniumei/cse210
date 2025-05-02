using System;
using System.Collections.Generic;

public class CareerProfile
{
    public string _fullName;
    public List<Experience> _experienceList = new List<Experience>();

    public void ShowProfile()
    {
        Console.WriteLine($"Candidate: {_fullName}");
        Console.WriteLine("Work History:");
        foreach (Experience exp in _experienceList)
        {
            exp.PrintDetails();
        }
    }
}
