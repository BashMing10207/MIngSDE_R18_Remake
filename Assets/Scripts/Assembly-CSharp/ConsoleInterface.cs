using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ConsoleInterface : MonoBehaviour
{
	[Serializable]
	public class ConsoleCheats
	{
		public string nameCheat;

		public string cheat;

		public string cheatHelper;
	}

	[CompilerGenerated]
	private sealed class _003CChangeInput_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CChangeInput_003Ed__33(int _003C_003E1__state)
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

	public GameObject inputTextObject;

	[SerializeField]
	private Text textHelper;

	private int textHelperIndex;

	public RectTransform textContent;

	public Text textInfo;

	public Text textString;

	public Text textCountChar;

	public string versionText;

	public GameObject[] buttonsDrop;

	public ConsoleCheats[] cheats;

	[TextArea(2, 10)]
	[Header("Текст")]
	public string textHelpRu;

	[TextArea(2, 10)]
	public string textHelpEng;

	private Color colorConsole;

	private string typeColor;

	private Text textTimer;

	private GameObject settingsObject;

	private int iLastCodeNow;

	private InputField inputField;

	[HideInInspector]
	public GameObject objectCallMe;

	private GameObject[] resourcesCasesObject;

	[HideInInspector]
	public int resourcesTypeCreate;

	private AudioSource aud;

	private bool autoDown;

	private float timeStartConsoleInterface;

	[HideInInspector]
	public UnityEvent eventEnterHelp;

	[HideInInspector]
	public GameObject[] objectWindow;

	private GameObject panelCloseAddoneWindows;

	private bool functionsCreate;

	private bool levelsCreate;

	private bool cursorVisibleWas;

	private CursorLockMode cursorLockWas;

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CChangeInput_003Ed__33))]
	private IEnumerator ChangeInput()
	{
		return null;
	}

	private void Update()
	{
	}

	private void UpdateSuggestion(string input)
	{
	}

	private void OnDestroy()
	{
	}

	public void EnterConsole()
	{
	}

	public void PrintDebug(string _string)
	{
	}

	public void Clear()
	{
	}

	public void Close()
	{
	}

	public void MouseHide()
	{
	}

	private void Quit()
	{
	}

	public void ShowHierarchy()
	{
	}

	private void FindObject(string _string)
	{
	}

	private void FindObjectTag(string _string)
	{
	}

	public void Help()
	{
	}

	private void FindSkinnedMesh(string _string)
	{
	}

	public void ShowInformation()
	{
	}

	private void DeleteFileSave()
	{
	}

	public void UnityDebug()
	{
	}

	private void HideUI()
	{
	}

	public void LightCam()
	{
	}

	public void ClickFunction(int _indexCheat)
	{
	}

	public void ShowProcess()
	{
	}

	private void Trailer()
	{
	}

	public void ResourcesType(int x)
	{
	}

	public void Recolor(string colorSetting)
	{
	}

	public void SaveFile()
	{
	}

	public void CameraFly()
	{
	}

	public void AutoDown()
	{
	}

	public void OpenSettings()
	{
	}

	public void OpenFunctions()
	{
	}

	public void OpenAddons()
	{
	}

	public void OpenResources()
	{
	}

	public void OpenEditor()
	{
	}

	public void OpenLevels()
	{
	}

	public void ToggleDebugUnity()
	{
	}

	public void OpenData()
	{
	}

	public void CheckLocalization()
	{
	}

	private string[] LocalizationClearText(string[] _text)
	{
		return null;
	}

	private List<LanguageFilesText> LocalizatioLoad(string _path)
	{
		return null;
	}

	public void SaveSettings()
	{
	}

	private void SaveDev()
	{
	}

	public void SoundPlay(int soundInt)
	{
	}

	public void AddoneWindowAdd(GameObject _object)
	{
	}

	public void AddoneWindowCloseAll()
	{
	}

	public void ChangeButtonOpen(GameObject _object)
	{
	}
}
