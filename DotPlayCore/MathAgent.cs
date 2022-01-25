using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System;

namespace DotPlay
{
	/// <summary>
	/// MathAgent class, contains methods & tools for mathematical operations
	/// </summary>
	class MathAgent
	{
		/// <summary>
		/// Split method, splits integers like string.Split()
		/// </summary>
		/// <param name="number"></param>
		public static int[] Split (int number)
		{
			string s = number.ToString ();
			int a = int.Parse(s);
			a = Math.Abs (a);
			int length = a.ToString().Length;
			int[] myArray = new int[length];

			for (int i = 0; i < length; i++)
			{
				myArray[i] = a % 10;
				a /= 10;
			}

			Array.Reverse (myArray);

			return myArray;
		}

		/// <summary>
		/// Returns n sentence of Fibonacci
		/// </summary>
		/// <param name="n"></param>
		public static ulong Fibonacci (ulong n)
		{
			ulong firstnumber = 0, secondnumber = 1, result = 0;
			if (n == 0)
				return 0; //It will return the first number of the series
			if (n == 1)
				return 1; // it will return  the second number of the series
			for (ulong i = 2; i <= n; i++)  // main processing starts from here
			{
				result = firstnumber + secondnumber;
				firstnumber = secondnumber;
				secondnumber = result;
			}
			return result;
		}

	}
}