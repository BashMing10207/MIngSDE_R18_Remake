using UnityEngine;
using UnityEngine.UI;

public class Location14_PlayerMobileMove : MonoBehaviour
{
	[Header("Интерфейс")]
	[SerializeField]
	private Image whiteScreenSmartphone;

	private float timeStep;

	[Header("Игрок")]
	[SerializeField]
	private Transform head;

	[SerializeField]
	private float speedPhysic;

	[SerializeField]
	private Audio_Data soundsStep;

	private bool destroySmooth;

	private bool lightActive;

	[Header("Дополнение игрока")]
	[SerializeField]
	private Light lightPlayer;

	private bool play;

	private int hMove;

	private int vMove;

	private Rigidbody rb;

	private float rotHead;

	private float rotBody;

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public void Play()
	{
	}

	public void Stop()
	{
	}

	public void DestroySmooth()
	{
	}

	public void LightActivation(bool x)
	{
	}
}
