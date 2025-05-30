Shader "Aihasto/OutlinesPostprocessed" {
	Properties {
		[HideInInspector] _MainTex ("Texture", 2D) = "white" {}
		_OutlineColor ("Outline Color", Vector) = (0,0,0,1)
		_NormalMult ("Normal Outline Multiplier", Range(0, 4)) = 1
		_NormalBias ("Normal Outline Bias", Range(1, 4)) = 1
		_DepthMult ("Depth Outline Multiplier", Range(0, 4)) = 1
		_DepthBias ("Depth Outline Bias", Range(1, 4)) = 1
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
}