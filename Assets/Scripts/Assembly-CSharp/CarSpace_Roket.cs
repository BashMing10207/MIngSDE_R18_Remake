using UnityEngine;

public class CarSpace_Roket : MonoBehaviour
{
	[SerializeField]
	private CarSpace_Main main;

	[SerializeField]
	private GameObject prefabDestroy;

	[SerializeField]
	private GameObject placeFinish;

	private CarSpace_Car carCtrl;

	private Transform car;

	private float posX;

	private float distance;

	public void StartComponent(Transform _car, Transform _boss, CarSpace_Main _main)
	{
	}

	private void Update()
	{
	}

	private void Explode()
	{
	}

	private void OnDestroy()
	{
	}
}
