using UnityEngine;

public class Material_VariablesLerp : MonoBehaviour
{
	public Material_VariablesLerp_Data[] meshes;

	public AnimationCurve animationLerp;

	private float timeAnimaionLerp;

	public string nameVariable;

	[Header("При старте")]
	public bool onStart;

	public float onStartFloat;

	private float needVariable;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void LerpVariable(float x)
	{
	}

	public void SharplyVariable(float x)
	{
	}

	private void UpdateMaterials()
	{
	}

	public void UseStartVariable()
	{
	}
}
