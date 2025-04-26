using System.Collections.Generic;
using EPOOutline;
using UnityEngine;

public class Event_Halloween_World : MonoBehaviour
{
	[SerializeField]
	private GameObject world;

	[Header("Освещение")]
	[SerializeField]
	private Light sun;

	[SerializeField]
	private Color colorBackground;

	[SerializeField]
	private Color[] colorsWorldLightings;

	[SerializeField]
	private Color[] colorsPlayer;

	[SerializeField]
	private GameObject[] destroyObjects;

	[SerializeField]
	private ParticleSystem[] particlesLightWindow;

	[SerializeField]
	private Material_EmissionObjects componentEmissionLighting;

	[SerializeField]
	private Material_EmissionObjectsObject[] emissionLighting;

	[Space(20f)]
	[SerializeField]
	private Material_ColorVariables[] materialsColorVariables;

	[SerializeField]
	private Color[] materialsColorVariablesColorChange;

	public static bool pumpkinReady;

	public static bool pumpkinHeadHide;

	private int countPumpkinClick;

	[Header("Квест")]
	public GameObject pumpkinClickHideHead;

	public Transform[] headMita;

	public GameObject[] headRend;

	public GameObject pumpkinMita;

	public GameObject pumpkinFullMita;

	public Outlinable[] outlinePumpkinAdd;

	[HideInInspector]
	public List<GameObject> pumpkinNow;

	private void Start()
	{
	}

	private int GetSubmeshCount(Renderer renderer)
	{
		return 0;
	}

	public void PumpkinClick()
	{
	}

	public void PumpkinHideHead()
	{
	}
}
