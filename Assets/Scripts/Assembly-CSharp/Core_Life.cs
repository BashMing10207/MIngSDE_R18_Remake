using UnityEngine;

public class Core_Life : MonoBehaviour
{
	private float timeServer;

	[SerializeField]
	private Renderer[] emissionOff;

	[SerializeField]
	private Core_Life_Server[] servers;

	[SerializeField]
	private AnimationCurve animationServerWork;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
