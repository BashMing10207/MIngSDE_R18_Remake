using RootMotion.FinalIK;
using UnityEngine;

public class Location11_BlackMita : MonoBehaviour
{
	[SerializeField]
	private Trigger_DistanceCamera handHorror;

	[SerializeField]
	private LookAtIK ikHead;

	[SerializeField]
	private LookAtIK ikBody;

	[SerializeField]
	private LayerMask layerCastWall;

	private Animator anim;

	private IK_LegRotateBody bodyRotateLeg;

	private float timeRotateBody;

	private float timeStart;

	private bool playSearch;

	private bool sit;

	private bool searching;

	private float timeSearch;

	private float timeSearchStart;

	private float timeStep;

	private float noiseCameraHandHorror;

	private float datamoshCameraHandHorror;

	private bool dtm;

	private float timeTargetHead;

	private float timeTargetBody;

	private Vector3 targetHeadPosition;

	private Vector3 targetBodyPosition;

	[Header("Данные анимаций")]
	[SerializeField]
	private AnimationClip[] animations;

	private float timeStartSit;

	private float timeStopSit;

	private float timeSit;

	private int dialogueSitInt;

	[Header("Ноет")]
	[SerializeField]
	private GameObject[] dialoguesSit;

	private bool fs;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void RotateBody()
	{
	}

	public void Stay()
	{
	}

	private void PlaySearch()
	{
	}

	private void StartSit()
	{
	}

	public void DialogueCryStop()
	{
	}

	public void SitOnBedReady()
	{
	}

	public void HandStart()
	{
	}

	public void HandStop()
	{
	}
}
