using System;
using RootMotion;
using UnityEngine;

public class ObjectClock : MonoBehaviour
{
	[SerializeField]
	private Transform pointerS;

	[SerializeField]
	private Transform pointerM;

	[SerializeField]
	private Transform pointerH;

	[SerializeField]
	private AudioClip[] soundsClock;

	[SerializeField]
	private float zRot;

	[SerializeField]
	private bool reverse;

	[SerializeField]
	private Axis axis;

	private AudioSource au;

	private DateTime timeNow;

	private float timeUpdate;

	private bool audioActive;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void AudioPlay()
	{
	}

	public void AudioActive(bool x)
	{
	}

	public void SetTime(float _time)
	{
	}
}
