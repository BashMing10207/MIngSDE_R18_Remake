using UnityEngine;
using UnityEngine.UI;

public class Location4TableCardGame_Card : MonoBehaviour
{
	[SerializeField]
	private Transform mainCanvas;

	[SerializeField]
	private Text textHeart;

	[SerializeField]
	private Text textDamage;

	[SerializeField]
	private Text textShield;

	[SerializeField]
	private GameObject particleDestroy;

	private float timeDestroy;

	[Header("Удаление")]
	[SerializeField]
	private AnimationCurve animationDestroy;

	public void StartComponent(int _heart, int _damage, int _shield)
	{
	}

	private void Update()
	{
	}

	public void DestroyAlpha(float _time)
	{
	}
}
