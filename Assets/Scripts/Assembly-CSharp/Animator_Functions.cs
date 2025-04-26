using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class Animator_Functions : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CNextFrameState_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Animator_Functions _003C_003E4__this;

		public string _nameState;

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
		public _003CNextFrameState_003Ed__12(int _003C_003E1__state)
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

	public UnityEvent[] _events;

	public void BoolOn(string x)
	{
	}

	public void BoolOff(string x)
	{
	}

	public void TriggerClick(string x)
	{
	}

	public void BoolSwitch(string x)
	{
	}

	public void EventKey(int x)
	{
	}

	public void AnimationFinish()
	{
	}

	public void AnimatorRuntime(RuntimeAnimatorController _animatorRuntime)
	{
	}

	public void AnimatorFinish()
	{
	}

	public void AnimationPlayState(string _nameState)
	{
	}

	public void AnimationPlayStateEnd(string _nameState)
	{
	}

	public void AnimationPlayStateFrame(string _nameState)
	{
	}

	[IteratorStateMachine(typeof(_003CNextFrameState_003Ed__12))]
	private IEnumerator NextFrameState(string _nameState)
	{
		return null;
	}
}
