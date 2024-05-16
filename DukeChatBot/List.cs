using System;
using System.Formats.Asn1;
using System .Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;



class TaskList
{
    public void MyList()
    {
        
        List<TaskD> listTask = new List<TaskD>();
        ChatbotGreet commands = new ChatbotGreet();
        commands.Message();
        string userInput = Console.ReadLine().ToLower(); 

        string [] input = userInput.Split( ' ');
        string part1 = string.Join("",input.Take(1));
        string part2 = string.Join(" ",input.Skip(1));

        


        //while(!Equals(userInput.ToLower(), "bye"))   // G: adding Contains makes it a double boolean???
        while (userInput != "bye")
        {
            if (userInput.ToLower() == "help")
            {
                commands.Message();
                userInput = Console.ReadLine();  
            }

            if(userInput == "list")
            {
                if (listTask.Count < 1)
                {
                    Console.WriteLine("There is nothing on the list of tasks. Please enter a task!");
                }
                else
                {
                // print out the list of items
                Console.WriteLine("Here are the tasks in your list:");

                foreach (TaskD t in listTask) // get.category supposed to be E,T,D for event, todo, deadline
                {        
                    Console.WriteLine($"No.{t.getNumber()} [{t.getCategory()}] [{t.getStatusIcon()}] {t.getDescription()}  ");
                }
                
                Console.WriteLine("----------------------------------------\n");
                }

            }   
                
            if (userInput=="")
            {  
                Console.WriteLine("Please try again");
                //userInput = Console.ReadLine();
                //continue;     
            }
                
                //if (userInput.Contains("done"))        
                //if (userInput.ToLower().Contains( "done"))
            if (part1 =="done")                              
                {
                    string [] parts = userInput.Split(new char [] { ' ' }, 2);

                    int intSplit;

                    if ((int.TryParse(parts[0], out intSplit)) || (int.TryParse(parts[1], out intSplit))) 
                    {   
                        if (intSplit <= listTask.Count)
                        {
                            int x = intSplit-1;
                            listTask.ElementAt(x).markAsDone();
                            Console.WriteLine("This task has been marked as complete.");
                            Console.WriteLine($"[{listTask.ElementAt(x).getStatusIcon()}] {listTask.ElementAt(x).getDescription()}"); 
                        }
                        else
                        {
                            Console.WriteLine($"Please note that there are {listTask.Count} tasks in the lists.");
                            Console.WriteLine($"Try again!"); 
                        }
                    }   
                    else
                    {
                        Console.WriteLine("There has been an error!");
                        Console.WriteLine($"Please try again.");
                    }
                    
                }
            if (part1 =="todo")
            {
                Todo newTask = new Todo(part2);
                listTask.Add(newTask);
                newTask.PrintTask();    
            }

            if (part1 == "deadline")
            { 
                Deadline newTask = new Deadline(part2);
                listTask.Add(newTask);
                newTask.PrintTask();   
            }
            
            if (part1 == "event") 
            {

                TaskD newTask = new Event(part2); 
                //newTask.markAsDone();
                listTask.Add(newTask);
                PrintNumber(listTask);
                    
            }

            
            Console.WriteLine("Enter your next input or enter 'help' for list for commands.");
            userInput = Console.ReadLine();  
  
            
        }
        Console.WriteLine("bye ass!!");
        //userInput="bye";
        
    }
   

   
    public void PrintNumber (List<TaskD> listTask)
    {
        Console.WriteLine($"You have {listTask.Count} tasks now.");
    }


}

