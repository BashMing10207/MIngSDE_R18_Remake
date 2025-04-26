using UnityEngine;
using UnityEngine.Events;

public class TamagotchiGame_HelpTrash : MonoBehaviour
{
	public UnityEvent eventFinish;

	[Header("Корзинка")]
	public GameObject basket;

	public GameObject basketPointer;

	[Header("Мусор")]
	public AnimationCurveTransforms[] trashes;

	public AnimationCurve animationFly;

	public AnimationCurve animationBasket;

	public ParticleSystem particleTrash;

	[Header("Звуки")]
	public AudioSource audioTrash;

	public AudioClip[] soundsTrashDrop;

	public AudioSource audioClothTake;

	public AudioClip[] soundsTakeCloth;

	private GameObject trashTake;

	private bool ready;

	private float timeAnimationPointer;

	private void Update()
	{
	}

	public void ClickBasket()
	{
	}

	public void TakeTrash(GameObject _trash)
	{
	}

	private void OnEnable()
	{
	}
}
