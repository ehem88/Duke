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


}