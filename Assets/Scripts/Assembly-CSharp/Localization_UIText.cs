using NaughtyAttributes;
using UnityEngine;

[AddComponentMenu("Functions/Localization/Localization UI Text")]
public class Localization_UIText : MonoBehaviour
{
	public bool EveryEnable;

	public string NameFile;

	public int StringNumber;

	public int StringReserveNumber;

	public bool GrandSymbol;

	public bool data;

	public bool dontAutoTranslate;

	public bool dontAutoFont;

	public bool fontPixel;

	public bool onEnable;

	[SerializeField]
	private string add;

	[SerializeField]
	private string reffect0;

	[HideInInspector]
	public bool deactiveTextTranslate;

	[HideInInspector]
	public bool fs;

	public void OnEnable()
	{
	}

	private void Start()
	{
	}

	[Button("Перевести", EButtonEnableMode.Always)]
	public void TextTranslate()
	{
	}

	public void ReString(int x)
	{
	}

	public void ReFile(string x)
	{
	}

	public void DestroyObject()
	{
	}
}
