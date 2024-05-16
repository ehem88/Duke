// See https://aka.ms/new-console-template for more information
using System;
using System.Formats.Asn1;
using System.Net.NetworkInformation;
using System.Reflection;


namespace Boot.Y.Call
{
  class Program
    {
        static void Main(string[] args)
            {
                ChatbotGreet lesson = new ChatbotGreet();
                TaskList myBootyListLesson = new TaskList();
                myBootyListLesson.MyList(); 
                //lesson.GoodbyeForReal();
            }

    }   
}