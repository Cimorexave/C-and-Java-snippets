using System;
					
                    //add, sub, mult, div
public class Calculator
{
    
	//decimal methods
	static int Add(int a , int b ) {
        return (a+b);
    } 
    static int Sub(int a, int b) {
        return(a-b);
    }
    static int Mul(int a, int b) {
        return (a*b);
    }
    static int Div(int a, int b) {
        return (a/b);
    }
	public static void Main()
	{
		string lastResult = "";
        string operation = "";
		int a = 0;
		int b = 0;
		//choosing numerical system
		// decimal, binary, octal, hexadecimal
		Console.WriteLine("choose your numerical system");
		String numericalSystem = Console.ReadLine();
		
        //decimal system
		if (numericalSystem == "decimal") {
			//getting inputs
			Console.WriteLine("input a");
			 a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("input operation");
			operation = Console.ReadLine();
			Console.WriteLine("input b");
			 b = Convert.ToInt32(Console.ReadLine());
			
            if (operation == "+") {
                Console.WriteLine("your result is: " + Add(a , b));
                lastResult = Add(a,b).ToString();
            } else if (operation == "-") {
                Console.WriteLine("your result is: " + Sub(a , b));
                lastResult = Sub(a,b).ToString();
            } else if (operation == "*") {
                Console.WriteLine("your result is: " + Mul(a , b));
                lastResult = Mul(a,b).ToString();
            } else if (operation == "/") {
                Console.WriteLine("your result is: " + Div(a , b));
                lastResult = Div(a,b).ToString();
            } 
		}
        //binary system
        if (numericalSystem == "binary") {
            Console.WriteLine("input a");
			 a = Convert.ToInt32(Console.ReadLine(), 2);
			Console.WriteLine("input operation");
			operation = Console.ReadLine();
			Console.WriteLine("input b");
			 b = Convert.ToInt32(Console.ReadLine(), 2);
            if (operation == "+") {
                Console.WriteLine("your result is: " + Convert.ToString(Convert.ToInt32(Add(a,b)), 2));
                lastResult = Add(a,b).ToString();
            } else if (operation == "-") {
                Console.WriteLine("your result is: " + Convert.ToString(Convert.ToInt32(Sub(a,b)), 2));
                lastResult = Sub(a,b).ToString();
            } else if (operation == "*") {
                Console.WriteLine("your result is: " + Convert.ToString(Convert.ToInt32(Mul(a,b)), 2));
                lastResult = Mul(a,b).ToString();
            } else if (operation == "/") {
                Console.WriteLine("your result is: " + Convert.ToString(Convert.ToInt32(Div(a,b)), 2));
                lastResult = Div(a,b).ToString();
            } 
        }
        //octal system
        if (numericalSystem == "octal") {
            Console.WriteLine("input a");
			 a = Convert.ToInt32(Console.ReadLine(), 8);
			Console.WriteLine("input operation");
			operation = Console.ReadLine();
			Console.WriteLine("input b");
			 b = Convert.ToInt32(Console.ReadLine(), 8);
            if (operation == "+") {
                Console.WriteLine("your result is: " + Convert.ToString(Convert.ToInt32(Add(a,b)), 8));
                lastResult = Add(a,b).ToString();
            } else if (operation == "-") {
                Console.WriteLine("your result is: " + Convert.ToString(Convert.ToInt32(Sub(a,b)), 8));
                lastResult = Sub(a,b).ToString();
            } else if (operation == "*") {
                Console.WriteLine("your result is: " + Convert.ToString(Convert.ToInt32(Mul(a,b)), 8));
                lastResult = Mul(a,b).ToString();
            } else if (operation == "/") {
                Console.WriteLine("your result is: " + Convert.ToString(Convert.ToInt32(Div(a,b)), 8));
                lastResult = Div(a,b).ToString();
            } 
        }
        //hexadecimal system
        if (numericalSystem == "hexadecimal") {
            Console.WriteLine("input a");
			 a = Convert.ToInt32(Console.ReadLine(), 16);
			Console.WriteLine("input operation");
			operation = Console.ReadLine();
			Console.WriteLine("input b");
			 b = Convert.ToInt32(Console.ReadLine(), 16);
            if (operation == "+") {
                Console.WriteLine("your result is: " + Convert.ToString(Convert.ToInt32(Add(a,b)), 16));
                lastResult = Add(a,b).ToString();
            } else if (operation == "-") {
                Console.WriteLine("your result is: " + Convert.ToString(Convert.ToInt32(Sub(a,b)), 16));
                lastResult = Sub(a,b).ToString();
            } else if (operation == "*") {
                Console.WriteLine("your result is: " + Convert.ToString(Convert.ToInt32(Mul(a,b)), 16));
                lastResult = Mul(a,b).ToString();
            } else if (operation == "/") {
                Console.WriteLine("your result is: " + Convert.ToString(Convert.ToInt32(Div(a,b)), 16));
                lastResult = Div(a,b).ToString();
            } 
        }
		
	}
}