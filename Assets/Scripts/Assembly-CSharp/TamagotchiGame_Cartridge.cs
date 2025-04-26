using UnityEngine;

public class TamagotchiGame_Cartridge : MonoBehaviour
{
	[SerializeField]
	private Tamagotchi_AddMoney moneyAdd;

	[SerializeField]
	private int energy;

	[SerializeField]
	private AudioSource audioTrash;

	private bool cassette1Ready;

	private bool cassette2Ready;

	private bool cassette3Ready;

	private GameObject takeCassette;

	private float rotationTime;

	[SerializeField]
	[Header("Картриджи")]
	private GameObject cartridge1;

	[SerializeField]
	private GameObject cartridge2;

	[SerializeField]
	private GameObject cartridge3;

	[SerializeField]
	private Transform targetRotation;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void RestartGame()
	{
	}

	public void TakeCassette(GameObject _object)
	{
	}

	public void CasseteReady(GameObject _object)
	{
	}

	public void SwitchPut()
	{
	}

	public void Trash()
	{
	}
}
