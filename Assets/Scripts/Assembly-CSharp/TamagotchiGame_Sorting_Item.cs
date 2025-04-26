using UnityEngine;

public class TamagotchiGame_Sorting_Item : MonoBehaviour
{
	[HideInInspector]
	public int typeItem;

	[HideInInspector]
	public bool soundActive;

	private AudioSource audioSource;

	private AudioClip[] soundsDrop;

	private Rigidbody rb;

	private void Update()
	{
	}

	public void RestartPosition(int _typeItem, Mesh _mesh, AudioClip[] _soundsDrop)
	{
	}

	public void StartItem()
	{
	}

	public void Take()
	{
	}

	public void RigidbodyFreeze(bool x)
	{
	}

	public void NoRight()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}
}
