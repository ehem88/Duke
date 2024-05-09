using System;
class ChatbotGreet
    {
        string greeting=("Hello! I'm Bot-Ro.\nWhat can I do for you?");
        string instruct=("Please enter your task.");
       
        //string goodbye=("Type 'bye' to end the program.");

        string input1 = "";
        string reply = "";
        

        public ChatbotGreet()
            {
                Console.WriteLine(greeting);
                Console.WriteLine();
                Console.WriteLine(instruct);
                Console.WriteLine();
                 
            }

        public void GoodbyeForReal()
            {
                Console.WriteLine("\nSurprise, you didnt say bye the right way!");
                input1= Console.ReadLine();
                reply=input1;

                while(reply!="bye mf")
                {
                    Console.WriteLine(reply + " is not the right message, pls try again.\n");

                    input1=Console.ReadLine();
                    reply=input1;

                }
                Console.WriteLine("BYE BYE X 3000");
            }


        public void Message () 
            {
        Console.WriteLine("Available Commands:\n1. 'bye' to exit,\n2. 'list' to list items,\n3. 'done (task number)' to complete tasks,\nOr just input your task!");
            
            
            }





    }