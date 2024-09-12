﻿Shader "Hikanyan's Shader/UnlitShader"//Shaderブロック
{
    Properties//Propertiesブロック
    {
        [Header(CinemaScape)]//指定した変数の上にCinemaScapeを表示
                _CSEnable("シネマスコープ",range(0,1)) = 0
                _CSColor("色",color) = (0,0,0,1)
                _CSWidth("幅",range(0,1)) = 0.5
    }
    SubShader//SubShaderブロック
    {
        Tags { "RenderType"="Opaque" }
        LOD 600

        Pass//Passブロック
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
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                UNITY_FOG_COORDS(1)
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                UNITY_TRANSFER_FOG(o,o.vertex);
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                // sample the texture
                fixed4 col = tex2D(_MainTex, i.uv);
                // apply fog
                UNITY_APPLY_FOG(i.fogCoord, col);
                return col;
            }
            ENDCG
        }
    }
}