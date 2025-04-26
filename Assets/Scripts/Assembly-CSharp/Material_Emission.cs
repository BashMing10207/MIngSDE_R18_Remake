using NaughtyAttributes;
using UnityEngine;

public class Material_Emission : MonoBehaviour
{
	[SerializeField]
	[ColorUsage(false, true)]
	[Label("Цвет излучения")]
	private Color colorEmission;

	[Label("Включить при старте")]
	[SerializeField]
	private bool activeOnStart;

	[Label("Выключить при старте")]
	[SerializeField]
	private bool deactiveOnStart;

	[Label("Цвета")]
	[ColorUsage(false, true)]
	[SerializeField]
	private Color[] colors;

	[Header("Настройки")]
	[SerializeField]
	[Label("Индексы материалов")]
	private int[] indexMaterials;

	private void Start()
	{
	}

	public void Activation(bool x)
	{
	}

	public void SetColor(int _index)
	{
	}
}
