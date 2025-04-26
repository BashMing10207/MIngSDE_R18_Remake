using UnityEngine;
using UnityEngine.UI;

public class Location7_ChibiText : MonoBehaviour
{
	[SerializeField]
	private Text textA;

	[SerializeField]
	private Text textB;

	[SerializeField]
	private AnimationCurve anim;

	[SerializeField]
	private float speedTime;

	[SerializeField]
	private int startString;

	[SerializeField]
	private int finishString;

	private float timeAnim;

	private Transform cameraT;

	private float rotZ;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}
}
