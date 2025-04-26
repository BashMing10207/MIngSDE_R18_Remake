using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Location18_TicTacToe_Case : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler
{
	private Location18_TicTacToe main;

	private int index;

	private bool canClick;

	private bool destroySmooth;

	private Image img;

	private float timeAnimationIcon;

	private Image icon;

	[SerializeField]
	private AnimationCurve animationFill;

	private void Update()
	{
	}

	public void DestroySmooth()
	{
	}

	public void StartComponent(Location18_TicTacToe _main, int _index)
	{
	}

	public void CanClick(bool x)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void UpdateIcon()
	{
	}
}
