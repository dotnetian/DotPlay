using UnityEditor;
using UnityEngine;
using DotPlay;

[AddComponentMenu("DotPlay/Player Movement")]
public class PlayerMovementAgent : MonoBehaviour
{
	public enum Mode
	{
		Vector3, WASD, Platformer
	}

	CurrencyChangeType currency;
	void Start()
	{
		currency = CurrencyChangeType.Add;
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
	private float _speed;

	[Range(1, 10)]
	[SerializeField]
	private float _jumpHeight;
	#endregion
}