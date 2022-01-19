using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System;

namespace Dotplay
{
	class IntAgent
	{
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
	}
	class PlayerPrefsAgent
	{
		public static void SetBool (string id, bool boolian)
		{
			if (boolian)
			{
				PlayerPrefs.SetInt (id, 1);
			}
			else if (!boolian)
			{
				PlayerPrefs.SetInt (id, 0);
			}
		}
		public static bool? GetBool (string id)
		{
			if (PlayerPrefs.GetInt (id) == 1)
				return true;
			else if (PlayerPrefs.GetInt (id) == 0)
				return false;
			else
				return null;
		}
	}
	enum CurrencyChangeType
	{
		Add,
		Subtract,
		Set
	}
	class CurrencyAgent
	{
		public static void Currency (byte id, CurrencyChangeType currencyChangeType, int amout)
		{
			if (currencyChangeType == CurrencyChangeType.Add)
			{

			}
			else if (currencyChangeType == CurrencyChangeType.Subtract)
			{

			}
			else if (currencyChangeType == CurrencyChangeType.Set)
			{
				int[] nums = IntAgent.Split (amout);
			}

		}
	}
	class SceneAgent
	{
		public static void Load (string scene)
		{
			SceneManager.LoadSceneAsync (scene);
		}
		public static void Load (int buildIndex)
		{
			SceneManager.LoadSceneAsync (buildIndex);
		}
		public static void Load (string scene, bool loadSceneAddetive)
		{
			if (loadSceneAddetive)
				SceneManager.LoadSceneAsync (scene, LoadSceneMode.Additive);
			else
				SceneManager.LoadSceneAsync (scene);
		}
		public static void Load (int buildIndex, bool loadSceneAddetive)
		{
			if (loadSceneAddetive)
				SceneManager.LoadSceneAsync (buildIndex, LoadSceneMode.Additive);
			else
				SceneManager.LoadSceneAsync (buildIndex);
		}
		public virtual void Unload ()
		{
			SceneManager.UnloadSceneAsync (SceneManager.GetActiveScene ().name);
		}
		public virtual void Unload (int buildIndex)
		{
			SceneManager.UnloadSceneAsync (buildIndex);
		}
		public virtual void Unload (string name)
		{
			SceneManager.UnloadSceneAsync (name);
		}
	}
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


}