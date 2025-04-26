Shader "Aihasto/HologramEmission" {
	Properties {
		_Texture ("Texture", 2D) = "white" {}
		_Alpha ("Alpha", Range(0, 1)) = 1
		_TextureLine ("TextureLine", 2D) = "white" {}
		_TileLines ("TileLines", Vector) = (1,1,0,0)
		[HDR] _Color ("Color", Vector) = (1,1,1,0)
		_SpeedLines ("SpeedLines", Float) = 0.01
		[HideInInspector] _texcoord ("", 2D) = "white" {}
		[HideInInspector] __dirty ("", Float) = 1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		fixed4 _Color;
		struct Input
		{
			float2 uv_MainTex;
		};
		
		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			o.Albedo = _Color.rgb;
			o.Alpha = _Color.a;
		}
		ENDCG
	}
	Fallback "Diffuse"
	//CustomEditor "ASEMaterialInspector"
}