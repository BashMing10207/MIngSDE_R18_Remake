using UnityEngine;
using UnityEngine.UI;

public class TextComputerAuto : MonoBehaviour
{
	[SerializeField]
	private string[] stringsMethods;

	[SerializeField]
	private string[] stringMathf;

	[SerializeField]
	private string[] stringCode;

	[SerializeField]
	private string[] stringReady;

	private AudioSource audioSource;

	private int timeAudio;

	private Text txt;

	private float timePrint;

	private bool playPrint;

	private string textPrint;

	private float timeReady;

	private int timeRestart;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void RestartText()
	{
	}

	private void AudioPrint()
	{
	}
}
