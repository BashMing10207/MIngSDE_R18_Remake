using UnityEngine;
using UnityEngine.UI;

public class UI_ImageSprites : MonoBehaviour
{
	[SerializeField]
	private Sprite[] sprites;

	[SerializeField]
	private float speed;

	[SerializeField]
	private bool untimeScale;

	private float timeNext;

	private int indexSprite;

	private Image img;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
