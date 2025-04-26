using NaughtyAttributes;
using UnityEngine;

public class ObjectItem : MonoBehaviour
{
	[ShowAssetPreview(64, 64)]
	public Sprite icon;

	public PlayerHandIK_Prefab mainHand;

	public PlayerHandIK_Prefab secondaryHand;

	public Vector3 positionFace;

	public Vector3 rotationFace;

	public AudioClip soundTake;

	public AudioClip soundRemove;

	[Header("Предмет в руке")]
	public GameObject itemInHand;

	public Vector3 positionItemInHand;

	public Quaternion rotationItemInHand;

	public float shareUp;

	public float shareDown;

	public float minDistanceCastHide;

	public float castBackDistance;

	public float castBack;

	[Header("Угол локтя")]
	public Vector3 positionRightElbow;

	public Vector3 positionLeftElbow;
}
