using System.Collections.Generic;
using UnityEngine;

public class Light_LightingColor : MonoBehaviour
{
	[SerializeField]
	private AnimationCurve animColor;

	[ColorUsage(false)]
	public Color[] colors;

	[SerializeField]
	private float speed;

	private Color colorWas;

	private Color colorNeed;

	private float timeColor;

	private float timeLerpFog;

	private float fogStartWas;

	private float fogEndWas;

	private float fogStartNeed;

	private float fogEndNeed;

	private Color fogColorWas;

	private Color fogColorNeed;

	private bool fogActive;

	private List<Light_Glass> glasses;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SharplyColor(int _index)
	{
	}

	public void LerpColor(int _index)
	{
	}

	public void LerpSpeed(float _speed)
	{
	}

	public void LerpFogDeactive()
	{
	}

	public void LerpFog(float _start, float _end, Color _color)
	{
	}

	public void LerpFog(Color _color)
	{
	}

	public void LerpFogColor(int _index)
	{
	}

	public void FogActivation(bool x)
	{
	}

	public void FogDistanceStart(float x)
	{
	}

	public void FogDistanceEnd(float x)
	{
	}

	public void GlassesAdd(Light_Glass _glass)
	{
	}

	public void GlassesUpdate()
	{
	}
}
