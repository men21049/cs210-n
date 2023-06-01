using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign = new Assignment("JC Mena", "Calculus");
        Console.WriteLine(assign.GetSummary());

        // Now create the derived class assignments
        MathAssignment mathassign = new MathAssignment("JC Mena", "Algebra", "8.2", "18-39");
        Console.WriteLine(mathassign.GetSummary());
        Console.WriteLine(mathassign.GetHomeworkList());

        WritingAssignment writingassign = new WritingAssignment("JC Mena", "Rhetoric Analysis", "Commencement speech");
        Console.WriteLine(writingassign.GetSummary());
        Console.WriteLine(writingassign.GetWritingInformation());
    }
}