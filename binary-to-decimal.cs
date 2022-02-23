using System;
// binary to decimal
// 111 => 7
					
public class Program
{
	public static void Main()
	{
		//getting binary input
		Console.WriteLine("input binary ");
		String Input = Console.ReadLine();
		//finding the length of the binary input
		int length = Input.Length;
		//calculating the power 
		int pow = length -1;
		double result = 0;
		for (int i=0; i< length; i++) {
			//going through each number and turning into decimal
			int cut = Convert.ToInt32(Input.Substring(i,1));
			//adding all together
			result = result + cut * (Math.Pow(2,pow));
			pow--;
		}
		//printing the final result
		Console.WriteLine("decimal is " + result);
	}
}
