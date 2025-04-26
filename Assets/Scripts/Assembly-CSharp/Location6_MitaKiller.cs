using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

public class Location6_MitaKiller : MonoBehaviour
{
	[SerializeField]
	private PlayableGraph m_Graph;

	[SerializeField]
	private Transform[] positionsAnimationKill;

	private float timeLose;

	private bool killNow;

	[Header("Kill")]
	[SerializeField]
	private ObjectAnimationPlayer animationKill;

	[SerializeField]
	private UnityEvent eventKill;

	[SerializeField]
	private UnityEvent eventRestart;

	[SerializeField]
	private UnityEvent eventStart;

	[SerializeField]
	private Transform mita;

	[SerializeField]
	private Player_Teleport tpRestart;

	[SerializeField]
	[Header("Game")]
	private Trigger_Event[] triggers;

	[SerializeField]
	private Trigger_Event[] triggersDanger;

	[SerializeField]
	private WorldPlayer worldPlayer;

	private Transform player;

	private PlayableDirector cutScene;

	private bool playerExit;

	private AudioSource audioLook;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Kill()
	{
	}

	public void RestartGame()
	{
	}

	public void PlayerLose()
	{
	}

	public void StartAttack()
	{
	}

	public void PlayerExit()
	{
	}
}
