Shader "Aihasto/DrawWorldUV CutMask" {
	Properties {
		_MainTex ("MainTex", 2D) = "white" {}
		_Cutoff ("Mask Clip Value", Float) = 0.5
		_EmissionMap ("Texture Emission", 2D) = "white" {}
		[HDR] _EmissionColor ("ColorEmission", Vector) = (0,0,0,0)
		_AlphaMask ("AlphaMask", 2D) = "white" {}
		_CutIntensity ("CutIntensity", Float) = 0.6
		[HideInInspector] _texcoord ("", 2D) = "white" {}
		[HideInInspector] _texcoord2 ("", 2D) = "white" {}
		[HideInInspector] __dirty ("", Float) = 1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		sampler2D _MainTex;
		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex);
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
	Fallback "Diffuse"
	//CustomEditor "ASEMaterialInspector"
}