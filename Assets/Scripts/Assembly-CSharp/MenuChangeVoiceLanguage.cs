using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

public class MenuChangeVoiceLanguage : MonoBehaviour
{
	[Serializable]
	private class VoiceHello
	{
		public AudioClip sound;

		public string language;
	}

	[CompilerGenerated]
	private sealed class _003CLoadVoice_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string _languageVoice;

		public MenuChangeVoiceLanguage _003C_003E4__this;

		private UnityWebRequest _003Cwww_003E5__2;

		private bool _003C_error_003E5__3;

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
		public _003CLoadVoice_003Ed__5(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	private List<VoiceHello> soundVoices;

	[SerializeField]
	private AudioClip soundNotVoice;

	private AudioSource audioSource;

	private void Start()
	{
	}

	public void PlayVoice()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadVoice_003Ed__5))]
	private IEnumerator LoadVoice(string _languageVoice)
	{
		return null;
	}
}
