Shader "GlitchSpider" {
	Properties {
		_Main ("Main", 2D) = "white" {}
		_Cutoff ("Mask Clip Value", Float) = 0.1
		_Glitch ("Glitch", 2D) = "white" {}
		_Noise ("Noise", 2D) = "white" {}
		_Intensity ("Intensity", Float) = 0
		[HideInInspector] _texcoord ("", 2D) = "white" {}
		[HideInInspector] __dirty ("", Float) = 1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			o.Albedo = 1;
		}
		ENDCG
	}
	Fallback "Diffuse"
	//CustomEditor "ASEMaterialInspector"
}