using UnityEngine;

namespace DotPlay
{
	/// <summary>
	/// GetAgent is used to simplify Unity get gameobjects & components' methods.
	/// Recommended to add this at the top of your code to shorten method calls.
	/// using static DotPlay.GetAgent;
	/// </summary>
	public class GetAgent
	{
		/// <summary>
		/// Gets a component from the specified <see cref="MonoBehaviour"/>'s owner GameObject
		/// </summary>
		/// <typeparam name="T">The type to be get</typeparam>
		/// <param name="from">The <see cref="MonoBehaviour"/> to get the type form</param>
		/// <returns>The instance of type if available, & null if not</returns>
		public static T Get<T> (MonoBehaviour from)
		{
			T t = from.GetComponent<T> ();

			return t;
		}

		/// <summary>
		/// Gets a component from the specified GameObject
		/// </summary>
		/// <typeparam name="T">The type to be get</typeparam>
		/// <param name="from">The <see cref="GameObject"/> to get the type form</param>
		/// <returns>The instance of type if available, & null if not</returns>
		public static T Get<T> (GameObject from)
		{
			T t = from.GetComponent<T> ();

			return t;
		}

		/// <summary>
		/// Finds a type within <see cref="GameObject"/>s in the scene
		/// </summary>
		/// <typeparam name="T">The type of <see cref="GameObject"/> to be looked for</typeparam>
		/// <returns>The instance of type if available, & null if not</returns>
		public static T Get<T> () where T : Component
		{
			return Object.FindObjectOfType<T> ();
		}

		/// <summary>
		/// Finds a type within <see cref="GameObject"/>s in the scene
		/// </summary>
		/// <typeparam name="T">The type of <see cref="GameObject"/> to be looked for</typeparam>
		/// <param name="getGameObject"></param>
		/// <returns>The <see cref="GameObject"/> that is found</returns>
		public static GameObject Get<T> (bool getGameObject) where T : Component
		{
			return Object.FindObjectOfType<T> ().gameObject;
		}

		/// <summary>
		/// Finds the <see cref="GameObject"/> by name/hierarchy
		/// </summary>
		/// <param name="name">The name/hierarchy of <see cref="GameObject"/></param>
		/// <returns>The <see cref="GameObject"/> found</returns>
		public static GameObject Get (string name)
		{
			return GameObject.Find (name);
		}
	}
}
