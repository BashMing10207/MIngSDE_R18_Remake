using UnityEngine;

public class Core_Chair : MonoBehaviour
{
	[SerializeField]
	private bool active;

	[SerializeField]
	private Transform chairHorizontal;

	[SerializeField]
	private Transform chairVertical;

	[SerializeField]
	private Transform[] linesParent;

	private float speed;

	private Transform cameraPlayer;

	private bool move;

	private AudioSource audioMove;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Activation(bool x)
	{
	}

	public void ForAnimationThrow()
	{
	}
}
