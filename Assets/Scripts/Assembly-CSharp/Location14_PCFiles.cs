using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Location14_PCFiles : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler
{
	private bool mouseHold;

	private Image img;

	private RectTransform rect;

	private Vector2 positionOrigin;

	private Transform parentOrigin;

	[HideInInspector]
	public int indexColor;

	[SerializeField]
	private Sprite[] iconFiles;

	public RectTransform mouse;

	public Location14_PCGames main;

	private float timeAnimationSize;

	private AnimationCurve animationSize;

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void StartComponent(int _indexColor)
	{
	}

	public void SetPosition(Transform _parent, Vector2 _position)
	{
	}

	private void Update()
	{
	}
}
