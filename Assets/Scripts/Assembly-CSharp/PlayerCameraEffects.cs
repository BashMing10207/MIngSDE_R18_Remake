using Colorful;
using Kino;
using UnityEngine;

public class PlayerCameraEffects : MonoBehaviour
{
	[SerializeField]
	private Camera cameraPerson;

	[SerializeField]
	private AnimationCurve animationSmooth;

	[Header("Эффекты")]
	public GaussianBlur fxGaussian;

	public Glitch fxGlitch;

	[SerializeField]
	private FastVignette fxFastVignette;

	[SerializeField]
	private Noise fxNoise;

	[SerializeField]
	private AnalogTV fxAnalogTV;

	public Negative fxNegative;

	[SerializeField]
	private Sharpen fxSharpen;

	[HideInInspector]
	public float fxSharpenIntensity;

	public Datamosh datamosh;

	private int datamoshGlitch;

	[Header("Анимационные эффекты")]
	[SerializeField]
	private AudioClip soundClickTelevision;

	private bool fxFV;

	private float fxNoiseInensity;

	private bool fishEye;

	private float timeClickTelevision;

	private Camera cameraMe;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	public void UpdateCameraPerson()
	{
	}

	public void FastVegnetteActive(bool x)
	{
	}

	public void EffectNoise(float _intensity)
	{
	}

	public void EffectFishEye(bool _active)
	{
	}

	public void EffectDatamosh(bool x)
	{
	}

	public void EffectNegative(bool x)
	{
	}

	public void EffectClickTelevision()
	{
	}
}
