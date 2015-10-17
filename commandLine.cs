using System;

namespace DecisionMaking
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 0;
			
			int readLine = 1;
			Console.WriteLine("Number of command line parameters = {0}",args.Length);
			if (args.Length > 0) {
				foreach(string s in args) 
				{
				

					try
					{
						a = Convert.ToInt32(s);
						Console.WriteLine("{0} is a number",a);						
						readLine = 0;					
					}
					catch
					{
						try
						{
							string tmp;
							tmp = Convert.ToString(s);
							// Console.WriteLine("{0} is a string",s);							
							readLine = 0;						
						}
						catch
						{
							// Console.WriteLine("{0} is not a string",s);
						}
						
					}

				}
			}
			if (readLine == 1)
			{
				Console.Write("Enter a number:\t");
				a = Convert.ToInt32(Console.ReadLine());
			}
			if (a > 20) 
			{
				Console.WriteLine("The value of a is greater than 20");
			}
			else if (a == 20) 
			{
				Console.WriteLine("The value of a is equal to 20");
			}
			else if (a < 20) 
			{
				Console.WriteLine("The value of a is less than 20");
			} 
			else
			{
				Console.WriteLine("How do I compare a to 20?");
			}
			
		}
	}
}

