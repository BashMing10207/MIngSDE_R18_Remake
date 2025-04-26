using UnityEngine;
using UnityEngine.Events;

public class Location14_Dialogue : MonoBehaviour
{
	public enum Loc14WhioSpeak
	{
		player = 0,
		mita = 1
	}

	public Loc14_Dialogue[] dialogue;

	[SerializeField]
	private Location14_GameQuestPlayer main;

	public UnityEvent eventFinish;

	[Header("Разветвление")]
	public int indexFileRight;

	public int indexFileLeft;

	public UnityEvent eventRight;

	public UnityEvent eventLeft;

	public void Play()
	{
	}
}
