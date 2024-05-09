using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


class TaskD
{
    //property
    private string Description { get; set;}

    protected virtual string Category { get; set;}
    private bool IsDone{ get; set; }

    public int Number {get;}    // why no need set
    private static int nextNumber=1;

    //private string E; use derived class instead
    //private string D;
    //private string T;

    //constructor
    public TaskD(string description) 
    {
        this.Description = description;
        this.IsDone = false;
        Number = nextNumber;
        nextNumber++;
    }

    //methods
    public string getStatusIcon() {
        return (IsDone ? "\u2713" : " "); //return tick or X symbols
    }

    public string getDescription() {
        return this.Description;
    }

    public string getCategory() {
        return this.Category;     // supposed to be get T,D, or E. // is it can use abstraction to do this part. no need body, but override in todo... classes
    }
    public int getNumber() {
        return this.Number;
    }

    public void markAsDone () {
        this.IsDone = true;
    }

 
}

