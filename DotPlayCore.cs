using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

namespace Dotplay
{
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
		public static void Unload ()
		{
			SceneManager.UnloadSceneAsync (SceneManager.GetActiveScene ().name);
		}
		public static void Unload (int buildIndex)
		{
			SceneManager.UnloadSceneAsync (buildIndex);
		}
		public static void Unload (string name)
		{
			SceneManager.UnloadSceneAsync (name);
		}
	}

	class TimeAgent : MonoBehaviour
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