using System;
					

public class program
{
	public static string eingabe;
	public static void Main() {
		do {
		Console.WriteLine("Enter your binary Number: ");
		String binaryInput = Console.ReadLine();
		int binaryLength = binaryInput.Length;
		int pow = ((binaryLength - ( binaryLength % 3)) / 3 );
		int cutIntOctal = 0;
		double result = 0;
		//int pow = 0;
		if (binaryLength % 3 == 0) {
			binaryLength = binaryInput.Length;
			
			Console.WriteLine("pow is: " + pow);
		 for (int i=0; i < binaryLength; i++) {
		     if ( (i+1) % 3 == 0) {
				 
		         String cut = binaryInput.Substring((i-2),3);
				 Console.WriteLine("cut is " + cut);
		         int four = Convert.ToInt32(cut.Substring(0,1)) * 4;
		         int two = Convert.ToInt32(cut.Substring(1,1)) * 2;
		         int one = Convert.ToInt32(cut.Substring(2,1)) * 1;
		         cutIntOctal = four + two + one;
				 Console.WriteLine("cutIntOctal is: " + cutIntOctal);
				 result = (Math.Pow(10, (pow-1))) * cutIntOctal + result;
				 pow--;
			 	 
		     }
			 
		 }
		} else if (binaryLength % 3 == 1) {
			binaryInput = "00" + binaryInput;
			binaryLength = binaryInput.Length;
			pow++;
			Console.WriteLine("binary input is " + binaryInput);
			for (int i=0; i < binaryLength; i++) {
		     if ( (i+1) % 3 == 0) {
				 
		         String cut = binaryInput.Substring((i-2),3);
				 Console.WriteLine("cut is " + cut);
		         int four = Convert.ToInt32(cut.Substring(0,1)) * 4;
		         int two = Convert.ToInt32(cut.Substring(1,1)) * 2;
		         int one = Convert.ToInt32(cut.Substring(2,1)) * 1;
		         cutIntOctal = four + two + one;
				 Console.WriteLine("cutIntOctal is: " + cutIntOctal);
				 result = (Math.Pow(10, (pow-1))) * cutIntOctal + result;
				 pow--;
			 	 
		     }
			 
		 }
		} else if (binaryLength % 3 == 2) {
			binaryInput = "0" + binaryInput;
			binaryLength = binaryInput.Length;
			pow++;
			Console.WriteLine("binary input is " + binaryInput);
			for (int i=0; i < binaryLength; i++) {
		     if ( (i+1) % 3 == 0) {
				 
		         String cut = binaryInput.Substring((i-2),3);
				 Console.WriteLine("cut is " + cut);
		         int four = Convert.ToInt32(cut.Substring(0,1)) * 4;
		         int two = Convert.ToInt32(cut.Substring(1,1)) * 2;
		         int one = Convert.ToInt32(cut.Substring(2,1)) * 1;
		         cutIntOctal = four + two + one;
				 
				 Console.WriteLine("cutIntOctal is: " + cutIntOctal);
				 result = (Math.Pow(10, (pow-1))) * cutIntOctal + result;
				 pow--;
			 	 
		     }
			 
		 }
		}
		Console.WriteLine(" \n the octal number is : " + result);
		Console.WriteLine(" \n is armita's teacher a bitch?");
		eingabe = Console.ReadLine();
		} while(eingabe == "ja");
	}
}
