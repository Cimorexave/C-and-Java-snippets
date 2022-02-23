using System;
					
//octal to binary
// 130 => 1011000
public class Program
{
	public static void Main()
	{
		string eingabe;
		do {
			Console.WriteLine("input your octal number: ");
			string input = Console.ReadLine();
			string cutBinary;
			string result = "";
			for (int j=0; j < input.Length; j++) {
				int cut = Convert.ToInt32(input.Substring(j,1));

				cutBinary = "";
				while (cut > 1)
				{
					int remainder = cut % 2;
					cutBinary = Convert.ToString(remainder) + cutBinary;
					cut /= 2;
				}
				cutBinary = Convert.ToString(cut) + cutBinary;
				if (j != 0 ) {
					if (cutBinary.Length == 1) cutBinary = "00" + cutBinary;
					else if ( cutBinary.Length == 2) cutBinary = "0" + cutBinary;
					//Console.WriteLine("cutBinary is: " + cutBinary);
				}
				result = result + cutBinary;
			} 
			Console.WriteLine("result is " + result);
			Console.WriteLine("to repeat, type ja! ");
			eingabe = Console.ReadLine();
		} while (eingabe == "ja");
	}
}