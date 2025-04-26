using UnityEngine;

[RequireComponent(typeof(AudioLowPassFilter))]
public class AudioRoom_Audio : MonoBehaviour
{
	[SerializeField]
	private float minimcalClamp;

	[SerializeField]
	private float cutOutOutRoom;

	[SerializeField]
	private float cutOutRoom;

	private float cut;

	private AudioLowPassFilter passFilter;

	private bool inRoom;

	private LayerMask layerWall;

	private Transform headPlayer;

	private bool lineCastPlayer;

	private int timeCheck;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void PlayerInRoom(bool x)
	{
	}

	private void CheckCast()
	{
	}

	private void FastCastSound()
	{
	}
}
