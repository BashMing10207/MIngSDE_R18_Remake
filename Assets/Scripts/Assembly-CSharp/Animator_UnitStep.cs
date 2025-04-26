using UnityEngine;

public class Animator_UnitStep : MonoBehaviour
{
	public AudioSource audioAddone;

	public AudioSource audioStep;

	public AudioClip[] soundsStep;

	public string nameFloatMove;

	[Header("Дополнение")]
	public bool middleAudio;

	public Transform footRight;

	public Transform footLeft;

	[SerializeField]
	private bool particleUse;

	private int lastSound;

	private Animator anim;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Step()
	{
	}

	public void StepMove()
	{
	}

	private int FixRandomSound()
	{
		return 0;
	}
}
