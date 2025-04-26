using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coffee.UIEffects;
using UnityEngine;

public class SceneLoading : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CTimeStart_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float _time;

		public SceneLoading _003C_003E4__this;

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
		public _003CTimeStart_003Ed__21(int _003C_003E1__state)
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

	private AsyncOperation asyncLoad;

	[SerializeField]
	private RectTransform lineLoad;

	[SerializeField]
	private SceneLoading_Preloading preloading;

	[SerializeField]
	private Localization_UIText localizationLoading;

	[SerializeField]
	private Localization_UIText localizationWarning;

	private float timeJokeReady;

	private int jokeLoading;

	[SerializeField]
	[Header("Шутка")]
	private int[] jokeStrings;

	[SerializeField]
	[Header("Первый запуск")]
	private ChangeLanguageStart changeLanguageStart;

	[SerializeField]
	private GameObject objectInterfaceLoading;

	[Header("Интерфейс")]
	[SerializeField]
	private UIGradient gradientBackground;

	[SerializeField]
	private UIGradient gradientThings;

	[SerializeField]
	private Localization_UIText textLoading;

	private bool go;

	private bool sceneAcyncGo;

	private string levelLoadName;

	private bool loadReady;

	private bool firstStartGame;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LoadGo()
	{
	}

	[IteratorStateMachine(typeof(_003CTimeStart_003Ed__21))]
	private IEnumerator TimeStart(float _time)
	{
		return null;
	}

	public void StopLoad()
	{
	}

	public void LanguageApply()
	{
	}
}
