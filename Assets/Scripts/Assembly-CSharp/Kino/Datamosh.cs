using UnityEngine;

namespace Kino
{
	[RequireComponent(typeof(Camera))]
	public class Datamosh : MonoBehaviour
	{
		[Tooltip("Size of compression macroblock.")]
		[SerializeField]
		private int _blockSize;

		[SerializeField]
		[Tooltip("Entropy coefficient. The larger value makes the stronger noise.")]
		[Range(0f, 1f)]
		private float _entropy;

		[SerializeField]
		[Range(0.5f, 4f)]
		[Tooltip("Contrast of stripe-shaped noise.")]
		private float _noiseContrast;

		[Tooltip("Scale factor for velocity vectors.")]
		[SerializeField]
		[Range(0f, 2f)]
		private float _velocityScale;

		[SerializeField]
		[Range(0f, 2f)]
		[Tooltip("Amount of random displacement.")]
		private float _diffusion;

		[SerializeField]
		private Shader _shader;

		private Material _material;

		private RenderTexture _workBuffer;

		private RenderTexture _dispBuffer;

		private int _sequence;

		private int _lastFrame;

		public int blockSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float entropy
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float noiseContrast
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float velocityScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float diffusion
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public void Glitch()
		{
		}

		public void Reset()
		{
		}

		private RenderTexture NewWorkBuffer(RenderTexture source)
		{
			return null;
		}

		private RenderTexture NewDispBuffer(RenderTexture source)
		{
			return null;
		}

		private void ReleaseBuffer(RenderTexture buffer)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
