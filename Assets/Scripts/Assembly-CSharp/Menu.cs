using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Kino;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
	[Serializable]
	public class CaseLoadGame
	{
		public ButtonMouseClick caseButton;

		public string nameSave;

		public string nameScene;

		public int level;
	}

	[CompilerGenerated]
	private sealed class _003CTimeButton_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string _button;

		public Menu _003C_003E4__this;

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
		public _003CTimeButton_003Ed__69(int _003C_003E1__state)
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
	private sealed class _003CTimeButtonLoadScene_003Ed__71 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string _nameScene;

		public Menu _003C_003E4__this;

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
		public _003CTimeButtonLoadScene_003Ed__71(int _003C_003E1__state)
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
	private sealed class _003CChangeLanguageLoading_003Ed__78 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Menu _003C_003E4__this;

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
		public _003CChangeLanguageLoading_003Ed__78(int _003C_003E1__state)
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
	private sealed class _003CAchievementUpdateTime_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Menu _003C_003E4__this;

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
		public _003CAchievementUpdateTime_003Ed__79(int _003C_003E1__state)
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

	private MenuMitaDance scrmmd;

	[Space(20f)]
	public GameObject firstLocation;

	public RectTransform rectMenu;

	public AudioSource audioMusicMenu;

	public AudioClip audioMusicMenuUpdate;

	public AudioSource audioMusicCloth;

	public AudioSource audioMusicDescription;

	public RectTransform rectNameGame;

	private bool hideNameGame;

	[SerializeField]
	private AnimationClip[] otherAnimationsHello;

	[Header("Игра")]
	public string nameSceneNewGame;

	[Header("Достижения")]
	public Text textAchievementProgress;

	public Sprite spriteAchievementNoComplete;

	[Header("Загрузка игры")]
	public CaseLoadGame[] casesLoad;

	public ButtonMouseClick[] casesContinue;

	private bool descriptionLocation;

	[SerializeField]
	[Header("Персонажи")]
	private MenuNextLocation buttonPersonages;

	[SerializeField]
	private GameObject menuPersonagesMita;

	[SerializeField]
	private GameObject menuPersonagesCartridge;

	private bool newGame;

	[Header("Новая игра")]
	public UnityEvent eventStartNewGame;

	private float timeDatamoshGlitch;

	private bool alternative;

	[Header("Редкая альтернатива")]
	public Animator cameraAnimator;

	public RuntimeAnimatorController alternativeAnimatorCamera;

	public RuntimeAnimatorController alternativeAnimator;

	public AudioClip alternativeMusic;

	public ParticleSystem particleBackground;

	public ParticleSystem particleDust;

	public MenuMita menuMita;

	public Datamosh datamosh;

	private bool final;

	private float timeClickAuthor;

	[Header("Финал игры")]
	public Animator animMita;

	public GameObject cutSceneEnding;

	public Transform cameraOrigin;

	public Transform cameraCutscene;

	public Transform scene;

	public ButtonMouseClick buttonAuthorClick;

	public GameObject startCaseEnding;

	public Text textNameCartridge;

	public Text textTimeGameplay;

	public Image screenCapture;

	[Header("Скип старта")]
	public bool skiped;

	public UnityEvent eventSkip;

	[Header("Праздники")]
	[SerializeField]
	private Image imageBackground;

	[SerializeField]
	private Sprite spriteBackgroundHalloween;

	[SerializeField]
	private Sprite spriteBackgroundChristmas;

	[SerializeField]
	[Header("Мирный режим")]
	private GameObject[] peaceModeCases;

	private float timeLoading;

	private bool loading;

	[Header("Настройки")]
	[SerializeField]
	private GameObject loadingInterface;

	[SerializeField]
	private MenuCaseOption buttonLanguage;

	private float timeMenu;

	private Color colorBackground;

	[HideInInspector]
	public GameObject objectLocationLast;

	private bool firstOpenAchievement;

	private void Start()
	{
	}

	private void Holidays()
	{
	}

	private void Update()
	{
	}

	public void OpenNextLocation(GameObject objectLocation)
	{
	}

	public void StartAchievement()
	{
	}

	private void Alternative()
	{
	}

	private void SkipStart()
	{
	}

	public void SkipStop()
	{
	}

	public void CutSceneEnd()
	{
	}

	public void ButtonFullClear()
	{
	}

	public void ButtonURL(string _url)
	{
	}

	public void ButtonNewGame()
	{
	}

	[IteratorStateMachine(typeof(_003CTimeButton_003Ed__69))]
	private IEnumerator TimeButton(string _button)
	{
		return null;
	}

	public void ButtonLoadScene(string _nameScene)
	{
	}

	[IteratorStateMachine(typeof(_003CTimeButtonLoadScene_003Ed__71))]
	private IEnumerator TimeButtonLoadScene(string _nameScene)
	{
		return null;
	}

	public void ButtonContinue()
	{
	}

	private void NextLevel()
	{
	}

	public void Description(bool x)
	{
	}

	public void ChangeKategoryPersonages(int x)
	{
	}

	public void LoadingActive(bool x)
	{
	}

	public void ChangeLanguage()
	{
	}

	[IteratorStateMachine(typeof(_003CChangeLanguageLoading_003Ed__78))]
	private IEnumerator ChangeLanguageLoading()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAchievementUpdateTime_003Ed__79))]
	private IEnumerator AchievementUpdateTime()
	{
		return null;
	}
}
