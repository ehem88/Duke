using System;
using System.Formats.Asn1;
using System.Reflection;
class List
    {
    string[] items = new string[100];
    string input;
    string newItem;
    int numItems=0;
    

    public void MyList()
    {
        newItem=null;

        while(!Equals(newItem, "bye"))
{
  if(!Equals(newItem, "list") && !Equals(newItem, "bye"))
  {
    input = Console.ReadLine();
    newItem= input;

        if ((newItem!="list") && (newItem!="bye") && (newItem!=""))
        {
            items[numItems] = newItem;
            numItems++;
            Console.WriteLine("added: " + input);
        }

        else if (newItem == "list")       
        {
            for (int i = 0; i < numItems; i++)
            {

                Console.WriteLine((i + 1) + ".\t" + items[i]);

            }
                Console.WriteLine("end list\n");
                newItem = null;

        }

        else if  ((newItem=="bye") || (newItem==""))
        {
            Console.WriteLine("bye ass!!");
            newItem="bye";
        }

    }



}


    }

    }