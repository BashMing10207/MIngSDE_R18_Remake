Shader "RED_SIM/Mirror Water" {
	Properties {
		[Header(PBR Setup)] _MetallicSmoothness ("Metallic & Smoothness", 2D) = "white" {}
		_Metallic ("Metallic", Range(0, 1)) = 1
		_SmoothnessPower ("Smoothness", Range(0, 1)) = 0.9
		_Normal ("Normal", 2D) = "bump" {}
		_NormalScale ("Normal Scale", Range(0, 1)) = 0
		_RefractionScale ("Refraction Scale", Range(0, 1)) = 0
		[Header(Color Correction)] _Tint ("Tint", Vector) = (1,1,1,1)
		[HideInInspector] [NoScaleOffset] _ReflectionTex0 ("Reflection Left Eye", 2D) = "black" {}
		[HideInInspector] [NoScaleOffset] _ReflectionTex1 ("Reflection Right Eye", 2D) = "black" {}
		_MainTex ("Albedo", 2D) = "white" {}
		_Opacity ("Opacity", Range(0, 1)) = 0
		_Speed ("Speed", Float) = 0
		[HideInInspector] _texcoord ("", 2D) = "white" {}
		[HideInInspector] __dirty ("", Float) = 1
		[Header(Forward Rendering Options)] [ToggleOff] _SpecularHighlights ("Specular Highlights", Float) = 1
		[ToggleOff] _GlossyReflections ("Reflections", Float) = 1
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