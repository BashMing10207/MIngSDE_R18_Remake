using UnityEngine;

public class CarSpace_Enemy : MonoBehaviour
{
	[SerializeField]
	[Header("Объекты")]
	private Transform targetMove;

	[SerializeField]
	private Transform car;

	private int indexRoadPath;

	[Header("Дорога")]
	[SerializeField]
	private Vector3[] roadPath;

	private bool play;

	private CarSpace_Car carController;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Play()
	{
	}

	public void StopRestart(Vector3 _position, Quaternion _rotation)
	{
	}
}
