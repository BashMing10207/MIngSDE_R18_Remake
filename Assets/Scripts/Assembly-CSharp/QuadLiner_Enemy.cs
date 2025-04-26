using UnityEngine;
using UnityEngine.UI;

public class QuadLiner_Enemy : MonoBehaviour
{
	private RectTransform rect;

	private float timeStart;

	private bool fall;

	private float timeFall;

	private RectTransform player;

	private QuadLinerMain main;

	private bool stop;

	private Image img;

	[HideInInspector]
	public bool shield;

	private bool lose;

	private float timeLose;

	private AnimationCurve animationLose;

	private bool skipLose;

	[HideInInspector]
	public bool destroyPlayer;

	public void StartComponent(QuadLinerMain _main, float _timeStart, RectTransform _player, bool _shield)
	{
	}

	private void Update()
	{
	}

	public void Fall()
	{
	}

	public void Stop()
	{
	}

	public void Shoot()
	{
	}
}
