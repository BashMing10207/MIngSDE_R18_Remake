using UnityEngine;

public class BacteriaFood : MonoBehaviour
{
	public enum TypeFood
	{
		meat = 0,
		plants = 1,
		food = 2
	}

	public TypeFood typeFood;

	[HideInInspector]
	public bool eating;

	private Rigidbody rb;

	private void Start()
	{
	}

	public void Eating(bool x)
	{
	}

	public void EatFinish()
	{
	}
}
