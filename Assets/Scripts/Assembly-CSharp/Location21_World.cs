using System;
using UnityEngine;
using UnityEngine.Events;

public class Location21_World : MonoBehaviour
{
	[Serializable]
	public class LocationTimeDay
	{
		public Light sun;

		[ColorUsage(false)]
		public Color colorMorning;

		[ColorUsage(false)]
		public Color colorDay;

		[ColorUsage(false)]
		public Color colorEvening;

		[ColorUsage(false)]
		public Color colorNight;

		[ColorUsage(false)]
		public Color colorSunMorning;

		[ColorUsage(false)]
		public Color colorSunDay;

		[ColorUsage(false)]
		public Color colorSunEvening;

		[ColorUsage(false)]
		public Color colorSunNight;

		public LocationTimeDayPointAddon[] lightPointsAddon;

		public LocationTimeDayParticleLight[] particleSunLight;

		public LocationTimeDayLightMaterial[] materials;

		public LocationTimeDayLamp[] lamps;

		public AnimationCurve particlesDustRate;

		public ParticleSystem[] particlesDust;

		public Color colorSunParticleMorning;

		public Color colorSunParticleDay;

		public Color colorSunParticleEvening;

		public Color colorSunParticleNight;

		[Header("Outline")]
		public Material_ColorVariables outlineMita;

		public Material materialLine;

		[ColorUsage(false)]
		public Color outlineMorning;

		[ColorUsage(false)]
		public Color outlineDay;

		[ColorUsage(false)]
		public Color outlineEvening;

		[ColorUsage(false)]
		public Color outlineNight;

		[ColorUsage(false)]
		public Color outlinePersonagesMorning;

		[ColorUsage(false)]
		public Color outlinePersonagesDay;

		[ColorUsage(false)]
		public Color outlinePersonagesEvening;

		[ColorUsage(false)]
		public Color outlinePersonagesNight;
	}

	[Serializable]
	public class LocationTimeDayPointAddon
	{
		public Light light;

		[ColorUsage(false)]
		public Color colorMorning;

		[ColorUsage(false)]
		public Color colorDay;

		[ColorUsage(false)]
		public Color colorEvening;

		[ColorUsage(false)]
		public Color colorNight;
	}

	[Serializable]
	public class LocationTimeDayParticleLight
	{
		public ParticleSystem particle;

		public Vector3 positionStart;

		public Vector3 positionFinish;

		public Vector3 particleVelocityStart;

		public Vector3 particleVelocityFinish;
	}

	[Serializable]
	public class LocationTimeDayLightMaterial
	{
		public Renderer rend;

		public int indexMaterial;

		[ColorUsage(false, true)]
		public Color colorMorning;

		[ColorUsage(false, true)]
		public Color colorDay;

		[ColorUsage(false, true)]
		public Color colorEvening;

		[ColorUsage(false, true)]
		public Color colorNight;
	}

	[Serializable]
	public class LocationTimeDayLamp
	{
		public GameObject lampObject;

		public Renderer[] renderers;

		public int[] materialRenderers;

		[ColorUsage(false, true)]
		public Color[] colorsActive;

		[ColorUsage(false, true)]
		public Color[] colorsDeactive;
	}

	[Header("День")]
	public int dayNow;

	private int timeUpdate;

	private bool lampActive;

	private Material_ColorVariables outlinePlayer;

	[Header("Время дня")]
	[SerializeField]
	[Range(0f, 1f)]
	private float day;

	[SerializeField]
	private LocationTimeDay timeDay;

	private bool questIconWasActive;

	[Header("Интерактив с Митой")]
	[SerializeField]
	private Transform mitaTransform;

	[SerializeField]
	private ObjectInteractive triggerInetaractiveMita;

	[SerializeField]
	private Location21_IconQuest questIcon;

	private AudioClip musicNeed;

	[SerializeField]
	[Header("Музыка")]
	private bool musicActive;

	[SerializeField]
	private AudioSource audioMusic;

	[SerializeField]
	private AudioClip musicMorning;

	[SerializeField]
	private AudioClip musicDay;

	[SerializeField]
	private AudioClip musicEvening;

	[SerializeField]
	private AudioClip musicNight;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void UpdateTimeDay()
	{
	}

	public void NewInteractive(UnityEvent _event, bool _hideQuest)
	{
	}

	public void InteractiveAgain()
	{
	}

	private void ClickInteractive()
	{
	}

	private void ClickInteractiveHideQuest()
	{
	}

	public int DialogueRandomArray(GameObject[] _dialogues)
	{
		return 0;
	}

	public int DialogueRandomArrayDestroyUnnecessary(GameObject[] _dialogues)
	{
		return 0;
	}

	public void MusicActive(bool x)
	{
	}

	public void MusicChange(AudioClip _musicClip)
	{
	}

	public void MusicDefault()
	{
	}

	public void SetTimeDay(float x)
	{
	}
}
