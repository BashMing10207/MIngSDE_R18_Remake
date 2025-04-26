using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuVoiceInfo : MonoBehaviour
{
	private Texture2D textureLoad;

	[SerializeField]
	private Image pictureLogo;

	[SerializeField]
	private GameObject buttonExample;

	[SerializeField]
	private GameObject textExample;

	[HideInInspector]
	public List<GameObject> objects;

	public void Activation(bool _x)
	{
	}

	public void ChangeIndex(string _folder)
	{
	}
}
