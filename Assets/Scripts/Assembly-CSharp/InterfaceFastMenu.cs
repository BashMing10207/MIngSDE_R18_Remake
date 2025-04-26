using UnityEngine;
using UnityEngine.UI;

public class InterfaceFastMenu : MonoBehaviour
{
	[SerializeField]
	private AudioSource musicPause;

	[SerializeField]
	private Text textHint;

	[SerializeField]
	private AnimationCurve clr;

	[SerializeField]
	[Header("Диалоги")]
	private RectTransform rectDialogues;

	[SerializeField]
	private GameObject objectDialogueExample;

	[SerializeField]
	[Header("Меню - Зло")]
	private AudioClip evilMusic;

	[SerializeField]
	private RuntimeAnimatorController evilAnimatorBackground;

	[Header("Меню - Игрок")]
	[SerializeField]
	private AudioClip playerMusic;

	[SerializeField]
	private RuntimeAnimatorController playerAnimatorBackground;

	[Header("Мирный режим")]
	[SerializeField]
	private GameObject PeacemodeNote;

	[SerializeField]
	private Sprite peacemodeIconReady;

	[SerializeField]
	private Image[] peacemodeNotes;

	[SerializeField]
	[Header("Фоторежим")]
	private ButtonMouseClick buttonPhotomode;

	public void StartComponent(GameController _scrgc)
	{
	}

	private void OnDestroy()
	{
	}

	public void CloseMenu()
	{
	}

	public void Photomode()
	{
	}

	public void ExitMainMenu()
	{
	}
}
