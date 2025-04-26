using UnityEngine;
using UnityEngine.UI;

public class Basement_Boiler : MonoBehaviour
{
	[SerializeField]
	private Transform clokerAngle;

	[SerializeField]
	private RectTransform gradus;

	[SerializeField]
	private Text textGradus;

	private int timeUpdateMove;

	[SerializeField]
	[Range(50f, 90f)]
	private float gradusNow;

	private float gradusFNow;

	private float speedF;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void UpdateInterface()
	{
	}
}
