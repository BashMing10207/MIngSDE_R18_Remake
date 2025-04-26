using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NaughtyAttributes;
using UnityEngine;

public class FunctionsGame_DialogueAnimationFinish : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPlayPoint_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FunctionsGame_DialogueAnimationFinish _003C_003E4__this;

		public int x;

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
		public _003CPlayPoint_003Ed__7(int _003C_003E1__state)
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

	private int index;

	[SerializeField]
	private TimePointInt[] points;

	[SerializeField]
	[Label("Диалог")]
	[Header("Информация")]
	[Space(30f)]
	private bool dialogueF;

	[SerializeField]
	[Label("Анимация")]
	private bool animationF;

	public void AnimationFinish()
	{
	}

	public void DialogueFinish()
	{
	}

	private void FinishCheck()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayPoint_003Ed__7))]
	private IEnumerator PlayPoint(int x)
	{
		return null;
	}
}
