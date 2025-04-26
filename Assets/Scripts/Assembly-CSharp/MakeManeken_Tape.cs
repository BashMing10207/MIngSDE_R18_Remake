using MagicaCloth;
using UnityEngine;

public class MakeManeken_Tape : MonoBehaviour
{
	[SerializeField]
	private MakeManeken_Main main;

	[SerializeField]
	private Renderer rend;

	private AudioSource audioSource;

	[Header("Звуки")]
	[SerializeField]
	private AudioClip[] soundsTake;

	[SerializeField]
	private AudioClip[] soundsDrop;

	private bool hold;

	private bool firstTake;

	private float alphaDestroy;

	private MagicaBoneCloth mb;

	private bool positionFinish;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void TakeTape()
	{
	}

	public void DropTape()
	{
	}

	public void DestroySmooth()
	{
	}
}
