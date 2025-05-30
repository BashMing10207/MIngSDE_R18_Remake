Shader "Hidden/Colorful/Radial Blur" {
	Properties {
		_MainTex ("Base (RGB)", 2D) = "white" {}
		_Center ("Center Point", Vector) = (0.5,0.5,0,0)
		_Params ("Strength (X) Samples (Y) Sharpness (Z) Darkness (W)", Vector) = (0.1,10,0.4,0.35)
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