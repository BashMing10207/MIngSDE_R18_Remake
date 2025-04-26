using System;
using UnityEngine;

[Serializable]
public class PersonageResource
{
	public Sprite icon;

	public int indexDescriptionStringFile;

	public int indexNameStringFile;

	[Header("Ресурс")]
	public string resourcePath;

	public Color color1;

	public Color color2;

	public GameObject caseBack;

	[Header("Меню")]
	public string nameSave;

	public Menu_CasePersonage buttonMenu;
}
