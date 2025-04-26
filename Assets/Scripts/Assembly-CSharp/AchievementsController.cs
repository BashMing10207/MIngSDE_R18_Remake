using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AchievementsController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCheckAchievementsSteam_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AchievementsController _003C_003E4__this;

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
		public _003CCheckAchievementsSteam_003Ed__7(int _003C_003E1__state)
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

	public DataAchievementsValues[] dataAchievements;

	private float timeLastAchievement;

	private void Update()
	{
	}

	public void StartComponent()
	{
	}

	public string ProgressAchievementString()
	{
		return null;
	}

	public void AchievementCompleted(string _nameAchievement)
	{
	}

	public void ClearAllAchievements()
	{
	}

	[IteratorStateMachine(typeof(_003CCheckAchievementsSteam_003Ed__7))]
	private IEnumerator CheckAchievementsSteam()
	{
		return null;
	}
}
