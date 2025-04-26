using UnityEngine;

public class Location3FoodMita : MonoBehaviour
{
	private int indexFood;

	[Header("Food")]
	[SerializeField]
	private GameObject[] foods;

	[SerializeField]
	private Audio_Data audioFootTake;

	private float timeSous;

	private int countSousActive;

	[Header("Соус Миты")]
	[SerializeField]
	private Vector3[] sousPositions;

	[SerializeField]
	private LineRenderer lineSous;

	private float timeSousPlayer;

	private int countSousPlayerActive;

	[Header("Соус игрока")]
	[SerializeField]
	private Vector3[] sousPlayerPositions;

	[SerializeField]
	private LineRenderer lineSousPlayer;

	private void Update()
	{
	}

	public void TakeFood()
	{
	}

	public void EatFood()
	{
	}

	public void StartSous()
	{
	}

	public void StartSousPlayer()
	{
	}
}
