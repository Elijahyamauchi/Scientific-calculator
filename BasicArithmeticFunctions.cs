using System;

namespace CalculatorFunctions
{
	public class BasicArithmeticFunctions
	{
		public static double Addition(double a, double b)
		{
			return a + b;
		}

		public static double Subtraction(double a, double b)
		{
			return a - b;	
		}

		public static double Multiplication(double a, double b) { 
			return a * b;
		}

		public static double Division(double a, double b)
		{
			return b == 0 ? double.NaN : a / b;
		}
	}
}
