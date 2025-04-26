using UnityEngine;
using UnityEngine.UI;

public class Dialogue_Symbol : MonoBehaviour
{
	public Text shadowText;

	public Material materialJump;

	private bool destroy;

	private Rigidbody rb;

	private RectTransform rect;

	private Vector2 posOrigin;

	private float scaleOriginal;

	private Vector3 rotationFly;

	private Vector2 noiseFly;

	private float noiseStart;

	private float noise;

	private Vector2 noisePos;

	private bool alphaDestroy;

	private Dialogue_3DText scrd3;

	private AnimationCurve animationCurveScale;

	private float speedAnimation;

	private float animationStart;

	private Quaternion rotationStart;

	[Header("Информация")]
	public float timeLife;

	public float timeNow;

	private float speedGravity;

	public void StartComponent(Dialogue_3DText _scrd3, float _timeLife, float _noiseStart, float _noise, float _startRotation)
	{
	}

	private void Update()
	{
	}

	public void Jump()
	{
	}

	public void Hide(bool _x)
	{
	}
}
