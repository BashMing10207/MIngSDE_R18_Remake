using UnityEngine;

public class Location18_Personage : MonoBehaviour
{
	private GameObject spritePersonage;

	public int namePersonage;

	public float posY;

	public float multipleSizeDown;

	public Color colorName;

	public Color colorGradientText1;

	public Color colorGradientText2;

	public Color colorGradientText3;

	public Color colorGradientText4;

	public Color colorShadow;

	public int timeShortSound;

	private float posYFix;

	private bool showSprite;

	private Sprite spriteNeed;

	private float timeAnimationScale;

	private float scaleWas;

	private float scaleNeed;

	private float timeAnimationMove;

	private float positionMoveWas;

	private float positionMoveNeed;

	private float timeAnimationPivot;

	private float positionPivotWas;

	private float positionPivotNeed;

	[SerializeField]
	[Header("Анимации")]
	private AnimationCurve animationMove;

	public void StartComponent(GameObject _exampleObjectSprite)
	{
	}

	private void Update()
	{
	}

	public void ShowPersonage(bool _x)
	{
	}

	public void ShowPersonageFast(bool _x)
	{
	}

	public void SpriteRechange(Sprite _sprite)
	{
	}

	public void SpriteRechangeFast(Sprite _sprite)
	{
	}

	public void MoveX(float _x)
	{
	}

	public void MoveXFast(float _x)
	{
	}

	public void PivotX(float _x)
	{
	}

	public void ScaleFast(float _x)
	{
	}

	public void Scale(float _x)
	{
	}
}
