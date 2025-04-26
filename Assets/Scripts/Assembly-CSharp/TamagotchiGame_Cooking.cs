using UnityEngine;
using UnityEngine.Events;

public class TamagotchiGame_Cooking : MonoBehaviour
{
	[SerializeField]
	private UnityEvent eventReady;

	[SerializeField]
	private TamagotchiGame_Cooking_Food[] food;

	[SerializeField]
	private AnimationCurve animationTake;

	[SerializeField]
	private RectTransform sliderCut;

	[SerializeField]
	private Audio_Data audioCut;

	[SerializeField]
	private AudioSource audioDone;

	private bool canCut;

	private bool cutBack;

	private bool cutHold;

	private GameObject foodTakeNow;

	private int indexCut;

	private int indexCutFood;

	private bool ready;

	private void OnEnable()
	{
	}

	private void LateUpdate()
	{
	}

	public void Ready()
	{
	}

	public void TakeFood(GameObject _food)
	{
	}

	public void Cut()
	{
	}

	public void CutHold(bool x)
	{
	}
}
