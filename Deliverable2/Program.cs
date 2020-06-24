using System;
using System.Text;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your message?");
            string input = Console.ReadLine();
            string capinput = input.ToUpper();
            char[] inputarray = capinput.ToCharArray();
            byte[] asciiBytes = Encoding.ASCII.GetBytes(capinput);
            int Checksum = 0;
            String message = "";
            foreach (byte bob in asciiBytes)
            {
                Checksum = Checksum + bob;
                message = message + (bob - 64)+"-";
            }
                Console.WriteLine("Message Checksum is: "+Checksum);
            Console.WriteLine("Your code is: "+ message); 

            




















        }


        }
    }


