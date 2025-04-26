using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UI_LookOnCamera : MonoBehaviour
{
	private float colorAlpha;

	[Header("Изображения")]
	public Image[] images;

	public Text[] textes;

	public float speed;

	private Transform cameraT;

	[Header("3D")]
	public float size;

	public float distanceSize;

	private bool destroyActive;

	private bool hideMehotd;

	[Header("Видимость")]
	public float distanceHide;

	public bool hide;

	public bool hideDistance;

	public UnityEvent eventDestroy;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public void SmoothDestroy()
	{
	}

	public void Hide(bool _hide)
	{
	}
}
