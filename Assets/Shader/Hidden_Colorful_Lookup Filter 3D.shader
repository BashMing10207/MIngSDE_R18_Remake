Shader "Hidden/Colorful/Lookup Filter 3D" {
	Properties {
		_MainTex ("Base (RGB)", 2D) = "white" {}
		_LookupTex ("Lookup (RGB 3D)", 3D) = "white" {}
		_Params ("Scale (X) Offset (Y) Amount (Z) PixelSize (W)", Vector) = (0,0,1,0)
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