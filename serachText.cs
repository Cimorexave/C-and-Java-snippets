using System;

namespace oops3
{


    public class Demo
    {
		public static string eingabe;

        public static void Main(string[] args)
        {
			do{
            Console.WriteLine("Enter the string");
            string Text = Console.ReadLine();
            Console.WriteLine("enter the word to be searched");
            string SearchText = Console.ReadLine();
            string[] myArray = new string[30];
            myArray = Text.Split(' ', '.', ',');
            int i = 0;
            foreach(string s in myArray)
            {
                i = i + 1;
				Console.WriteLine(" at index " + i + " string is " + s);
                if (s==SearchText)
                {
                    Console.WriteLine("The string found at position:" + i);
					
					Console.WriteLine("\nNochmal? Wenn ja geben Sie bitte ja an, sonst können Sie alles mögliche eingeben um abzubrechen.");
					break;
						}
            }
			eingabe = Console.ReadLine();
			}
			while(eingabe == "ja");
        }
    }
}

