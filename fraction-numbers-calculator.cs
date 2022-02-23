using System;

/* 
	fraction calculator
	receives 2 inputs from the user 
	inputs are in the format of string and "a/b"
	the user inputs the operation
	operations are + , * , / , -
	program does the operations 
	simplify the result fraction of possible 
	program outputs the result and the process in which it was done
*/
public class Program
{
	//this function returns the greates common divisor of a , b which are later used to simplify the fractal result 
	public static int gcd(int a, int b)
	{
		// Everything divides 0
		if (a == 0)
			return b;
		if (b == 0)
			return a;
		// base case
		if (a == b)
			return a;
		// a is greater
		if (a > b)
			return gcd(a - b, b);
		else
			return gcd(a, b - a);
	}

	public static void Main()
	{
		string eingabe;
		//declaring variables
		int firstNumberNumerator, secondNumberNumerator, firstNumberDenominator, secondNumberDenominator;
		string result;
		do
		{
			//input
			Console.WriteLine("inputing your fractions should be in the format of for example: 2/5");
			Console.WriteLine("input your first fractal number");
			string firstNumber = Console.ReadLine();
			Console.WriteLine("input your operation ( + or - or * or / )");
			string operation = Console.ReadLine();
			Console.WriteLine("input your second fractal number");
			string secondNumber = Console.ReadLine();
			//finding the numerator and the denominator of each fractal number
			firstNumberNumerator = Convert.ToInt32(firstNumber.Substring(0, 1));
			secondNumberNumerator = Convert.ToInt32(secondNumber.Substring(0, 1));
			firstNumberDenominator = Convert.ToInt32(firstNumber.Substring(2, 1));
			secondNumberDenominator = Convert.ToInt32(secondNumber.Substring(2, 1));
			//doing the operations
			//add
			if (operation == "+")
			{
				int denominatorResult = secondNumberDenominator * firstNumberDenominator;
				int numeratorResult = firstNumberNumerator * secondNumberDenominator + secondNumberNumerator * firstNumberDenominator;
				//simplifying the result fractal
				int div = gcd(numeratorResult, denominatorResult);
				numeratorResult = numeratorResult / div;
				denominatorResult = denominatorResult / div;
				if (numeratorResult % denominatorResult == 0)
					result = "1";
				//final result
				else
					result = numeratorResult.ToString() + "/" + denominatorResult.ToString();
				//printing the operation and result
				Console.WriteLine(firstNumberNumerator + "/" + firstNumberDenominator + "  +  " + secondNumberNumerator + "/" + secondNumberDenominator + " = " + "(" + firstNumberNumerator + "*" + secondNumberDenominator + " + " + secondNumberNumerator + "*" + firstNumberDenominator + ")" + " / " + firstNumberDenominator + "*" + secondNumberDenominator + "  =  " + result);
			//Console.WriteLine("result is " + result);
			}
			//substract
			else if (operation == "-")
			{
				int denominatorResult = secondNumberDenominator * firstNumberDenominator;
				int numeratorResult = firstNumberNumerator * secondNumberDenominator - secondNumberNumerator * firstNumberDenominator;
				//simplifying the result fractal
				int div = gcd(numeratorResult, denominatorResult);
				numeratorResult = numeratorResult / div;
				denominatorResult = denominatorResult / div;
				if (numeratorResult % denominatorResult == 0)
					result = "1";
				//final result
				else
					result = numeratorResult.ToString() + "/" + denominatorResult.ToString();
				//printing the operation and result
				Console.WriteLine(firstNumberNumerator + "/" + firstNumberDenominator + "  -  " + secondNumberNumerator + "/" + secondNumberDenominator + " = " + "(" + firstNumberNumerator + "*" + secondNumberDenominator + " - " + secondNumberNumerator + "*" + firstNumberDenominator + ")" + " / " + firstNumberDenominator + "*" + secondNumberDenominator + "  =  " + result);
			//Console.WriteLine("result is " + result);
			}
			//multiply
			else if (operation == "*")
			{
				int numeratorResult = firstNumberNumerator * secondNumberNumerator;
				int denominatorResult = firstNumberDenominator * secondNumberDenominator;
				int div = gcd(numeratorResult, denominatorResult);
				//simpifying the result
				numeratorResult = numeratorResult / div;
				denominatorResult = denominatorResult / div;
				if (numeratorResult % denominatorResult == 0)
					result = "1";
				else
					result = numeratorResult.ToString() + "/" + denominatorResult.ToString();
				//printing the operation and result
				Console.WriteLine(firstNumberNumerator + "/" + firstNumberDenominator + "  *  " + secondNumberNumerator + "/" + secondNumberDenominator + " = " + "(" + firstNumberNumerator + "*" + secondNumberNumerator + ")" + " / " + "(" + firstNumberDenominator + "*" + secondNumberDenominator + ")" + "  =  " + result);
			//Console.WriteLine("multiply result: " + result);
			}
			//divide
			else if (operation == "/")
			{
				//the process here is almost the same as multiply
				//for a division we only need to reverse the second number and do a multiply
				int numeratorResult = firstNumberNumerator * secondNumberDenominator;
				int denominatorResult = firstNumberDenominator * secondNumberNumerator;
				//simplifying the result
				int div = gcd(numeratorResult, denominatorResult);
				numeratorResult = numeratorResult / div;
				denominatorResult = denominatorResult / div;
				if (numeratorResult % denominatorResult == 0)
					result = "1";
				else
					result = numeratorResult.ToString() + "/" + denominatorResult.ToString();
				//printing the operation and result
				Console.WriteLine("(" + firstNumberNumerator + "/" + firstNumberDenominator + ")" + "  /  " + "(" + secondNumberNumerator + "/" + secondNumberDenominator + ")" + "  =  " + firstNumberNumerator + "/" + firstNumberDenominator + "  *  " + secondNumberDenominator + "/" + secondNumberNumerator + " = " + "(" + firstNumberNumerator + "*" + secondNumberDenominator + ")" + " / " + "(" + firstNumberDenominator + "*" + secondNumberNumerator + ")" + "  =  " + result);
			}
			else
				Console.WriteLine("invalid operator");
			Console.WriteLine("if you want to do it again type ja !");
			eingabe = Console.ReadLine();
		}
		while (eingabe == "ja");
	}
}