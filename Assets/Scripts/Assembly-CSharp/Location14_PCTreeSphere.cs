using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Location14_PCTreeSphere : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[SerializeField]
	private Location14_PCGames main;

	[SerializeField]
	private Image imgSub;

	[SerializeField]
	private Image mouseClick;

	[SerializeField]
	private AnimationCurve animationAlphaClick;

	private float timeAnimationClick;

	[SerializeField]
	private AnimationCurve animationIntensity;

	[SerializeField]
	private Sprite spriteCircle;

	[SerializeField]
	private Sprite spriteCircleVignette;

	[HideInInspector]
	public bool ready;

	private Image img;

	private float x;

	private float y;

	private float z;

	private RectTransform rect;

	public void StartComponent()
	{
	}

	public void UpdateCircle()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	private void Update()
	{
	}
}
