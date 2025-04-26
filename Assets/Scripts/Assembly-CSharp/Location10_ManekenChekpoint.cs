using UnityEngine;
using UnityEngine.Events;

public class Location10_ManekenChekpoint : MonoBehaviour
{
	[SerializeField]
	private ManekenData[] manekens;

	[SerializeField]
	private int indexSavePoint;

	[SerializeField]
	private Player_Teleport[] savePositionPlayer;

	[SerializeField]
	private UnityEvent eventRestart;

	public void ManekenAttack(GameObject _maneken)
	{
	}

	public void PlayerDeath()
	{
	}

	public void SavePoint(int _save)
	{
	}

	public void StopManekens()
	{
	}

	public void CanReset(int _index)
	{
	}

	public void CantReset(int _index)
	{
	}

	public void ResetActive(int _index)
	{
	}

	public void ResetDeactive(int _index)
	{
	}

	public void LastCheckpoint()
	{
	}

	public void DeleteManekens()
	{
	}
}
