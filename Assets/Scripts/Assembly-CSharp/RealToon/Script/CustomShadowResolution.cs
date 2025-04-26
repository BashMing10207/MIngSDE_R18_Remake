using UnityEngine;

namespace RealToon.Script
{
	[AddComponentMenu("RealToon/Tools/Custom Shadow Resolution")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Light))]
	public class CustomShadowResolution : MonoBehaviour
	{
		[Header("For RealToon Built-In RP Only")]
		[Space(10f)]
		[Header("Note: Higher Shadow Resolution = More GPU RAM Usage.")]
		[Header("Custom Shadow Resolution V1.0.0")]
		[Tooltip("Input value")]
		public int Value;

		[Tooltip("Final Resolution (Value * 2)")]
		public int FinalResolution;

		[Space(10f)]
		[Tooltip("Reset to default value")]
		public bool Reset;

		private void Update()
		{
		}
	}
}
