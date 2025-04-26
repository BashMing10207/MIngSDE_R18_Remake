Shader "RED_SIM/Blured Glass" {
	Properties {
		_Iterations ("Iterations", Float) = 0
		_RadiusA ("Radius A", Range(0, 0.25)) = 0
		_RadiusB ("Radius B", Range(0, 0.25)) = 0
		_Smoothness ("Smoothness", Range(0, 1)) = 0
		_Metallic ("Metallic", Range(0, 1)) = 0
		_MetallicAndSmoothness ("Metallic And Smoothness", 2D) = "white" {}
		_ColorA ("Color A", Vector) = (0,0,0,0)
		_ColorB ("Color B", Vector) = (0,0,0,0)
		_FresnelPower ("Fresnel Power", Float) = 0.99
		_FresnelScale ("Fresnel Scale", Float) = 0.99
		[HideInInspector] _texcoord ("", 2D) = "white" {}
		[HideInInspector] __dirty ("", Float) = 1
		[Header(Forward Rendering Options)] [ToggleOff] _SpecularHighlights ("Specular Highlights", Float) = 1
		[ToggleOff] _GlossyReflections ("Reflections", Float) = 1
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