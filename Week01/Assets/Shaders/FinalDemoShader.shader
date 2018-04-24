// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "Custom/FinalDemoShader" {

    Properties
    {
        _Tint ("Tint", Color) = (1, 1, 1, 1)
    }


    Subshader
    {
    
        Pass
        {
            CGPROGRAM
            
            #pragma vertex MyVertProgram
            #pragma fragment MyFragProgram
            #include "UnityCG.cginc"
            
            float4 _Tint;
            
            struct Interpolators 
            {
                float4 position : SV_POSITION;
                float3 localPosition : TEXCOORD0;
            };

            Interpolators MyVertProgram (float4 position : POSITION)
            {
                Interpolators i;
                i.localPosition = position.xyz;
                i.position = UnityObjectToClipPos(position);
                return i;
            }
            
            float4 MyFragProgram(Interpolators i) : SV_TARGET
            {
                return float4(i.localPosition + 0.5, 1) * _Tint;
            }
            
            ENDCG
        }
    
    }
}