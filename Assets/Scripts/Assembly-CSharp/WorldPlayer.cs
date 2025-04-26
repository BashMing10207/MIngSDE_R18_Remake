using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class WorldPlayer : MonoBehaviour
{
	[SerializeField]
	private bool ringOnPlayer;

	[Range(0f, 2f)]
	[SerializeField]
	private int scarOnPlayer;

	[Range(0f, 2f)]
	[SerializeField]
	private int timeFace;

	[HideInInspector]
	public float speedLerpFlashLight;

	[Header("Фонарик")]
	public float flashLightIntensity;

	public float flashLightSpotAngle;

	public float flashLightRange;

	public float flashLightRangeSphere;

	public float flashLightIntensitySphere;

	private Camera cameraPlayer;

	private float timeAnimationFOV;

	private float needFOV;

	private float wasFOV;

	private Color cameraColorWas;

	private Color cameraColorNeed;

	private float cameraColorTime;

	private PostProcessVolume postProcessing;

	private bool playerResetZoom;

	[SerializeField]
	[Header("Камера")]
	private AnimationCurve cameraAnimationTarget;

	[SerializeField]
	private AnimationCurve cameraAnimationFOV;

	[SerializeField]
	private float speedAnimationFOV;

	[SerializeField]
	private Color[] colorCamera;

	[SerializeField]
	private float speedColorCamera;

	private float timeColorLine;

	private Color colorLineNeed;

	private Color colorLine;

	private Color colorLineWas;

	private Material materialLine;

	[Header("Линии мира")]
	[SerializeField]
	private float speed;

	[SerializeField]
	private int colorStart;

	[Header("Игрок")]
	[ColorUsage(false)]
	[SerializeField]
	private Color[] colorsPlayer;

	private GameController scrgc;

	private PlayerMove scrpm;

	public void StartComponent()
	{
	}

	private void Update()
	{
	}

	public void LineColor(int _indexColor)
	{
	}

	public void LineColorFast(int _indexColor)
	{
	}

	public void AddKeyItem(GameObject _item)
	{
	}

	public void RemoveKeyItem(GameObject _item)
	{
	}

	public void TakeHandItem(GameObject _item)
	{
	}

	public void RemoveHandItem()
	{
	}

	public void RechangeCameraAnimationFOV(AnimationCurve _cameraAnimationTarget, AnimationCurve _cameraAnimationFOV, float _speedAnimationFOV)
	{
	}

	public void CameraSwitchTypeOutline(bool _sobel)
	{
	}

	public void UpdateCamera()
	{
	}

	public void CameraSharpen(float _x)
	{
	}

	public void CameraGlitch(bool _x)
	{
	}

	public void CameraGausianBlur(bool _x)
	{
	}

	public void CameraVignetteActive(bool _x)
	{
	}

	public void CameraNoise(float _intensity)
	{
	}

	public void CameraFish(bool _x)
	{
	}

	public void CameraDatamosh(bool x)
	{
	}

	public void CameraAnimationFOV(float x)
	{
	}

	public void CameraFOVLerpReset()
	{
	}

	public void CameraFOVSharplyReset()
	{
	}

	public void CameraFOVSharply(float x)
	{
	}

	public void CameraClickTelevision()
	{
	}

	public void CameraNegative(bool x)
	{
	}

	public void CameraFar(float x)
	{
	}

	public void ScreenBlackTime(float _time)
	{
	}

	public void PlayerAnimationCameraStop()
	{
	}

	public void PlayerBlinkPlay(bool x)
	{
	}

	public void PlayerFullHide(bool x)
	{
	}

	public void HideBodyPlayer(bool x)
	{
	}

	public void HideCrosshair(bool x)
	{
	}

	public void HideCrosshairOnly(bool x)
	{
	}

	public void PlayerAnimationStop()
	{
	}

	public void PlayerAnimationFastStop()
	{
	}

	public void PlayerCameraNoise(float _x)
	{
	}

	public void PlayerDontMove(bool x)
	{
	}

	public void PlayerDontMouseMove(bool x)
	{
	}

	public void RingActive(bool x)
	{
	}

	public void Scar(int x)
	{
	}

	public void TimeFace(int x)
	{
	}

	public void PlayerNeedSit(bool x)
	{
	}

	public void PlayerNeedRun(bool x)
	{
	}

	public void ShowMouse(bool x)
	{
	}

	public void CameraFastOtherTarget(Transform target)
	{
	}

	public void CameraFastOtherTargetStop()
	{
	}

	public void CameraLerpOtherTarget(Transform target)
	{
	}

	public void CameraLerpOtherTargetStop()
	{
	}

	public void CameraLerpColor(int x)
	{
	}

	public void PlayerColorLine(int x)
	{
	}

	public void PlayerDontCast(bool x)
	{
	}

	public void PlayerShowShadow(bool x)
	{
	}

	public void PlayerPyjama(bool x)
	{
	}

	public void PlayerSafeFloorDeactive()
	{
	}

	public void PlayerReset()
	{
	}

	public void FlashLightRechange(FlashLight_World _component)
	{
	}

	public void AudioBrain(float _intensity)
	{
	}
}
