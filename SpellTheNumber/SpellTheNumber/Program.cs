using System;

class SpellTheNumber
{
	// strings at index 0 is not used, it is  to make array indexing simple 
	static string[] one = {"", "one ", "two ", "three ", "four ",
					"five ", "six ", "seven ", "eight ",
					"nine ", "ten ", "eleven ", "twelve ",
					"thirteen ", "fourteen ", "fifteen ",
					"sixteen ", "seventeen ", "eighteen ",
					"nineteen "};

	// strings at index 0 and 1 are not used, they is to make array indexing simple 
	static string[] ten = {"", "", "twenty ", "thirty ", "forty ",
					"fifty ", "sixty ", "seventy ", "eighty ",
					"ninety "};

	// n is 1- or 2-digit number 
	static string numToWords(int n, string s)
	{
		string str = "";

		// if n is more than 19, divide it 
		if (n > 19)
		{
			str += ten[n / 10] + one[n % 10];
		}
		else
		{
			str += one[n];
		}

		// if n is non-zero 
		if (n != 0)
		{
			str += s;
		}

		return str;
	}

	// Function to print a given number in words 
	static string convertToWords(long n)
	{
		// stores word representation of given number n 
		string out1 = "";
		// handles digits at ten millions and  hundred millions places (if any) 
		out1 += numToWords((int)(n / 10000000), "crore ");
		// handles digits at hundred thousands and one millions places (if any) 
		out1 += numToWords((int)((n / 100000) % 100), "lakh ");
		// handles digits at thousands and tens thousands places (if any) 
		out1 += numToWords((int)((n / 1000) % 100), "thousand ");
		// handles digit at hundreds places (if any) 
		out1 += numToWords((int)((n / 100) % 10), "hundred ");
		if (n > 100 && n % 100 > 0){out1 += "and ";}
		// handles digits at ones and tens places (if any) 
		out1 += numToWords((int)(n % 100), "");

		return out1;
	}

	static void Main()
	{
		Console.WriteLine("Please enter any number :");
		try
		{       // Read user input
			var UserInput = Console.ReadLine();
			// convert given number in words 
			Console.WriteLine(convertToWords(Convert.ToInt64(UserInput)));
		}
		catch (Exception e)
		{
			Console.WriteLine("Not a valid number");
		}
		Console.ReadLine();
	}
}



