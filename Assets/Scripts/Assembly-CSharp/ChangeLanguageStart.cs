using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class ChangeLanguageStart : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CLoadVoice_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string _languageVoice;

		public ChangeLanguageStart _003C_003E4__this;

		public int _index;

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
		public _003CLoadVoice_003Ed__21(int _003C_003E1__state)
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
	private SceneLoading main;

	private List<GameObject> caseLangauge;

	private string[] languages;

	[SerializeField]
	[Header("Язык")]
	private GameObject prefabButtonLanguage;

	[SerializeField]
	private List<ChangeLanguageStartText> textes;

	private List<GameObject> caseVoice;

	private List<AudioClip> audioVoiceHello;

	private string[] voices;

	[SerializeField]
	[Header("Озвучка")]
	private GameObject prefabButtonVoice;

	[Header("Звуки")]
	[SerializeField]
	private AudioSource audioClick;

	[SerializeField]
	private AudioSource audioEnter;

	[SerializeField]
	private AudioSource audioVoice;

	[SerializeField]
	private AudioClip soundMorz;

	[Header("От сообщества")]
	[SerializeField]
	private Text textComLanguage;

	[SerializeField]
	private Text textComLanguageVoice;

	public void StartComponent()
	{
	}

	public void ChangeLanguage(int _index)
	{
	}

	public void ChangeVoice(int _index, bool _click)
	{
	}

	public void Apply()
	{
	}

	public void AudioClick()
	{
	}

	public void AudioEnter()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadVoice_003Ed__21))]
	private IEnumerator LoadVoice(int _index, string _languageVoice)
	{
		return null;
	}
}
