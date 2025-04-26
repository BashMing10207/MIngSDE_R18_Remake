using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;

public class World : MonoBehaviour
{
	[Serializable]
	public class LevelLoad
	{
		public UnityEvent eventLoad;

		public Vector3 positionPlayer;

		public float rotationPlayer;

		public float timeScreenLoading;
	}

	[CompilerGenerated]
	private sealed class _003CLoadVoiceFile_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public World _003C_003E4__this;

		public string path;

		private int _003C_intFileLoad_003E5__2;

		private UnityWebRequest _003Cwww_003E5__3;

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
		public _003CLoadVoiceFile_003Ed__41(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CLoadVoiceFileNow_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string path;

		public World _003C_003E4__this;

		public int indexVoice;

		public Dialogue_3DText _dialogueVoice;

		public Audio_loadReady _voiceLoader;

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
		public _003CLoadVoiceFileNow_003Ed__42(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CLoadLevelFrame_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public World _003C_003E4__this;

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
		public _003CLoadLevelFrame_003Ed__48(int _003C_003E1__state)
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

	public GameObject[] tagObjects;

	[Header("Для перевода")]
	[Tooltip("Название файла, с которого берется текст.")]
	public string nameLocation;

	[HideInInspector]
	public List<LanguageFilesTexture> languageTexture;

	[HideInInspector]
	public bool texturesLoad;

	private PlayerMove scrpm;

	[Header("Игрок")]
	public Vector3 positionSpawn;

	public Vector2 rotationSpawn;

	public float limitFloor;

	public bool evilMenu;

	public bool playerMenu;

	[Header("Подсказки")]
	public bool showHint;

	public int indexHint;

	public Vector2[] positionsHintScreen;

	private int indexPosHintScreen;

	[Header("Удаление лишнего")]
	public GameObject[] destroyObjects;

	public Collider[] destroyColliders;

	public GameObject[] deactiveObjects;

	[Header("Старт мира")]
	public UnityEvent eventStart;

	public UnityEvent eventContinueScene;

	public UnityEvent eventFirstStart;

	public LevelLoad[] levelLoad;

	public Playable_Animation cutsceneStart;

	[Space(40f)]
	[Header("Информация")]
	public bool isContinue;

	private bool folderNotExists;

	private bool voiceLoadReady;

	private int indexLoadVoiceFiles;

	public List<AudioClip> soundsVoice;

	public string[] soundsVoiceFiles;

	private GameController scrgc;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public Texture2D GetTexture2DLanguage(string _name)
	{
		return null;
	}

	public void HintLocationChange(int _index)
	{
	}

	public void HintScreenSetIndexPosition(int x)
	{
	}

	public void HintLocationHide()
	{
	}

	public void ClosePhotomode(bool x)
	{
	}

	public void DestroyGameobject(GameObject _object)
	{
	}

	public void EvilMenuActivation(bool x)
	{
	}

	public void PlayerMenuActivation(bool x)
	{
	}

	private void GetAllSoundFiles(string _path)
	{
	}

	[IteratorStateMachine(typeof(_003CLoadVoiceFile_003Ed__41))]
	private IEnumerator LoadVoiceFile(string path)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadVoiceFileNow_003Ed__42))]
	private IEnumerator LoadVoiceFileNow(string path, int indexVoice, Dialogue_3DText _dialogueVoice, Audio_loadReady _voiceLoader)
	{
		return null;
	}

	public AudioClip GetVoice(int _indexVoice, Dialogue_3DText _dialogueVoice, Audio_loadReady _voiceLoader)
	{
		return null;
	}

	private bool IsNumeric(string str)
	{
		return false;
	}

	public void SaveStoryMita(string _saveName)
	{
	}

	public void SaveStoryCartridge(string _saveName)
	{
	}

	[IteratorStateMachine(typeof(_003CLoadLevelFrame_003Ed__48))]
	private IEnumerator LoadLevelFrame()
	{
		return null;
	}
}
