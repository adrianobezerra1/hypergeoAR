﻿Shader "Sample/AREnginePlane"
{
    Properties
    {
        _MainTex("Texture", 2D) = "white" {}
        _PlaneNormal("Plane Normal",Vector) = (0.0,0.0,0.0)
    }

    SubShader
    {
        Tags { "Queue" = "Transparent" "RenderType" = "Transparent" }
        Blend SrcAlpha OneMinusSrcAlpha
        ZTest on
        ZWrite off

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct VertexInput
            {
                float4 pos : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct VertexOutput
            {
                float4 pos : SV_POSITION;
                float2 uv : TEXCOORD0;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;
            float3 _PlaneNormal;

            VertexOutput vert(VertexInput vi)
            {
                VertexOutput vo;
                vo.pos = UnityObjectToClipPos(vi.pos);

                const float3 aux = float3(1.0,1.0,0.0);
                float3 texture_u = normalize(cross(_PlaneNormal,aux));
                float3 texture_v = normalize(cross(_PlaneNormal,texture_u));

                float2 texture_uv = float2(dot(vi.pos.xyz,texture_u),dot(vi.pos.xyz,texture_v));

                vo.uv = texture_uv * _MainTex_ST.xy;
                vo.uv *= 16;
                return vo;
            }

            fixed4 frag(VertexOutput vo) : SV_Target
            {
                fixed4 col = tex2D(_MainTex, vo.uv);
                return col * 0.4;
            }
            ENDCG
        }
    }
}
