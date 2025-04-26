using UnityEngine;
using UnityEngine.Events;

public class Character_LookEvent : MonoBehaviour
{
	public Character_Look characterLook;

	public UnityEvent eventRotateBodyFinish;

	public UnityEvent eventRotateBodyHalfFinish;

	public float rotate;

	public Transform rotateTarget;

	public void Rotate()
	{
	}
}
