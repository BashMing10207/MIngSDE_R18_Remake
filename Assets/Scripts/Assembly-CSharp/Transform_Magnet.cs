using UnityEngine;

[AddComponentMenu("Functions/Transform/Magnet")]
public class Transform_Magnet : MonoBehaviour
{
	[SerializeField]
	private bool active;

	[Header("Объекты")]
	[SerializeField]
	private string magnetPlayer;

	[SerializeField]
	private Transform transformTarget;

	[SerializeField]
	private Transform transformMagnet;

	[SerializeField]
	private bool playerRoot;

	[Header("Позиции")]
	[SerializeField]
	private float speed;

	[SerializeField]
	private bool local;

	[SerializeField]
	private bool localMagnet;

	public Vector3 position;

	public Vector3 rotation;

	private float noise;

	[SerializeField]
	[Header("Шум")]
	private bool noiseActive;

	[SerializeField]
	private float noiseTimeMin;

	[SerializeField]
	private float noiseTimeMax;

	private float noiseTimeNow;

	[SerializeField]
	private float noiseMin;

	[SerializeField]
	private float noiseMax;

	private int sharply;

	private bool timeParent;

	private Vector3 positionOrigin;

	private Quaternion rotationOrigin;

	private Transform reMagnetAndParent;

	private bool fs;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	public void PassComponent(Transform_Magnet obj)
	{
	}

	public void CopyComponent(Transform_Magnet obj)
	{
	}

	public void ReTarget(Transform x)
	{
	}

	public void ReMagnetAndParent(Transform x)
	{
	}

	public void ReMagnetAndParentSharply(Transform x)
	{
	}

	public void ReMagnerAndParentPlayerRI()
	{
	}

	public void ReMagnerAndParentPlayerLI()
	{
	}

	public void ReMagnerAndParentPlayerRI2()
	{
	}

	public void ReMagnerAndParentPlayerLI2()
	{
	}

	public void Activation(bool x)
	{
	}

	public void ActivationParent()
	{
	}

	public void SharplyPosition()
	{
	}

	public void TeleportAndOff(Transform _target)
	{
	}

	public void TeleportParentAndOff(Transform _target)
	{
	}

	[ContextMenu("Активировать и мгновенно оказаться на позиции")]
	public void ActivationSharplyParent()
	{
	}

	public void ReSpeed(float x)
	{
	}

	public void AnimatorReMagnetAndParent(Transform x)
	{
	}

	public void FinishSetParent(Transform _parent)
	{
	}
}
