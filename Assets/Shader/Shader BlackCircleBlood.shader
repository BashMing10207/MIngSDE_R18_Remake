Shader "Shader BlackCircleBlood" {
	Properties {
		_TextureSample1 ("Texture Sample 1", 2D) = "white" {}
		_TextureSample0 ("Texture Sample 0", 2D) = "white" {}
		_Wow ("Wow", Float) = 0
		_Speed ("Speed", Float) = 0.2
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