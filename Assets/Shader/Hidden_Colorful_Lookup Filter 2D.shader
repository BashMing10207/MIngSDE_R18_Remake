Shader "Hidden/Colorful/Lookup Filter 2D" {
	Properties {
		_MainTex ("Base (RGB)", 2D) = "white" {}
		_LookupTex ("Lookup (RGB)", 2D) = "white" {}
		_Params1 ("Scale (XY) Offset (Z)", Vector) = (0,0,0,0)
		_Params2 ("Amount (Z) PixelSize (W)", Vector) = (1,0,0,0)
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