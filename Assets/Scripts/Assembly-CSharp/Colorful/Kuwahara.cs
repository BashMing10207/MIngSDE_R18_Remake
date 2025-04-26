using UnityEngine;

namespace Colorful
{
	[AddComponentMenu("Colorful FX/Artistic Effects/Kuwahara")]
	[ExecuteInEditMode]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/artistic-effects/kuwahara.html")]
	public class Kuwahara : BaseEffect
	{
		[Tooltip("Larger radius will give a more abstract look but will lower performances.")]
		[Range(1f, 6f)]
		public int Radius;

		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
