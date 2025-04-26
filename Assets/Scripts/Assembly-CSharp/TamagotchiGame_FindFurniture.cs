using UnityEngine;

public class TamagotchiGame_FindFurniture : MonoBehaviour
{
	[SerializeField]
	private TamagotchiGame_FindFurniture_Object[] furnitures;

	[SerializeField]
	private GameObject[] objectsDestroyFinish;

	[Header("Звуки")]
	[SerializeField]
	private AudioClip[] soundsFind;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ClickFurniture(GameObject _object)
	{
	}

	public void Finish()
	{
	}

	public void Activation(bool _x)
	{
	}

	public void ActivationObject(GameObject _object)
	{
	}
}
