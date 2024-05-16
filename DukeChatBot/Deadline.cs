using System;
class Deadline : TaskD
{   

    protected override string Category 
    { 
        get { return base.Category;} set { base.Category = value; }
    }

    public Deadline (string description) : base(description)
    {
        Category = "D";
    }

    //public string getCategory() {
    //    return Deadline.Category;            // supposed to be get T,D, or E.
    //}
    public override void PrintTask()
    {
        Console.WriteLine("Got it. I've added this task: ");
        Console.WriteLine($"{get.Category()}")
        Console.WriteLine($"Great! You have a total of {listTask.Count} task(s) in the list.\n"); 
    }

}