Shader "Aihasto/Shooter/Enemy" {
	Properties {
		_MainTexture ("MainTexture", 2D) = "white" {}
		_EmissionStatic ("EmissionStatic", 2D) = "white" {}
		[HDR] _ColorEmissionStatic ("ColorEmissionStatic", Vector) = (2,2,2,0)
		_Emission ("Emission", 2D) = "white" {}
		[HDR] _ColorEmission ("ColorEmission", Vector) = (2,2,2,0)
		_Noise ("Noise", 2D) = "white" {}
		_SpeedNoise ("SpeedNoise", Vector) = (1,1,0,0)
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