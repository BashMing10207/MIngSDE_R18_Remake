using UnityEngine;

public class Mesh_BlendshapeNoise : MonoBehaviour
{
	private SkinnedMeshRenderer mesh;

	public int[] blendshapes;

	[Range(0f, 101f)]
	public float min;

	[Range(0f, 101f)]
	public float max;

	public bool active;

	[Header("Игрок")]
	public string playerMesh;

	private float animationTimeMax;

	private float animationTimeMin;

	private float animationMax;

	private float animationMin;

	private float animationWasMax;

	private float animationWasMin;

	[Header("Анимация")]
	public AnimationCurve animationLerp;

	public float speed;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Activation(bool _x)
	{
	}

	public void DeactiveZero()
	{
	}

	public void AnimationMaxPlay(float _max)
	{
	}

	public void AnimationMinPlay(float _min)
	{
	}
}
