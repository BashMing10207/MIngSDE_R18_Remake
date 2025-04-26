using UnityEngine;

public class Location8_TV : MonoBehaviour
{
	[SerializeField]
	private Texture2D[] pictures;

	[SerializeField]
	private Light lg;

	[SerializeField]
	private AudioSource sound;

	[SerializeField]
	private GameObject refrection;

	[Header("Материалы")]
	[SerializeField]
	private Material materialOff;

	[SerializeField]
	private Material materialCat;

	[SerializeField]
	private Material materialInterface;

	[SerializeField]
	private MeshRenderer rendLight;

	private bool TVWork;

	private MeshRenderer rend;

	private int indexPicture;

	private float timeResetPicture;

	private bool showInterface;

	private float timeRandomOffset;

	private bool randomOffset;

	private bool fs;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void MakeRed(bool _x)
	{
	}

	public void TvActive(bool _x)
	{
	}

	public void MaterialShowInterface()
	{
	}

	public void MaterialShowCat()
	{
	}

	public void RandomOffset(bool x)
	{
	}
}
