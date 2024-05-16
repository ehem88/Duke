using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


abstract class TaskD
{
    //property
    protected string Description { get; set;}
    protected string Category { get; set;}
    private bool IsDone{ get; set; }


    //constructor
    protected TaskD(string description) 
    {
        this.Description = description;
        this.IsDone = false;
    }

    //methods
    protected string getStatusIcon() {
        return (IsDone ? "\u2713" : " "); //return tick or X symbols
    }


    public void markAsDone () {
        this.IsDone = true;
    }

    public abstract void PrintTask ();
}

