using System;
// 10 => 1010
					
public class Program
{
	public static void Main()
	{  
    	string result; 
  
         Console.Write("Input a Number : ");
        string input = Console.ReadLine();
         
            int num = Convert.ToInt32(input);
            result = "";
            while (num > 1)
            {
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                num /= 2;
            }
            result = Convert.ToString(num) + result;
            Console.WriteLine("Binary: " + result);
				
		
	}
}