using UnityEngine;

public class TamagotchiGame_Chip : MonoBehaviour
{
	public TamagotchiGame_Chip_Case[] cases;

	public GameObject plitaHorizontal;

	public GameObject plitaVertical;

	public GameObject plitaAngle1;

	public GameObject plitaAngle2;

	public GameObject plitaAngle3;

	public GameObject plitaAngle4;

	public GameObject pointStart;

	public GameObject pointFinish;

	public AnimationCurve animationPlitaInCase;

	public AnimationCurveTransform[] objectsDestroy;

	public AnimationCurve animationDestroyUp;

	public Tamagotchi_AddMoney moneyAdd;

	public int energy;

	public LayerMask plita;

	[Header("Звуки")]
	public AudioClip soundPlitaPut;

	public AudioSource plitaUse;

	public AudioClip[] soundsPlitaUse;

	public AudioSource audioPlitaChange;

	public AudioClip[] soundsPlitaChange;

	private GameObject plitaChange;

	private RaycastHit hit;

	private int timeCheckReady;

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public void Restart()
	{
	}

	public void ChangePlita(GameObject _plita)
	{
	}

	public void ChangeCase(GameObject _case)
	{
	}

	public GameObject CheckCast(Vector3 _positionCheck)
	{
		return null;
	}
}
