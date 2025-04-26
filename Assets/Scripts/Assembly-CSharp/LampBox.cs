using UnityEngine;
using UnityEngine.Events;

public class LampBox : MonoBehaviour
{
	[SerializeField]
	public Vector3 size;

	[SerializeField]
	public Vector3 center;

	[SerializeField]
	public GameObject[] otherTargets;

	[Header("Звуки")]
	[SerializeField]
	public AudioSource audioBox;

	[SerializeField]
	public AudioClip soundOn;

	[SerializeField]
	public AudioClip soundOff;

	private GameObject player;

	private float timeOffNow;

	[Header("Настройки")]
	[SerializeField]
	public LayerMask layer;

	[SerializeField]
	public float timeOff;

	[SerializeField]
	public UnityEvent eventOn;

	[SerializeField]
	public UnityEvent eventOff;

	private int timeUpdate;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void CheckBox()
	{
	}
}
