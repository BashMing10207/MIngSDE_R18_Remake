using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Colorful;
using UnityEngine;
using UnityEngine.UI;

public class PhotoModeMain : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CInterfaceReturn_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int frames;

		public PhotoModeMain _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003CInterfaceReturn_003Ed__34(int _003C_003E1__state)
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

	private GameController scrgc;

	private ConsoleCall scrcc;

	private RectTransform rect;

	private PlayerMove scrpm;

	[HideInInspector]
	public bool hideInterface;

	private ConsoleCameraFly scrccf;

	private float timeGame;

	private bool cursorVisible;

	private CursorLockMode cursorLockMode;

	[SerializeField]
	[Header("Настройки")]
	private MenuCaseOptionSwitch swithEffects;

	[SerializeField]
	private MenuCaseOptionSwitch toggleVignette;

	[SerializeField]
	private Slider sliderAngle;

	[SerializeField]
	private Slider sliderBright;

	[SerializeField]
	private Slider sliderContrast;

	[SerializeField]
	private Slider sliderSmooth;

	[SerializeField]
	private Slider sliderTime;

	[SerializeField]
	private Slider sliderFov;

	private BrightnessContrastGamma brightContrast;

	private FastVignette vignetteFast;

	private ComicBook comicBook;

	private VintageFast vintage;

	private LoFiPalette palette;

	private Noise noiseFast;

	[Header("Звуки")]
	[SerializeField]
	private AudioSource audioSource;

	[SerializeField]
	private AudioSource audioSourceClick;

	[SerializeField]
	private AudioClip soundScreenshot;

	public void StartComponent(GameController _scrgc)
	{
	}

	private void Update()
	{
	}

	public void UpdateCamera()
	{
	}

	public void HideInterface()
	{
	}

	public void OpenFolder()
	{
	}

	public void Screenshot()
	{
	}

	public void ExitPhotomode()
	{
	}

	public void ButtonResetFOV()
	{
	}

	[IteratorStateMachine(typeof(_003CInterfaceReturn_003Ed__34))]
	private IEnumerator InterfaceReturn(int frames)
	{
		return null;
	}
}
