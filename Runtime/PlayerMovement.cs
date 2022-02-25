using UnityEngine;

[AddComponentMenu ("DotPlay/")]
public class PlayerMovement : MonoBehaviour
{
	public enum Mode
	{
		Vector3, WASD, Platformer
	}

	void Start ()
	{
	}
	#region Platformer Variables
	[Range(3, 20)]
	[SerializeField]
	private float speed;

	[Range(1, 10)]
	[SerializeField]
	private float jumpHeight;
	#endregion
	#region WASD Variables
	[Range(3, 20)]
	[SerializeField]
	private float speed;

	[Range(1, 10)]
	[SerializeField]
	private float jumpHeight;
	#endregion
}