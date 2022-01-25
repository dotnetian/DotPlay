using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System;

namespace DotPlay
{
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
	}
}