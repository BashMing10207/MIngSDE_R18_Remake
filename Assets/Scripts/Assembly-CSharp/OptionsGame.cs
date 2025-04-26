using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.Rendering.PostProcessing;

public class OptionsGame : MonoBehaviour
{
	public Font fontPixelRussian;

	public Font fontRussian;

	public Font fontJapaneseChinese;

	public Font fontKorean;

	public Font fontThai;

	public Font fontArabic;

	public Font fontOther;

	public List<AsyncOperation> unloadScenes;

	public List<AddonSettingObject> eventsAddonSettings;

	[Header("Глобальные установки")]
	public Texture2D[] texturesShadowStyle;

	private Texture2D textureCursorStandart;

	[Header("Курсор")]
	public Texture2D textureCursorClassic;

	public Texture2D textureCursorHalloween;

	public Texture2D textureCursorChristmas;

	[Header("Предустановки")]
	public AnimationCurve[] animationCurves;

	private int indexAudio;

	[SerializeField]
	[Header("Звуки")]
	private AudioMixer audioMixerVoice;

	[SerializeField]
	private AudioMixerGroup audioMixerGroupVoice;

	[SerializeField]
	private AudioSource[] audios;

	[SerializeField]
	private AudioClip[] sounds;

	public static float holdVertical;

	public static float holdHorizontal;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void LoadGameSettings()
	{
	}

	private void Start()
	{
	}

	public void ReloadOptions()
	{
	}

	public void ReloadLanguage()
	{
	}

	public void AddResetSetting(UnityEvent _eventReset, GameObject _object)
	{
	}

	private void UpdateCameraPostProcessing(PostProcessVolume _ppv)
	{
	}

	[ContextMenu("Установить глобальные шейдеры")]
	public void ShaderSet()
	{
	}

	private void Holidays()
	{
	}

	private void DirectX()
	{
	}

	public void ChangeCursorClassic(string _holidays)
	{
	}

	public void ReturnCursor()
	{
	}

	public void AudioPlay(int _indexSound, float _volume, float _pitch)
	{
	}
}
