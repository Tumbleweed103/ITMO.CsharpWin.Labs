using System.Reflection;

namespace Calculator
{

	using System;

	public class CalcEngine
	{
		//
		// Operation Constants.
		//
		public enum Operator:int
		{
			eUnknown = 0,
			eAdd = 1,
			eSubtract = 2,
			eMultiply = 3,
			eDivide = 4,
			ePower = 5,
		}

		//
		// Module-Level Constants
		//

		private static double negativeConverter = -1;
		// TODO: Upgrade the version number to 3.0.1.1
		private static string versionInfo = "Calculator v2.0.1.1";

		//
		// Module-level Variables.
		//
	
		private static double numericAnswer;
		private static string stringAnswer;
		private static Operator calcOperation;
		private static double firstNumber;
		private static double secondNumber;
		private static bool secondNumberAdded;
		private static bool decimalAdded;
 
		//
		// Class Constructor.
		//

		public CalcEngine()
		{
			decimalAdded = false;
			secondNumberAdded = false;
		}

		//
		// Returns the custom version string to the caller.
		//

		public static string GetVersion()
		{
			return (versionInfo);
		}
		//
		// Called when the Date key is pressed.
		//

		public static string GetDate()
		{
			DateTime curDate = new DateTime();
			curDate = DateTime.Now;

			stringAnswer = String.Concat(curDate.ToShortDateString(), " ", curDate.ToLongTimeString());

			return (stringAnswer);
		}

		//
		// Called when a number key is pressed on the keypad.
		//

		public static string CalcNumber(string KeyNumber)
		{
			stringAnswer = stringAnswer + KeyNumber;
			return (stringAnswer);
		}

		//
		// Called when an operator is selected (+, -, *, /)
		//

		public static void CalcOperation(Operator calcOper)
		{
			if (stringAnswer != "" && !secondNumberAdded)
			{
				firstNumber = System.Convert.ToDouble(stringAnswer);
				calcOperation = calcOper;
				stringAnswer = "";
				decimalAdded = false;
			}			
		}

		//
		// Called when the +/- key is pressed.
		//

		public static string CalcSign()
		{
			double numHold;

			if (stringAnswer != "")
			{
				numHold = System.Convert.ToDouble(stringAnswer);
				stringAnswer = System.Convert.ToString(numHold * negativeConverter);
			}
		
			return (stringAnswer);
		}

		//
		// Called when the 1/x key is pressed.
		//

		public static string CalcInverse()
        {
			double numHold;

			if (stringAnswer != "")
            {
				numHold = System.Convert.ToDouble(stringAnswer);
				stringAnswer = Convert.ToString(1 / numHold);
			}

			return (stringAnswer);
		}

		//
		// Called when the !x key is pressed.
		//

		public static string CalcFactorial()
		{
			int numHold;
			long factorial = 1;

			if (stringAnswer != "")
			{
				if (!decimalAdded)
                {
					numHold = Convert.ToInt32(stringAnswer);
					if (numHold >= 0)
                    {
						for (int i = 1; i <= numHold; i++)
						{
							factorial *= i;
						}
						stringAnswer = Convert.ToString(factorial);
					}
                    else
                    {
						stringAnswer = "Enter a positive number";
					}
				}
                else
				{
					stringAnswer = "Enter an integer";
				}
			}

			return (stringAnswer);
		}

		//
		// Called when the square(x) key is pressed.
		//

		public static string CalcSquare()
		{
			double numHold;
			double square;

			if (stringAnswer != "")
            {
				try
				{
					numHold = System.Convert.ToDouble(stringAnswer);
					square = Math.Sqrt(numHold);
					if (double.IsNaN(square))
					{
						throw new Exception();
					}
					else
					{
						stringAnswer = Convert.ToString(square);
					}
				}
				catch (Exception)
				{
					stringAnswer = "Enter a positive number";
				}
			}


			return (stringAnswer);
		}

		//
		// Called when the Cbrt(x) key is pressed.
		//

		public static string CalcCube()
		{
			double numHold;
			double cube;

			if (stringAnswer != "")
			{
				numHold = System.Convert.ToDouble(stringAnswer);
				if (numHold >= 0)
				{
					cube = Math.Pow(numHold, (1.0 / 3.0));
				}
                else
                {
					cube = -Math.Pow(-numHold, (1.0 / 3.0));
				}
				stringAnswer = Convert.ToString(cube);
			}


			return (stringAnswer);
		}

		//
		// Called when the x^2 key is pressed.
		//

		public static string CalcPowerTwo()
		{
			double numHold;

			if (stringAnswer != "")
			{
				numHold = System.Convert.ToDouble(stringAnswer);
				stringAnswer = Convert.ToString(Math.Pow(numHold, 2));
			}

			return (stringAnswer);
		}

		//
		// Called when the . key is pressed.
		//

		public static string CalcDecimal()
		{
			if (!decimalAdded && !secondNumberAdded)
			{
				if (stringAnswer != "")
					stringAnswer = stringAnswer + ".";
				else
					stringAnswer = "0.";

				decimalAdded = true;
			}

			return (stringAnswer);
		}

		//
		// Called when = is pressed.
		//

		public static string CalcEqual()
		{
			bool validEquation = false;

			if (stringAnswer != "")
			{
				secondNumber = System.Convert.ToDouble(stringAnswer);
				secondNumberAdded = true;

				switch (calcOperation)
				{
					case Operator.eUnknown:
						validEquation = false;
						break;

					case Operator.eAdd:
						numericAnswer = firstNumber + secondNumber;
						validEquation = true;
						break;

					case Operator.eSubtract:
						numericAnswer = firstNumber - secondNumber;
						validEquation = true;
						break;

					case Operator.eMultiply:
						numericAnswer = firstNumber * secondNumber;
						validEquation = true;
						break;

					case Operator.eDivide:
						numericAnswer = firstNumber / secondNumber;
						validEquation = true;
						break;

					case Operator.ePower:
						numericAnswer = Math.Pow(firstNumber, secondNumber);
						validEquation = true;
						break;

					default:
						validEquation = false;
						break;
				}

				if (validEquation)
					stringAnswer = System.Convert.ToString(numericAnswer);
			}
			
			return (stringAnswer);
		}

		//
		// Calculate the roots of a quadratic equation.
		//

		public static int CalcQuadEquationRoots(int a, int b, int c, out double root1, out double root2)
		{

			int discriminant = b * b - 4 * a * c;

			if (discriminant < 0)
			{
				root1 = root2 = 0;
				return -1;
			}
			if (discriminant == 0)
			{
				root1 = root2 = (double)(b / 2 * a * -1);
				return 0;
			}
			else
			{
				root1 = (double)((-1 * b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a));
				root2 = (double)((-1 * b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a));
				return 1;
			}
		}
		//
		// Resets the various module-level variables for the next calculation.
		//

		public static void CalcReset()
		{
			numericAnswer = 0;
			firstNumber = 0;
			secondNumber = 0;
			stringAnswer = "";
			calcOperation = Operator.eUnknown;
			decimalAdded = false;
			secondNumberAdded = false;			
		}
	}
}