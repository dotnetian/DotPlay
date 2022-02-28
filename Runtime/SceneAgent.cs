using UnityEngine.SceneManagement;

namespace DotPlay
{
	/// <summary>
	/// Shortens & upgrades SceneManager methods
	/// Used to make codes cleaner & easier to understand
	/// </summary>
	public class SceneAgent
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
		#region Reload
		/// <summary>
		/// Reloads the current active scene
		/// </summary>
		public static void Reload ()
		{
			Load (SceneManager.GetActiveScene ().name);
		}
		#endregion
	}
}