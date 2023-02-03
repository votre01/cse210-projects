using System;

class Program
{
    static void Main(string[] args)
    {
        RecordProcessing rp = new RecordProcessing();

        //rp.CreateNewGoal();
        //rp.Save();
        rp.Load();
        //rp.LoadExistingGoals();
       

        foreach (Goal goal in rp._existingGoalsList)
        {
            //Console.WriteLine(goal);
            Console.WriteLine(goal.GetGoalName());
            Console.WriteLine(goal.GetGoalDescription());
            Console.WriteLine();
        }        
    }
}