using System.Collections.Generic;
using UnityEngine;

public class ScrollerContentFocus : MonoBehaviour
{
	[Header("Элементы")]
	public List<ButtonMouseClick> elements;

	private ButtonMouseClick objectTarget;

	private RectTransform content;

	private float contentHeight;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
