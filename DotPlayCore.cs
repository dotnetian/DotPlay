using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System;

namespace DotPlay
{
	#region MathAgent
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

	#endregion
	#region PlayerPrefsAgent
	/// <summary>
	/// PlayerPrefsAgent gives you ability of
	/// storing Boolean, Vector3 &... other kinds of data
	/// </summary>
	class PlayerPrefsAgent
	{
		#region Boolians
		/// <summary>
		/// Stores bool in PlayerPrefs as an integer
		/// Sets 1 or 0
		/// </summary>
		/// <param name="id"></param>
		/// <param name="boolean"></param>
		public static void SetBool (string id, bool boolean)
		{
			if (boolean)
			{
				PlayerPrefs.SetInt (id, 1);
			}
			else
			{
				PlayerPrefs.SetInt (id, 0);
			}
		}

		/// <summary>
		/// Returns bool set before by id
		/// </summary>
		/// <param name="id"></param>
		public static bool GetBool (string id)
		{
			if (PlayerPrefs.GetInt (id) == 1)
				return true;
			else if (PlayerPrefs.GetInt (id) == 0)
				return false;
			else
				return false;
		}
		#endregion
		#region Vector2
		/// <summary>
		/// Stores Vector2 by setting 2 floats
		/// </summary>
		/// <param name="id"></param>
		/// <param name="v2"></param>
		public static void SetVector2 (string id, Vector2 v2)
		{
			PlayerPrefs.SetFloat ($"{id}x", v2.x);
			PlayerPrefs.SetFloat ($"{id}y", v2.y);
		}

		/// <summary>
		/// Returns a Vector2 by the Id
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public static Vector2 GetVector2 (string id)
		{
			float one = PlayerPrefs.GetFloat ($"{id}x");
			float two = PlayerPrefs.GetFloat ($"{id}y");

			return new Vector2 (one, two);
		}
		#endregion
		#region Vector3
		/// <summary>
		/// Stores Vector3 by setting 3 floats
		/// </summary>
		/// <param name="id"></param>
		/// <param name="v2"></param>
		public static void SetVector3 (string id, Vector3 v3)
		{
			PlayerPrefs.SetFloat ($"{id}x", v3.x);
			PlayerPrefs.SetFloat ($"{id}y", v3.y);
			PlayerPrefs.SetFloat ($"{id}z", v3.z);
		}

		/// <summary>
		/// Returns a Vector2 by the Id
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public static Vector3 GetVector3 (string id)
		{
			float one = PlayerPrefs.GetFloat ($"{id}x");
			float two = PlayerPrefs.GetFloat ($"{id}y");
			float three = PlayerPrefs.GetFloat ($"{id}z");

			return new Vector3 (one, two, three);
		}
		#endregion
		#region Transform
		/// <summary>
		/// Stores position, rotation & localScale of the Transform component
		/// </summary>
		/// <param name="id"></param>
		/// <param name="transform"></param>
		public static void SetTransform (string id, Transform transform)
		{
			SetVector3 ($"{id}.p", transform.position);
			SetVector3 ($"{id}.r", new Vector3 (transform.rotation.x, transform.rotation.y, transform.rotation.z));
			SetVector3 ($"{id}.s", transform.localScale);
		}

		/// <summary>
		/// Returns position, rotation & localScale by id as a transform
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public static Transform GetTransform (string id)
		{
			Vector3 p = GetVector3 ($"{id}.p");
			Vector3 r = GetVector3 ($"{id}.r");
			Vector3 s = GetVector3 ($"{id}.s");

			Transform myTransform = null;
			myTransform.position = p;
			myTransform.localEulerAngles = r;
			myTransform.localScale = s;

			return myTransform;
		}
		#endregion
	}

	#endregion
	#region CurrencyAgent
	/// <summary>
	/// Types that currencies can change
	/// </summary>
	enum CurrencyChangeType
	{
		Add,
		Subtract,
		Set
	}

	/// <summary>
	/// For game currencies encryption & to
	/// prevent modifying game
	/// </summary>
	class CurrencyAgent
	{
		/// <summary>
		/// The Encrypted string
		/// Contains letters, not numbers
		/// </summary>
		static string _encryptedToPlayerPrefs = string.Empty;

		/// <summary>
		/// The Decrypted string
		/// Contains numbers
		/// </summary>
		static string _encryptedFromPlayerPrefs = string.Empty;

		/// <summary>
		/// Changes the Id's value, encrypts it & stores it
		/// </summary>
		/// <param name="id"></param>
		/// <param name="currencyChangeType"></param>
		/// <param name="amount"></param>
		public static void SetCurrency (byte id, CurrencyChangeType currencyChangeType, int amount)
		{

			if (currencyChangeType == CurrencyChangeType.Add)
			{

			}
			else if (currencyChangeType == CurrencyChangeType.Subtract)
			{

			}
			else if (currencyChangeType == CurrencyChangeType.Set)
			{
				int[] nums = MathAgent.Split (amount);

				for (int i = 0; i < nums.Length; i++)
				{
					switch (nums[i])
					{
						case 0:
						_encryptedToPlayerPrefs += "a";
						break;

						case 1:
						_encryptedToPlayerPrefs += "b";
						break;

						case 2:
						_encryptedToPlayerPrefs += "c";
						break;

						case 3:
						_encryptedToPlayerPrefs += "d";
						break;

						case 4:
						_encryptedToPlayerPrefs += "e";
						break;

						case 5:
						_encryptedToPlayerPrefs += "f";
						break;

						case 6:
						_encryptedToPlayerPrefs += "g";
						break;

						case 7:
						_encryptedToPlayerPrefs += "h";
						break;

						case 8:
						_encryptedToPlayerPrefs += "i";
						break;

						case 9:
						_encryptedToPlayerPrefs += "j";
						break;
					}
				}
			}

			PlayerPrefs.SetString ($"{id}.currency", _encryptedToPlayerPrefs);
		}

		/// <summary>
		/// Decrypts & returns the Id's value
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public static int GetCurrency (byte id)
		{
			string s = PlayerPrefs.GetString($"{id}.currency");
			string[] sSplited = s.Split();

			for (int i = 0; i < sSplited.Length; i++)
			{
				switch (sSplited[i])
				{
					case "a":
					_encryptedFromPlayerPrefs += "0";
					break;

					case "b":
					_encryptedFromPlayerPrefs += "1";
					break;

					case "c":
					_encryptedFromPlayerPrefs += "2";
					break;

					case "d":
					_encryptedFromPlayerPrefs += "3";
					break;

					case "e":
					_encryptedFromPlayerPrefs += "4";
					break;

					case "f":
					_encryptedFromPlayerPrefs += "5";
					break;

					case "g":
					_encryptedFromPlayerPrefs += "6";
					break;

					case "h":
					_encryptedFromPlayerPrefs += "7";
					break;

					case "i":
					_encryptedFromPlayerPrefs += "8";
					break;

					case "j":
					_encryptedFromPlayerPrefs += "9";
					break;
				}
			}

			return int.Parse (_encryptedFromPlayerPrefs);
		}
	}
	#endregion
	#region SceneAgent
	/// <summary>
	/// Shortens & upgrades SceneManager methods
	/// Used to make codes cleaner & easier to understand
	/// </summary>
	class SceneAgent
	{
		#region Load
		/// <summary>
		/// Loads scene in single mode by scene name
		/// </summary>
		/// <param name="scene"></param>
		public static void Load (string scene)
		{
			SceneManager.LoadSceneAsync (scene);
		}

		/// <summary>
		/// Loads scene in single mode by scene buildIndex
		/// </summary>
		/// <param name="buildIndex"></param>
		public static void Load (int buildIndex)
		{
			SceneManager.LoadSceneAsync (buildIndex);
		}

		/// <summary>
		/// Loads scene by name
		/// can be additive
		/// </summary>
		/// <param name="scene"></param>
		/// <param name="loadSceneAdditive"></param>
		public static void Load (string scene, bool loadSceneAdditive)
		{
			if (loadSceneAdditive)
				SceneManager.LoadSceneAsync (scene, LoadSceneMode.Additive);
			else
				SceneManager.LoadSceneAsync (scene);
		}

		/// <summary>
		/// Loads scene by buildIndex
		/// can be additive
		/// </summary>
		/// <param name="buildIndex"></param>
		/// <param name="loadSceneAdditive"></param>
		public static void Load (int buildIndex, bool loadSceneAdditive)
		{
			if (loadSceneAdditive)
				SceneManager.LoadSceneAsync (buildIndex, LoadSceneMode.Additive);
			else
				SceneManager.LoadSceneAsync (buildIndex);
		}
		#endregion

		#region Unload
		/// <summary>
		/// Unloads the current active scene
		/// </summary>
		public static void Unload ()
		{
			SceneManager.UnloadSceneAsync (SceneManager.GetActiveScene ().name);
		}

		/// <summary>
		/// Unlaods scene by buildIndex
		/// </summary>
		/// <param name="buildIndex"></param>
		public static void Unload (int buildIndex)
		{
			SceneManager.UnloadSceneAsync (buildIndex);
		}

		/// <summary>
		/// Unloads scene by name
		/// </summary>
		/// <param name="name"></param>
		public static void Unload (string name)
		{
			SceneManager.UnloadSceneAsync (name);
		}
		#endregion
	}
	#endregion
	#region TimeAgent
	/// <summary>
	/// TimeAgent has methods for time scaling & 
	/// </summary>
	class TimeAgent
	{
		public static void ScaleTime (float timeScale)
		{
			Time.timeScale = timeScale;
		}
		public static void ScaleTime (float timeScale, AudioSource[] audioSources)
		{
			Time.timeScale = timeScale;

			if (audioSources != null)
			{
				for (int i = 0; i < audioSources.Length; i++)
				{
					audioSources[i].pitch = timeScale;
				}
			}
		}
		public static void ResetTime (AudioSource[] audioSources)
		{
			Time.timeScale = 1;

			if (audioSources != null)
			{
				for (int i = 0; i < audioSources.Length; i++)
				{
					audioSources[i].pitch = 1;
				}
			}
		}

	}
	#endregion
}