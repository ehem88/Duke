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
    string gotit=("Got it. I've added this task: ");
    public void MyList()
    {
        
        List<TaskD> listTask = new List<TaskD>();
        ChatbotGreet commands = new ChatbotGreet();
        commands.Message();
        string userInput = Console.ReadLine(); 

        while(!Equals(userInput.ToLower(), "bye"))   // G: adding Contains makes it a double boolean???
        {
            
            if(!Equals(userInput.ToLower(), "list"))
            {
                if (userInput=="")
                {  
                    Console.WriteLine("Please try again");
                    //userInput = Console.ReadLine();
                    //continue;     
                }
                
                //if (userInput.Contains("done"))        
                //if (userInput.ToLower().Contains( "done"))
                else if (userInput.ToLower().Contains ("done"))                              
                {
                    //1. split the user input
                    // check the length of the array is equal to 2
                    // check first word is done
                    // convert second word into an int
                    // if cannot then exit (HOW TO DO THIS GOPAL)
                    //else second word is already an int
                    // pick out the task number x from the list of taks
                    // then mark as done

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
                else if (userInput.ToLower().Contains ("todo"))
                {
                    string [] sentence = userInput.Split( ' ');    // GOPAL: does the spacing matter for  '  '
                    string first=sentence.First();                      //G: when to use var or string
                    string secondtoend = string.Join(" ",sentence.Skip(1));
                    string last=sentence.Last();
                    string firsttosecondlast = string.Join(" ",sentence.Take(sentence.Length - 1));  //G:LOL is there better way?

                    // this doesnt work --- if ((sentence.Length < 2) && (!Equals(first.ToLower(), "todo")) && (!Equals(last.ToLower(), "todo")))
                    if (sentence.Length < 2)
                    {
                        Console.WriteLine("Please try again! Your input is not understood!");
                        userInput=Console.ReadLine();
                        continue; 
                    }
                    
                    else if ((!Equals(first.ToLower(), "todo")) && (!Equals(last.ToLower(), "todo")))
                    {
                        Console.WriteLine("Please try again! Your input is not understood!");
                        userInput=Console.ReadLine();
                        continue;
                        
                    } 
                    else if (Equals(first.ToLower(), "todo"))
                    {
                        TaskD newTask = new Todo(secondtoend); 
                        //newTask.markAsDone();
                        listTask.Add(newTask);
                        Console.WriteLine(gotit);
                        Console.WriteLine($" [{newTask.getCategory()}] [{newTask.getStatusIcon()}] {secondtoend}");
                        Console.WriteLine($"Great! You have a total of {listTask.Count} task(s) in the list.\n");
                    }
                    else if (Equals(last.ToLower(), "todo"))
                    {
                        TaskD newTask = new Todo(firsttosecondlast); 
                        //newTask.markAsDone();
                        listTask.Add(newTask);
                        Console.WriteLine(gotit);
                        Console.WriteLine($" [{newTask.getCategory()}] [{newTask.getStatusIcon()}] {firsttosecondlast}"); //why cannot use newtask as variable
                        Console.WriteLine($"Great! You have a total of {listTask.Count} task(s) in the list.\n"); 
                    }
                    
                }
                else if (userInput.ToLower().Contains ("deadline"))
                {
                    string [] sentence = userInput.Split( ' ');

                    string part1 = string.Join("",sentence.Take(1));
                    string part2 = string.Join(" ",sentence.Skip(1));

                    
                     
                    TaskD newTask = new Deadline(part2); 
                    //newTask.markAsDone();
                    listTask.Add(newTask);
                    Console.WriteLine(gotit);
                    Console.WriteLine($" [{newTask.getCategory()}] [{newTask.getStatusIcon()}] {part2}");
                    Console.WriteLine($"Great! You have a total of {listTask.Count} task(s) in the list.\n");
                    
                }
                else if (userInput.ToLower().Contains ("event")) //does order matter. like contains come before tolower
                {
                    string [] sentence = userInput.Split( ' ');

                    string part1 = string.Join("",sentence.Take(1));
                    string part2 = string.Join(" ",sentence.Skip(1));

                   
                    TaskD newTask = new Event(part2); 
                    //newTask.markAsDone();
                    listTask.Add(newTask);
                    Console.WriteLine(gotit);
                    Console.WriteLine($" [{newTask.getCategory()}] [{newTask.getStatusIcon()}] {part2}");
                    Console.WriteLine($"Great! You have a total of {listTask.Count} task(s) in the list.\n");
                    
                }
            }
            else
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

            Console.WriteLine("Enter your next input or enter 'help' for list for commands.");
            userInput = Console.ReadLine();  

            if (userInput.ToLower() == "help")
            {
                commands.Message();
                userInput = Console.ReadLine();  
            }
            
             
            
            
        }
        Console.WriteLine("bye ass!!");
        //userInput="bye";
        
    }
   
    public void splitSentence ()                    
    {
        Console.WriteLine("HELLO");
        
    }
}

