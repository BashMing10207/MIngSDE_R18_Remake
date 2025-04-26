Shader "RED_SIM/Explosion" {
	Properties {
		_OuterGradient ("Outer Gradient", Float) = 1.6
		_InnerGradient ("Inner Gradient", Float) = 0.65
		_RefractionPower ("Refraction Power", Float) = 1
		[Toggle] _UseAsParticle ("Use As Particle", Float) = 1
		[Toggle] _Debug ("Debug", Float) = 0
		[HDR] _Color ("Color", Vector) = (0,0,0,0)
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
	//CustomEditor "ASEMaterialInspector"
}