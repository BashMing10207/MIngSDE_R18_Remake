using UnityEngine;
using UnityEngine.UI;

public class Location14_SaperCase : MonoBehaviour
{
	private Location14_Saper main;

	private RectTransform rect;

	private Image img;

	[HideInInspector]
	public int posx;

	[HideInInspector]
	public int posy;

	[HideInInspector]
	public bool hole;

	[HideInInspector]
	public bool bomb;

	[Header("Интерфейс")]
	[SerializeField]
	private Image imageCountBomb;

	[HideInInspector]
	public GameObject objectFlag;

	public void StartComponent(Location14_Saper _main, int _x, int _y, Sprite _spriteOriginal)
	{
	}

	public void SetInfo(int _countBomb)
	{
	}

	public void ResetBlock()
	{
	}

	public void HideCount()
	{
	}
}
