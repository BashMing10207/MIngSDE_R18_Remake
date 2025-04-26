using UnityEngine;
using UnityEngine.UI;

public class GameController_InventoryCase : MonoBehaviour
{
	[HideInInspector]
	public GameObject itemKey;

	private bool destroyMe;

	private float positionX;

	private RectTransform rectMe;

	private Image img;

	[SerializeField]
	[Header("Интерфейс")]
	private Image imageIcon;

	[SerializeField]
	private Image imageBack;

	private float timeAnimationScale;

	[Header("Анимация")]
	[SerializeField]
	private AnimationCurve animationScale;

	public void StartComponent(GameObject _itemKey, Sprite _icon, float _position)
	{
	}

	public void Reposition(float _position)
	{
	}

	private void Update()
	{
	}

	public void Remove()
	{
	}
}
