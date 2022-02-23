using System;
			
//decimal to octal
// 10 => 12
public class Program
{
	public static void Main()
	{
		string result; 
		string eingabe;
		
		do {
  
         Console.Write("Input your decimal number : ");
        string input = Console.ReadLine();
         
            int num = Convert.ToInt32(input);
            result = "";
            while (num > 1)
            {
                int remainder = num % 8;
                result = Convert.ToString(remainder) + result;
                num /= 8;
            }
			if (num != 0)
            	result = Convert.ToString(num) + result;
            Console.WriteLine("octal: " + result);
			Console.WriteLine("do you want to continue? say ja! ");
			eingabe = Console.ReadLine();
			
		} while(eingabe == "ja");
	}
}