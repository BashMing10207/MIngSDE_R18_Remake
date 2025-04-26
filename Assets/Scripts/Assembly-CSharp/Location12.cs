using MagicaCloth;
using UnityEngine;
using UnityEngine.Events;

public class Location12 : MonoBehaviour
{
	private Transform playerT;

	private float timeCanTP;

	private bool inBedroom;

	[SerializeField]
	[Header("Телепорт к кухне")]
	private UnityEvent eventTpIfBedroom;

	private Transform creepyMitaT;

	[SerializeField]
	[Header("Убийца Мита")]
	private MitaPerson scrMitaCreepy;

	[SerializeField]
	private UnityEvent eventNearMita;

	[SerializeField]
	private ObjectAnimationPlayer animationPlayerKill;

	[SerializeField]
	private UnityEvent eventResetHunter;

	[SerializeField]
	private Player_Teleport scrPlayerTeleportReset;

	[SerializeField]
	private MagicaBoneCloth[] clothes;

	[Header("Уродливая Мита")]
	[SerializeField]
	private GameObject creepyFreak;

	[SerializeField]
	private LayerMask layerWallFreak;

	[SerializeField]
	private UnityEvent eventTPFreakStart;

	private int questCount;

	[SerializeField]
	[Header("Вопросы Мите")]
	private UnityEvent eventQuest1;

	[SerializeField]
	private UnityEvent eventQuest2;

	[SerializeField]
	private UnityEvent eventQuest3;

	[SerializeField]
	private UnityEvent eventQuestsFinish;

	[SerializeField]
	private UnityEvent eventQuestsPreFinish;

	[Header("Пауки")]
	[SerializeField]
	private Animator[] spiderAnimators;

	private Vector2 offSetNoTexture;

	private float speedOffsetNotTexture;

	private bool moveShaderNotTexture;

	[SerializeField]
	[Header("Шейдер")]
	private Material materialNotTexture;

	private float glitchTimeTp;

	private int glitchIntTimeTp;

	private Transform targetTP;

	private Vector3 glitchWasPosition;

	private Quaternion glitchWasRotation;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public void CanTP()
	{
	}

	public void PlayerInBeroom()
	{
	}

	public void FreakTP()
	{
	}

	public void Quest()
	{
	}

	public void QuestFinish()
	{
	}

	public void CreepyMitaStayAttack()
	{
	}

	public void CreepyMitaAttack()
	{
	}

	public void ResetHunter()
	{
	}

	public void StopHunter()
	{
	}

	public void TeleportGlitchPosition(Transform _positionTP)
	{
	}

	private void TeleportGlitch(float _timeTP)
	{
	}

	private void TeleportGlitchStop()
	{
	}

	private void ResetAttackPosition(Vector3 _position, Quaternion _rotation)
	{
	}

	public void SpiderRandomPut()
	{
	}
}
