using UnityEngine;

namespace DotPlay
{
	/// <summary>
	/// TimeAgent has methods for time scaling
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
}