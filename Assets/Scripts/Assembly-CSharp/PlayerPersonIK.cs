using RootMotion.FinalIK;
using UnityEngine;

public class PlayerPersonIK : MonoBehaviour
{
	private PlayerMove scrpm;

	private GrounderFBBIK scrGroundFBBIK;

	[HideInInspector]
	public FullBodyBipedIK scrfbbik;

	private RaycastHit hit;

	[SerializeField]
	[Header("Transforms")]
	private Transform headPlayer;

	[SerializeField]
	private Transform pocketRight;

	[SerializeField]
	private Transform pocketLeft;

	[HideInInspector]
	public bool freeRightHand;

	[Header("Hands player")]
	public Transform handRightIK;

	public Transform handLeftIK;

	[SerializeField]
	private GenericPoser armRightPoser;

	[SerializeField]
	private GenericPoser armLeftPoser;

	public Transform rightElbowPlayer;

	public Transform leftElbowPlayer;

	public Transform handRightItem;

	public Transform handLeftItem;

	public Transform rightItemFixPosition;

	public Transform leftItemFixPosition;

	[SerializeField]
	private Transform handRightItem2;

	[SerializeField]
	private Transform handLeftItem2;

	public Transform rightItemFixPosition2;

	public Transform leftItemFixPosition2;

	[SerializeField]
	private Transform rightWristFixPosition;

	[SerializeField]
	private Transform leftWristFixPosition;

	[Header("Hands animation")]
	[SerializeField]
	private Transform armRightHand;

	[SerializeField]
	private Transform armLeftHand;

	[SerializeField]
	private Transform rightElbowAnimationArms;

	[SerializeField]
	private Transform leftElbowAnimationArms;

	private bool animationArms;

	private float animationIKWeightRightHandTime;

	private float animationIKWeightLeftHandTime;

	[SerializeField]
	[Header("Animation")]
	private AnimationCurve animationIKWeight;

	[SerializeField]
	private AnimationCurve animationIKFingers;

	private float timeAnimationIKFingers;

	[SerializeField]
	private AnimationCurve animationIKPocketTake;

	private float timeAnimationIKPocketTake;

	private float timeAnimationIKMoveTowardsRight;

	private float timeAnimationIKMoveTowardsLeft;

	private Vector3 animationIKMoveTowardsRightPos;

	private Vector3 animationIKMoveTowardsLeftPos;

	private Quaternion animationIKMoveTowardsRightRot;

	private Quaternion animationIKMoveTowardsLeftRot;

	private IK_HandTrigger handTrigger;

	private GameObject itemTakePocket;

	private float timeTakePocket;

	private GameObject item;

	private GameObject itemInHand;

	[HideInInspector]
	public bool silentTake;

	[HideInInspector]
	public GameObject objectInHand;

	[HideInInspector]
	public bool itemDown;

	private float handsrandomTime;

	private Vector3 handsPositionRandom;

	private Vector3 handsRotationRandom;

	private Vector3 handsPositionRandomSave;

	private Vector3 handsRotationRandomSave;

	[HideInInspector]
	public Vector3 handsInertia;

	private bool otherControl;

	private AudioSource audioSource;

	[Header("Звуки")]
	[SerializeField]
	private AudioClip[] soundsTakeItem;

	[SerializeField]
	private AudioClip[] soundsMoveItem;

	private bool doorHold;

	private float intensityDoor;

	[SerializeField]
	[Header("Двери")]
	private LayerMask layerDoor;

	[SerializeField]
	private Transform cameraForward;

	[SerializeField]
	private float dist;

	[SerializeField]
	private PlayerHandIK_Prefab scrHandRightDoor;

	[SerializeField]
	private PlayerHandIK_Prefab scrHandLeftDoor;

	private bool rightHandUse;

	private bool leftHandUse;

	private bool needHideItem;

	private bool weightLimbRightOff;

	private bool weightLimbLeftOff;

	private Vector3 positionRightHand;

	private Quaternion rotationRightHand;

	private Vector3 positionLeftHand;

	private Quaternion rotationLeftHand;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void AnimationMoveTowardsHand(bool _rightHand)
	{
	}

	private void AnimationMoveTowardsHandStop()
	{
	}

	public void UpdateItemInHand()
	{
	}

	public void IkZero()
	{
	}

	private void HandPoseSmoothApply(PlayerHandIK_Prefab _pose, bool _positionApply, bool _rotationApply, bool _hold)
	{
	}

	public void HandPoseSharplyApply(PlayerHandIK_Prefab _pose, bool _limbHand, bool _hold)
	{
	}

	public void TakeItem(GameObject _item)
	{
	}

	public void RemoveItem()
	{
	}

	public void TakeItemInHand()
	{
	}

	public void TakeItemPocket(PlayerHandIK_Prefab _hand, GameObject _object)
	{
	}

	private void TakeItemPocketEnd()
	{
	}

	public void AnimationHandsFace(bool x)
	{
	}

	public void ActiveOtherControl(bool x)
	{
	}
}
