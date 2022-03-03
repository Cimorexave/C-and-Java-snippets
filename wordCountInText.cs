using System;

namespace oops3
{


    public class Demo
    {
		public static string eingabe;
        public static void Main(string[] args)
        {
			do {
			//Eingaben des Texts
            Console.WriteLine("Geben Sie Ihren Text ein");
            string Text = Console.ReadLine();
			
			//Eingabe des Wortes das gesucht werden muss 
            //Console.WriteLine("Geben Sie das Wort ein das Sie suchen möchten im Text");
            string SearchText; 
				
			//Suchen (Das Wort im Text schneiden und in einer Array stellen damit ich die position zählen kann)
            string[] myArray = new string[30];
            myArray = Text.Split(' ', '.', ',');
            int i = 0;
            foreach(string word in myArray)
            {
				SearchText = word;
				foreach(string inWord in myArray) {
					
					if (SearchText == inWord)
					{
						i++;
					}
				}
				Console.WriteLine("the word: " + SearchText + " is repeated " + i + " times in the text.");

				i = 0;
            }
			eingabe = Console.ReadLine();
			}
			while(eingabe == "ja");
        }
    }
}