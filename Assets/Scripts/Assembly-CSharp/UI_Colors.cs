using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UI_Colors : MonoBehaviour
{
	[SerializeField]
	private bool startInvisible;

	public bool onEnableInvisible;

	[SerializeField]
	private bool deactive;

	[SerializeField]
	private float speed;

	[SerializeField]
	private UnityEvent eventDestroy;

	[SerializeField]
	private bool autoFindUI;

	[SerializeField]
	private UI_Colors[] redirection;

	private bool hide;

	private bool fs;

	private float share;

	private bool destroyMe;

	[Header("Информация")]
	public List<Image> ui_images;

	public List<Color> ui_imagesColor;

	public List<Text> ui_text;

	public List<Color> ui_textColor;

	public void Start()
	{
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	public void Hide(bool x, bool _fast)
	{
	}

	public void Hide(bool x)
	{
	}

	public void SetColorImage(int _index, Color _color)
	{
	}

	public void SetColorImage(GameObject _object, Color _color)
	{
	}

	public void ShareAlpha(float x)
	{
	}

	public void DestroyHide()
	{
	}

	public void Reload()
	{
	}
}
