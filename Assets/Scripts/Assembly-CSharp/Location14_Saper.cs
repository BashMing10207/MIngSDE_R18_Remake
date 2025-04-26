using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.UI;

public class Location14_Saper : MonoBehaviour
{
	[Header("Интерфейс")]
	[SerializeField]
	private Sprite[] caseNormalA;

	[SerializeField]
	private Sprite[] caseNormalB;

	public Sprite[] spriteCountBomb;

	[SerializeField]
	private Sprite caseOpen;

	[SerializeField]
	private Sprite caseFlag;

	[SerializeField]
	private Sprite caseBomb;

	[SerializeField]
	private Image changerBlink;

	[SerializeField]
	private Image flashLose;

	[SerializeField]
	private Sprite[] keysSprites;

	[SerializeField]
	private Sprite[] spriteChangeKey;

	private List<List<GameObject>> cases;

	private List<Location14_SaperCase> casesComponents;

	private List<GameObject> otherObjects;

	[SerializeField]
	[Header("Объекты")]
	private GameObject prefabCase;

	[SerializeField]
	private GameObject prefabFlag;

	[SerializeField]
	private GameObject prefabHole;

	[SerializeField]
	private GameObject prefabBomb;

	[SerializeField]
	private GameObject prefabCount;

	[SerializeField]
	private GameObject prefabDirt;

	[SerializeField]
	private RectTransform caseChanger;

	[SerializeField]
	private RectTransform caseChangerKeys;

	[SerializeField]
	private GameObject objectLose;

	[SerializeField]
	private GameObject objectWin;

	[SerializeField]
	private GameObject[] objectsKeys;

	private Collider caseChangeCast;

	[Header("Физика")]
	[SerializeField]
	private LayerMask layerCase;

	[SerializeField]
	private Camera cameraMain;

	[SerializeField]
	[Header("Анимация")]
	private AnimationCurve animationAlphaChange;

	private float timeAnimationAlphaChange;

	private bool typeClick;

	private float timeBombLose;

	private float timeBombWin;

	private bool play;

	[SerializeField]
	[Header("Звуки")]
	private AudioSource audioBombFind;

	[SerializeField]
	private AudioSource audioFlag;

	[SerializeField]
	private AudioSource audioMusic;

	[SerializeField]
	private AudioClip[] sounds;

	private void StartComponent()
	{
	}

	private void Update()
	{
	}

	[Button("Рестарт", EButtonEnableMode.Always)]
	private void RestartGame()
	{
	}

	public void ClickCase(Location14_SaperCase _case)
	{
	}

	public void ClickKey(GameObject _object)
	{
	}

	private void EnterCase(Location14_SaperCase _caseChange)
	{
	}

	private void EnterKey(GameObject _obejct)
	{
	}

	private void Lose()
	{
	}

	private void CheckWin()
	{
	}

	private void Win()
	{
	}
}
