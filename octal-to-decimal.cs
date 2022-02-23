using System;
//octal to decimal
// 12 => 10
					
public class Program
{
	public static void Main()
	{
		double res = 0;
		String eingabe;
		//getting input 
		do {
		Console.WriteLine("input octal ");
		String input = Console.ReadLine();
		//going through each number from left to right
		for (int i = 0; i < input.Length; i++) {
			//converting each number from octal to decimal by multiplying to the correct power of eight
			int cut = Convert.ToInt32(input.Substring(i,1));	
			//adding all the numbers to get the decimal conversion 
			res = cut * Math.Pow(8 , (input.Length -(i+1))) + res;
		}
		Console.WriteLine("the decimal is: " + res);
		res = 0;
		Console.WriteLine("do you want to continue?");
		eingabe = Console.ReadLine();
		} while(eingabe == "ja");
	}
}