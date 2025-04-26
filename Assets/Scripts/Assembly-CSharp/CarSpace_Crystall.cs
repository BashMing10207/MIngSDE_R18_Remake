using UnityEngine;

public class CarSpace_Crystall : MonoBehaviour
{
	private MeshFilter meshFilter;

	private MeshRenderer rend;

	private bool kill;

	[SerializeField]
	private Mesh[] meshes;

	[SerializeField]
	private Transform crystall;

	[SerializeField]
	private Collider carPlayer;

	private float timeLife;

	private float timeAnimationUp;

	private float timeAnimationColor;

	[SerializeField]
	private AnimationCurve animationUp;

	public void StartComponent()
	{
	}

	private void Update()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}
}
