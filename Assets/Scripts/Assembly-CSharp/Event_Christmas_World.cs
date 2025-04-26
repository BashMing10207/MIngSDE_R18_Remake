using UnityEngine;

public class Event_Christmas_World : MonoBehaviour
{
	[Header("Освещение")]
	[SerializeField]
	private bool colorLightUse;

	[SerializeField]
	private Color colorLight;

	[Header("Освещение для World")]
	[SerializeField]
	private Light_LightingColor componentLighting;

	[SerializeField]
	private Color[] colorsReLighting;

	[Header("Солнце")]
	[SerializeField]
	private bool sunColorUse;

	[SerializeField]
	private Light sun;

	[SerializeField]
	private Color sunColor;

	[Header("Частицы")]
	[SerializeField]
	private ParticleSystem[] particlesSunRays;

	private void Start()
	{
	}
}
