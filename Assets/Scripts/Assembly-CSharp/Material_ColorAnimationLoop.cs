using UnityEngine;

public class Material_ColorAnimationLoop : MonoBehaviour
{
	public GameObject[] meshes;

	public string nameVariable;

	private float timeAnimation;

	[Header("Анимация")]
	public float speed;

	public Color colorAnimationA;

	public Color colorAnimationB;

	public AnimationCurve animationColor;

	public bool order;

	[Header("Стартовая анимация")]
	public AnimationCurve animationCurveStart;

	public Color colorAnimationStart;

	public bool colorStart;

	private int indexOrder;

	private Color colorAnim;

	private Color colorAnimEnd;

	private AnimationCurve curveAnim;

	private void Update()
	{
	}

	private void NextOrder()
	{
	}

	private void OnEnable()
	{
	}

	public void ColorChange()
	{
	}
}
