using UnityEngine;

namespace RealToon.Script
{
	[AddComponentMenu("RealToon/Tools/SmoothObjectNormal - Helper")]
	[ExecuteInEditMode]
	public class SmoothObjectNormalHelper : MonoBehaviour
	{
		[Tooltip("A material that uses 'RealToon - Smooth Object Normal' feature.")]
		[Space(10f)]
		[Header("[RealToon - Smooth Object Normal - Helper]")]
		[Header("Note: Put the Object Helper inside the root bone or the root object and set it's XYZ position to 0.")]
		[Space(25f)]
		public Material Material;

		[Tooltip("An object to help adjust the smoothed/ignored object normal.")]
		public Transform ObjectHelper;

		[Tooltip("The object to followed by the Object Helper")]
		public Transform TheObjectToFollow;

		[Space(10f)]
		[Tooltip("Adjust the overall offset of the Smooth Object normal to follow the Object Helper.")]
		public float Offset;

		[Tooltip("Additional position adjustment for Object Helper.")]
		[Space(10f)]
		public Vector3 AdditionalPositionAdjustment;

		private void LateUpdate()
		{
		}
	}
}
