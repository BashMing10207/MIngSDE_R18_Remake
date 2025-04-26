using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Location11_GameLinesMain : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CTimeStopPlayer_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Location11_GameLinesMain _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CTimeStopPlayer_003Ed__44(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	[Header("События")]
	private UnityEvent eventStopLevel;

	private float timeNext;

	private Vector3 positionMouseFix;

	private Vector3 positionMouse;

	private bool play;

	private int level;

	private bool hold;

	private bool joinNow;

	private bool blockNow;

	private int pointLastTake;

	private bool useThis;

	private bool finish;

	[SerializeField]
	[Header("Игра")]
	private Location11_GameLinesMain_Level[] levelsGame;

	[SerializeField]
	private LineRenderer lineRenderer;

	[SerializeField]
	private GameObject prefabPoint;

	[SerializeField]
	private GameObject prefabLineBlock;

	[SerializeField]
	private Transform cameraTarget;

	[SerializeField]
	private BoxCollider mousePlaneBox;

	[SerializeField]
	private Axis axisGame;

	private List<Image> alphaCircles;

	private List<bool> pointsTake;

	private List<GameObject> linesBlock;

	private List<GameObject> points;

	[SerializeField]
	[Header("Интерфейс")]
	private Image backgroundBlink;

	[Header("Физика")]
	[SerializeField]
	private LayerMask layerMouse;

	private bool ikActive;

	private PlayerMove scrpm;

	private FullBodyBipedIK scrfbbik;

	[Header("Игрок")]
	[SerializeField]
	private Transform handTarget;

	[SerializeField]
	[Header("Звуки")]
	private AudioSource audioLine;

	[SerializeField]
	private AudioClip soundStartPoint;

	[SerializeField]
	private AudioClip soundTakePoint;

	[SerializeField]
	private AudioClip soundFinishPoint;

	[SerializeField]
	private AudioSource audioFinalNext;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void CreatePoints()
	{
	}

	private void ClearAll()
	{
	}

	public void StartGame()
	{
	}

	private void StopGame()
	{
	}

	public void ActivationIK(bool x)
	{
	}

	public void BackgroundScreenBlink()
	{
	}

	public void PlayerExitDistance()
	{
	}

	[IteratorStateMachine(typeof(_003CTimeStopPlayer_003Ed__44))]
	private IEnumerator TimeStopPlayer()
	{
		return null;
	}
}
