using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UI_TextPrint : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CTimeEvent_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UI_TextPrint _003C_003E4__this;

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
		public _003CTimeEvent_003Ed__21(int _003C_003E1__state)
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

	private Text txt;

	private string txtNeed;

	private float timePrint;

	private bool printNow;

	[Header("Настройки")]
	[SerializeField]
	private bool onStart;

	[SerializeField]
	private float speedPrint;

	[SerializeField]
	private AudioSource audioPrint;

	[SerializeField]
	private bool ignoryAudioPlaying;

	[Space(30f)]
	[SerializeField]
	private string startString;

	[SerializeField]
	private string finishString;

	[Space(30f)]
	[SerializeField]
	private float timeEventFinish;

	[SerializeField]
	private UnityEvent eventPrintFinish;

	private bool fs;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Print()
	{
	}

	public void PrintString(string _string)
	{
	}

	public void PrintStringTranslate()
	{
	}

	public void PrintStringTranslate(int _renumberString)
	{
	}

	private void PrintFinish()
	{
	}

	public void PrintClearString(string _string)
	{
	}

	[IteratorStateMachine(typeof(_003CTimeEvent_003Ed__21))]
	private IEnumerator TimeEvent()
	{
		return null;
	}
}
