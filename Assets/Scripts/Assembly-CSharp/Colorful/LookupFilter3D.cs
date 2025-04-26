using System;
using UnityEngine;

namespace Colorful
{
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/lookup-filter-3d.html")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Colorful FX/Color Correction/Lookup Filter 3D")]
	public class LookupFilter3D : MonoBehaviour
	{
		[Tooltip("The lookup texture to apply. Read the documentation to learn how to create one.")]
		public Texture2D LookupTexture;

		[Tooltip("Blending factor.")]
		[Range(0f, 1f)]
		public float Amount;

		[Tooltip("The effect will automatically detect the correct shader to use for the device but you can force it to only use the compatibility shader.")]
		public bool ForceCompatibility;

		protected Texture3D m_Lut3D;

		protected string m_BaseTextureName;

		protected bool m_Use2DLut;

		public Shader Shader2D;

		public Shader Shader3D;

		protected Material m_Material2D;

		protected Material m_Material3D;

		public Material Material => null;

		[Obsolete]
		protected virtual void Start()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void Reset()
		{
		}

		protected void SetIdentityLut()
		{
		}

		public bool ValidDimensions(Texture2D tex2D)
		{
			return false;
		}

		protected void ConvertBaseTexture()
		{
		}

		public void Apply(Texture source, RenderTexture destination)
		{
		}

		protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		protected virtual void RenderLut2D(RenderTexture source, RenderTexture destination)
		{
		}

		protected virtual void RenderLut3D(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
