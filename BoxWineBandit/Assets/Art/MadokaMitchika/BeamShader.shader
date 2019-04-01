Shader "Unlit/BeamShader"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
		_DistortTex("Distortion Texture", 2D) = "white" {}
		_ColorA("Main Color A", Color) = (1,1,1,1)
		_MainScroll("Main Scroll", Range(-2,2)) = 1
		_Offset("Offset Gradient", Range(-2,2)) = 1
		_XSpeed("X Scrolling Speed", Range(-2,2)) = 1
		_YSpeed("Y Scrolling Speed", Range(-2,2)) = 1
		_XDistort("X Distortion Amount", Range(-2,2)) = 1
		_YDistort("Y Distortion Amount", Range(-2,2)) = 1

    }
    SubShader
    {
        Tags { "RenderType" = "Transparent" "Queue"="Transparent"}
        LOD 100
		Zwrite Off
		Blend One One
		Cull Back

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            // make fog work
            #pragma multi_compile_fog

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
				float4 col : COLOR;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
				float2 uv2 : TEXCOORD2;
				float2 uv3 : TEXCOORD4;
                UNITY_FOG_COORDS(1)
                float4 vertex : SV_POSITION;
				float4 col : COLOR;
            };

            sampler2D _MainTex, _DistortTex;
            float4 _MainTex_ST, _DistortTex_ST;
			float4 _ColorA;
			float _Offset, _XDistort, _YDistort, _XSpeed, _YSpeed, _MainScroll;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
				o.uv3 = TRANSFORM_TEX(v.uv, _DistortTex);
				
                UNITY_TRANSFER_FOG(o,o.vertex);
				o.col = v.col * _ColorA;
				o.col = o.col * v.col.a;
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                // sample the texture
				fixed distort1 = tex2D(_DistortTex, fixed2(i.uv.x + (_Time.y * 1.5), i.uv.y)).a;
				fixed distort2 = tex2D(_DistortTex, fixed2(i.uv.x, i.uv.y + (_Time.y * 1.5))).a;
				fixed2 mainDistort = lerp(i.uv, fixed2(distort1, distort2), 0.15);
				fixed4 maintex = tex2D(_MainTex, mainDistort) * i.col;
				
                // apply fog
                UNITY_APPLY_FOG(i.fogCoord, maintex);
                return maintex;
            }
            ENDCG
        }
    }
}
