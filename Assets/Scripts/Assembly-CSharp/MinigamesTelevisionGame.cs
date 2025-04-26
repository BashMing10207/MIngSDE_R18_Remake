using UnityEngine;
using UnityEngine.Events;

public class MinigamesTelevisionGame : MonoBehaviour
{
	[SerializeField]
	private GameObject objectInterface;

	[SerializeField]
	private GameObject objectGame;

	[SerializeField]
	private GameObject[] keysHint;

	[SerializeField]
	private UnityEvent eventStartPlay;

	private MinigamesTelevisionController main;

	public void StartComponent(MinigamesTelevisionController _main, Transform _targetInterface, Transform _targetInterfaceKeys)
	{
	}

	public void GameWin(UnityAction call)
	{
	}

	public void GameLose(UnityAction call)
	{
	}

	public void GameDraw(UnityAction call)
	{
	}

	public void ExitGame()
	{
	}

	public void PlayGame()
	{
	}

	public void AudioGamepad(bool _player)
	{
	}
}
