using UnityEngine;

public class Time_ObjectOrderActive : MonoBehaviour
{
	public bool onStart;

	public GameObject[] objects;

	public float timeActiveOrder;

	[Header("MiSide")]
	public AudioSource audioFoot;

	public AudioClip[] soundsFoot;

	private int indexNextObject;

	private bool active;

	private float timeNext;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
