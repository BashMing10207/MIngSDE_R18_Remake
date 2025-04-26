using UnityEngine;

public class WorldPlayer_AnimationFOV : MonoBehaviour
{
	[SerializeField]
	[Header("Камера")]
	private AnimationCurve cameraAnimationTarget;

	[SerializeField]
	private AnimationCurve cameraAnimationFOV;

	[SerializeField]
	private float speedAnimationFOV;

	public void Rechange()
	{
	}
}
