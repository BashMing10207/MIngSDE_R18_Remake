using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Basement_SafeConsole : MonoBehaviour
{
	[SerializeField]
	private Transform cameraTranslate;

	[SerializeField]
	private Image screen;

	[SerializeField]
	private Basement_Safe objectOptions;

	[SerializeField]
	private GameObject[] deleteObjects;

	[SerializeField]
	private Animator safeAnimator;

	[SerializeField]
	private UnityEvent eventDeactivation;

	private Transform cameraT;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void TakeCartridge()
	{
	}

	public void DataMoshActive(bool x)
	{
	}

	[Button("Деактивировать", EButtonEnableMode.Always)]
	public void Deactivation()
	{
	}

	public void ExitGame()
	{
	}
}
