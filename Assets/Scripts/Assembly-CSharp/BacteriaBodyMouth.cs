using UnityEngine;

public class BacteriaBodyMouth : MonoBehaviour
{
	[Header("Настройки")]
	public BacteriaFood.TypeFood typeFood;

	[SerializeField]
	private float radiusEat;

	private float timeCheckFood;

	[Header("Физика")]
	[SerializeField]
	private LayerMask layerFood;

	private bool startEatBody;

	private float timeEating;

	private GameObject foodEat;

	private Animator animMouth;

	[Header("Моя бактерия")]
	[SerializeField]
	private BacteriaBody bacteria;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void Eat(GameObject _objectFood)
	{
	}

	private void EatFinish()
	{
	}

	public void ResetMouth()
	{
	}
}
