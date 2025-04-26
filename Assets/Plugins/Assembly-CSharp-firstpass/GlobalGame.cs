using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;

public class GlobalGame
{
	public static string dataFiles;

	public static string LoadingLevel;

	public static float timeScreenLoading;

	public static bool optionGameLoad;

	public static bool playWorld;

	public static bool play;

	public static PointerEventData eventData;

	public static Font fontUse;

	public static Font fontPixelUse;

	public static string Language;

	public static string LanguageVoice;

	public static float VolumeGame;

	public static float volumeVoice;

	public static AudioMixerGroup audioMixerGroupVoice;

	public static int shadow;

	public static int qualityWorld;

	public static float mouseSpeed;

	public static bool mouseSpeedLerp;

	public static int modeSub;

	public static bool hintScreen;

	public static bool headMove;

	public static int voicePlayer;

	public static bool handDoor;

	public static float playerFov;

	public static bool oldDirect;

	public static bool dialogueSmile;

	public static int shadowStyle;

	public static bool censor;

	public static bool closePhotomode;

	public static bool trailer;

	public static bool hideDialogue;

	public static string namePlayer;

	public static string nameLoadedScene;

	public static int levelLoad;

	public static string clothMita;

	public static int clothVariantMita;

	public static bool gameEndingMenu;

	public static Texture2D screenCapture;

	public static bool timeGameplay;

	public static bool voicePlayerX;

	public static float timeS;

	public static int timeM;

	public static int timeH;

	public static Texture2D textureMadMitaBody;

	public static Texture2D textureMadMitaCloth;

	public static Texture2D textureMadMitaFace;

	public static Texture2D textureMadMitaHairs;

	public static Transform safeFloor;

	public static bool showHintPeacemode;

	public static bool canSkipDialogue;

	public static bool halloween;

	public static bool christmas;

	public static float GetMouseX()
	{
		return 0f;
	}

	public static float GetMouseY()
	{
		return 0f;
	}

	public static float GetMouseRotationX()
	{
		return 0f;
	}

	public static float GetMouseRotationY()
	{
		return 0f;
	}

	public static float GetMouseSimpleX()
	{
		return 0f;
	}

	public static float GetMouseSimpleY()
	{
		return 0f;
	}
}
