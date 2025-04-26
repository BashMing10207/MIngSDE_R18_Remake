using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

public class Playable_Animation : MonoBehaviour
{
	public bool useCamera;

	[HideInInspector]
	public Transform cameraTarget;

	public UnityEvent eventStart;

	public UnityEvent eventStop;

	public bool destroyAfter;

	private GameController scrgc;

	private PlayableDirector scrpd;

	private void Start()
	{
	}

	public void Play()
	{
	}

	public void PlayAsset(PlayableAsset _asset)
	{
	}

	private void OnPlayableDirectorStopped(PlayableDirector aDirector)
	{
	}
}
