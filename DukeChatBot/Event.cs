using System;
class Event : TaskD
{   

    protected override string Category 
    { 
        get { return base.Category;} set { base.Category = value; }
    }
   

    public Event(string description) : base(description)
    {
        Category = "E";
    }

    //public string getCategory() {
    //    return Event.Category;            // supposed to be get T,D, or E.
    //}
    public override void PrintTask()
    {
        Console.WriteLine("Got it. I've added this task: ");
        Console.WriteLine($"{get.Category()}")
        Console.WriteLine($"Great! You have a total of {listTask.Count} task(s) in the list.\n"); 
    }

}