Shader "Hidden/Colorful/Analog TV" {
	Properties {
		_MainTex ("Base (RGB)", 2D) = "white" {}
		_Params1 ("Noise Intensity (X) Scanlines Intensity (Y) Scanlines Count (Z) Scanlines Offset (W)", Vector) = (0.5,2,768,0)
		_Params2 ("Phase (X) Distortion (Y) Cubic Distortion (Z) Scale (W)", Vector) = (0.05,0.2,0.6,0.8)
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