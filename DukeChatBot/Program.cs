// See https://aka.ms/new-console-template for more information
using System;
using System.Formats.Asn1;
using System.Reflection;

namespace Boot.Y.Call
{
  class Program
  {
    static void Main(string[] args)
    {


string[] items = new string[100];
string input;
string newItem;
int numItems=0;
newItem=null;

string name="Boot.Y.Call";

Console.WriteLine($"\n\nHello! I'm {name}"); 
Console.WriteLine("What can I do for you?\n");

Console.WriteLine("What are you feeding me today?");



while(!Equals(newItem, "bye"))
{
  while(!Equals(newItem, "list") && !Equals(newItem, "bye"))
  {
    input = Console.ReadLine();
    newItem= input;

        if (!Equals(newItem, "list") && !Equals(newItem, "bye"))
        {
            items[numItems] = newItem;
            numItems++;
            Console.WriteLine("added: " + input);
        }

        else
        {
            if (newItem == "list")
            {
                for (int i = 0; i < numItems; i++)
                {

                    Console.WriteLine((i + 1) + ".\t" + items[i]);

                }
                Console.WriteLine("end list\n");
                newItem = null;
            }

        }

    }
}