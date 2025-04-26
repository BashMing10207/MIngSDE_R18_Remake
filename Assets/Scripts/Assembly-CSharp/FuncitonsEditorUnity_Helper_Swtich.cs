using System;
using UnityEngine;

[Serializable]
public class FuncitonsEditorUnity_Helper_Swtich
{
	public bool active;

	public string note;

	[Header("Материалы")]
	public DataValues_Material_Materials[] materials;

	[Header("Объекты")]
	public GameObject[] obejctsOn;

	public GameObject[] obejctsOff;
}
