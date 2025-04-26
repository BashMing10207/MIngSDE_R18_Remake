using UnityEngine;

public class TamagotchiGame_Sorting : MonoBehaviour
{
	public Tamagotchi_AddMoney moneyAdd;

	public int energy;

	public GameObject box1;

	public GameObject box2;

	public GameObject box3;

	[Header("Предметы")]
	public Mesh meshItem1;

	public Mesh meshItem2;

	public Mesh meshItem3;

	public TamagotchiGame_Sorting_ItemAnimation[] items;

	[Header("Анимация")]
	public AnimationCurve animaitonItemDrop;

	[Header("Звуки")]
	public AudioSource audioBoxDropItem;

	public AudioClip[] soundsBoxDropItem;

	public AudioClip[] soundsBoxBottle;

	public AudioClip[] soundsBoxMetal;

	public AudioClip[] soundsBoxFood;

	private GameObject itemTake;

	private float timeStart;

	private float timeItemStart;

	private int itemIndexStart;

	private bool firstStart;

	private void Update()
	{
	}

	public void Restart()
	{
	}

	public void TakeItem(GameObject _object)
	{
	}

	public void DropItemBox(GameObject _obejct)
	{
	}
}
