using UnityEngine;

public class SpriteRenderer_TextureLanguage : MonoBehaviour
{
	public string nameTexture;

	[Header("Цвет")]
	[SerializeField]
	private bool colorEmission;

	[SerializeField]
	[ColorUsage(false, true)]
	private Color colorText;

	private void Start()
	{
	}
}
