using UnityEngine;

public class TamagotchiGame_Cartridge_Cartridge : MonoBehaviour
{
	[SerializeField]
	private TamagotchiGame_Cartridge main;

	private int countBolt;

	[Header("Детали")]
	[SerializeField]
	private GameObject bolt1;

	[SerializeField]
	private GameObject bolt2;

	[SerializeField]
	private GameObject bolt3;

	[SerializeField]
	private GameObject bolt4;

	[SerializeField]
	private GameObject up;

	[SerializeField]
	private GameObject down;

	[SerializeField]
	private GameObject plan;

	private bool clear;

	private float timeAnimation;

	private GameObject nextDetailOpen;

	private float timeAnimationReady;

	[Header("Анимация")]
	[SerializeField]
	private AnimationCurve curveUp;

	[SerializeField]
	private TamagotchiGame_CartridgeDetails[] details;

	[SerializeField]
	private Transform pointerHint;

	[SerializeField]
	private AnimationCurve animationPointerHint;

	private float timeAnimationPointer;

	private bool fall;

	private bool soundTrash;

	[Header("Звуки")]
	[SerializeField]
	private AudioClip[] soundsFall;

	private void Update()
	{
	}

	public void PutBolt()
	{
	}

	public void PutUp()
	{
	}

	public void PutPlan()
	{
	}

	public void Restart()
	{
	}

	public void Take()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}
}
