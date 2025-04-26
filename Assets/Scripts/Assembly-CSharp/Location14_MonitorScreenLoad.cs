using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Location14_MonitorScreenLoad : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CScreenload_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Location14_MonitorScreenLoad _003C_003E4__this;

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
		public _003CScreenload_003Ed__18(int _003C_003E1__state)
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

	private bool screensReady;

	private float timeScreenBlack;

	[SerializeField]
	private Image screenImage;

	[SerializeField]
	private Sprite spritePlayerOne;

	[SerializeField]
	private Sprite spritePlayerMita;

	[SerializeField]
	private Sprite spritePlayerSit;

	[SerializeField]
	private Sprite spritePlayerSpeakMita;

	[SerializeField]
	private Camera cameraRender;

	[SerializeField]
	private RenderTexture rendererCamera;

	private int indexLoad;

	private float timeLoad;

	private float timeScreen;

	[SerializeField]
	[Header("Заготовка")]
	private UnityEvent eventPlayerOne;

	[SerializeField]
	private UnityEvent eventPlayerMita;

	[SerializeField]
	private UnityEvent eventPlayerSit;

	[SerializeField]
	private UnityEvent eventPlayerSpeakMita;

	[SerializeField]
	private UnityEvent eventLoadReady;

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CScreenload_003Ed__18))]
	private IEnumerator Screenload()
	{
		return null;
	}

	public void LoadScreenPlayerOne()
	{
	}

	public void LoadScreenPlayerMita()
	{
	}

	public void LoadScreenPlayerSpeakMita()
	{
	}

	public void LoadScreenPlayerSit()
	{
	}

	public void HideScreen()
	{
	}
}
