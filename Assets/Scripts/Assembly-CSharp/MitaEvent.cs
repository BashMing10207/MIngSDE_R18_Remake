using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.Events;

public class MitaEvent : MonoBehaviour
{
	public enum TypeAnimationIK
	{
		none = 0,
		offOn = 1,
		onOff = 2,
		off = 3,
		on = 4
	}

	public enum TypeMagnetMita
	{
		none = 0,
		on = 1,
		onOff = 2
	}

	[CompilerGenerated]
	private sealed class _003CPlayTimeAnimation_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MitaEvent _003C_003E4__this;

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
		public _003CPlayTimeAnimation_003Ed__16(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CPlayTimeAnimationAfterEvent_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MitaEvent _003C_003E4__this;

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
		public _003CPlayTimeAnimationAfterEvent_003Ed__17(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CPlayTimeTimer_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MitaEvent _003C_003E4__this;

		public TimePointInt _timePoint;

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
		public _003CPlayTimeTimer_003Ed__18(int _003C_003E1__state)
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
	private Animator_FunctionsOverride mitaAnimator;

	[SerializeField]
	private AnimationClip animationStart;

	[SerializeField]
	private AnimationClip animationFinish;

	[SerializeField]
	private UnityEvent eventStart;

	[SerializeField]
	private UnityEvent eventFinish;

	[SerializeField]
	private UnityEvent eventAfterFinish;

	[SerializeField]
	private List<UnityEvent> eventsMitaAnimation;

	[Header("Дополнительно")]
	[SerializeField]
	private TypeMagnetMita magnetTarget;

	[SerializeField]
	private TypeAnimationIK animationIK;

	public List<TimePointInt> timePoints;

	private bool instant;

	private MitaPerson scrmp;

	[Button("Запустить", EButtonEnableMode.Always)]
	public void Play()
	{
	}

	public void InstantPlay()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayTimeAnimation_003Ed__16))]
	private IEnumerator PlayTimeAnimation()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPlayTimeAnimationAfterEvent_003Ed__17))]
	private IEnumerator PlayTimeAnimationAfterEvent()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPlayTimeTimer_003Ed__18))]
	private IEnumerator PlayTimeTimer(TimePointInt _timePoint)
	{
		return null;
	}

	public void StopAllTime()
	{
	}
}
