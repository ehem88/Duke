using System;
class Todo : TaskD
{

    protected override string Category 
    { 
        get { return base.Category;} set { base.Category = value; }
    }


    public Todo(string description) : base(description)
    {
        Category = "T";
    }

    //public string getCategory() {
    //    return Todo.Category;            // supposed to be get T,D, or E.
    //}
    public override void PrintTask()
    {
        Console.WriteLine("Got it. I've added this task: ");
        Console.WriteLine($"{Category} {getStatusIcon} {this.Description}");
    }

}