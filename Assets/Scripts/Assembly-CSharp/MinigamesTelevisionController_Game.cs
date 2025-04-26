using System;
using UnityEngine;

[Serializable]
public class MinigamesTelevisionController_Game
{
	public string nameResource;

	public int indexStringNameGame;

	public Sprite spriteCase;

	public Sprite spriteBackground;

	public Color gradienText1;

	public Color gradienText2;

	public Color outlineText;

	public GameObject[] dataObjects;

	[HideInInspector]
	public bool playead;

	[HideInInspector]
	public float timeTalk;

	[Header("Диалоги")]
	public GameObject[] dialogueWin;

	[HideInInspector]
	public int countWin;

	public GameObject[] dialogueLose;

	[HideInInspector]
	public int countLose;

	public GameObject[] dialogueDraw;

	[HideInInspector]
	public int countDraw;

	public GameObject dialogueInfo;

	public GameObject dialoguePlayed;

	public GameObject dialogueStartPlay;

	[HideInInspector]
	public GameObject caseMenu;

	[HideInInspector]
	public GameObject objectGame;
}
