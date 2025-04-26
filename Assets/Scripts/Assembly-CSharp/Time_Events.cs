using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

[AddComponentMenu("Functions/Time/Time event")]
public class Time_Events : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003COneYieldStart_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Time_Events _003C_003E4__this;

		public int num;

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
		public _003COneYieldStart_003Ed__11(int _003C_003E1__state)
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

	public bool StartYield;

	public bool destroyAfter;

	public TimePoint[] EventsOnTime;

	public UnityEvent eventStart;

	[HideInInspector]
	public bool eventStartReady;

	private int i;

	private int StartNumYield;

	private bool enableStart;

	private bool nextFrame;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003COneYieldStart_003Ed__11))]
	private IEnumerator OneYieldStart(int num)
	{
		return null;
	}

	public void YieldRestartFrame()
	{
	}

	public void YieldRestart()
	{
	}

	public void YieldRestartFull()
	{
	}

	public void YieldOne(int num)
	{
	}

	public void YieldOneLoadAwake(int num)
	{
	}

	public void StopAllTime()
	{
	}

	public void StopAndAllRestart()
	{
	}

	public void DestroyObjectMe()
	{
	}
}
