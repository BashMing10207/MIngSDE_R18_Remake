using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Basement_Safe : MonoBehaviour
{
	[SerializeField]
	private bool active;

	[Header("Интерфейс сейфа")]
	[SerializeField]
	private Text textNumbers;

	[SerializeField]
	[Header("Звуки")]
	private AudioSource audioInterface;

	[SerializeField]
	private AudioClip soundClick;

	[SerializeField]
	private AudioClip soundRight;

	[SerializeField]
	private AudioClip soundBackspace;

	[SerializeField]
	private AudioClip soundTimeOff;

	[SerializeField]
	private AudioClip soundNope;

	[SerializeField]
	private AudioClip soundLock;

	[Header("События")]
	[SerializeField]
	private UnityEvent eventRight;

	[SerializeField]
	private GameObject[] buttons;

	[SerializeField]
	private GameObject interactivePlace;

	private string passwordNow;

	private float timeResetPassword;

	private int countNope;

	private float timeNope;

	private int countTry;

	private void Update()
	{
	}

	private void PasswordOff()
	{
	}

	public void ClickButton(int x)
	{
	}

	private void RightPassword()
	{
	}

	public void Deactivation()
	{
	}

	public void Activation(bool x)
	{
	}
}
