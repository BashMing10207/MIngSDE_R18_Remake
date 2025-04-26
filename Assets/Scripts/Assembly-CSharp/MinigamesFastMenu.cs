using UnityEngine;

public class MinigamesFastMenu : MonoBehaviour
{
	private int indexChangeButton;

	private bool exitGameGo;

	[SerializeField]
	[Header("Быстрое меню")]
	private MinigamesController main;

	[SerializeField]
	private RectTransform fastMenuBackground;

	[SerializeField]
	private RectTransform changer;

	public MinigamesFastMenu_Case[] cases;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnEnable()
	{
	}

	private void UpdateChanger()
	{
	}

	public void FastMenuClickButton()
	{
	}

	public void CaseMouseEnter(int _index)
	{
	}

	public void AudioEnter()
	{
	}
}
