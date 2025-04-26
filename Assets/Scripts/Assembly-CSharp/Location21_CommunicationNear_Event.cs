using System;
using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class Location21_CommunicationNear_Event
{
	[HideInInspector]
	public float timeWork;

	[HideInInspector]
	public bool work;

	public bool oneTime;

	public float timeStart;

	public float timeRandomAdd;

	[Range(0f, 100f)]
	public float chanceWork;

	public UnityEvent eventInvoke;

	[Header("Анимация Мита и игрока")]
	[Range(0f, 1f)]
	public float dotMitaPlayer;

	public Transform animationPlayer;

	public Transform animationMita;

	public float distancePositionMita;
}
