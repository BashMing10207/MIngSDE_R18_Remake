using UnityEngine;

public class Mesh_BlendshapeBlink : MonoBehaviour
{
	[SerializeField]
	private bool active;

	[SerializeField]
	private AnimationCurve animationBlink;

	[SerializeField]
	private int indexBlink;

	[SerializeField]
	private float speedBlink;

	private float timeAnimation;

	private float timeRandomBlink;

	private SkinnedMeshRenderer rend;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	private void RandomBlink()
	{
	}

	public void Blink()
	{
	}

	public void Activation(bool x)
	{
	}

	private void OnDisable()
	{
	}
}
