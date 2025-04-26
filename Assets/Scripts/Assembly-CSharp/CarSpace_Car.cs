using NaughtyAttributes;
using UnityEngine;
using UnityEngine.UI;

public class CarSpace_Car : MonoBehaviour
{
	[SerializeField]
	private CarSpace_Main main;

	public float speedMax;

	public float speedRotate;

	[HideInInspector]
	public float speedVelocity;

	private RaycastHit hit;

	private Rigidbody physicCar;

	[SerializeField]
	[Header("Физика")]
	private LayerMask layerRoad;

	[SerializeField]
	private LayerMask layerRoadWheel;

	private Vector3 positionWheelL;

	private Vector3 positionWheelR;

	private Vector3 positionWheelLB;

	private Vector3 positionWheelRB;

	private Vector3 positionLastNormal;

	private Vector3 rotationHandWheel;

	private float sitSidePerson;

	[Header("Машина")]
	[SerializeField]
	private Transform magnetUp;

	public Transform car;

	[SerializeField]
	private Transform carVisual;

	[SerializeField]
	private Transform wheelL;

	[SerializeField]
	private Transform wheelR;

	[SerializeField]
	private Transform wheelLB;

	[SerializeField]
	private Transform wheelRB;

	[SerializeField]
	private Transform handWheel;

	[SerializeField]
	private float wheelRadiusL;

	[SerializeField]
	private float wheelRadiusR;

	[SerializeField]
	private float wheelRadiusLB;

	[SerializeField]
	private float wheelRadiusRB;

	[SerializeField]
	private ParticleSystem[] particleNitro;

	[SerializeField]
	private Text textSpeed;

	[SerializeField]
	private Image amountSpeed;

	[SerializeField]
	private Animator animatorPerson;

	[HideInInspector]
	public bool onlyForward;

	private float rotateWheel;

	private int timeForward;

	private int timeRotate;

	private float speedForward;

	private float rotateNow;

	private float forceNitro;

	[HideInInspector]
	public float maxSound;

	[Header("Звуки")]
	[SerializeField]
	private AudioSource audioNitro;

	[SerializeField]
	private AudioSource audioSpeed;

	[SerializeField]
	private AudioSource audioIdle;

	[HideInInspector]
	public bool destroyed;

	private GameObject objectExplode;

	[SerializeField]
	[Header("Разрушение")]
	private GameObject[] objectsDeactive;

	[SerializeField]
	private GameObject prefabExplode;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public void Right(bool x)
	{
	}

	public void Forward(bool x)
	{
	}

	public bool Nitro()
	{
		return false;
	}

	private void WheelFloor(Transform _wheel, Vector3 _position, float _radius)
	{
	}

	public void MagnetRestart()
	{
	}

	public void SetVelocity(Vector3 _velocity)
	{
	}

	public void UpdateVisualCar()
	{
	}

	public void StopSpeed()
	{
	}

	[Button("Взорвать", EButtonEnableMode.Always)]
	public void Explode()
	{
	}

	public void RestartCar()
	{
	}

	public void FullDestroy()
	{
	}
}
