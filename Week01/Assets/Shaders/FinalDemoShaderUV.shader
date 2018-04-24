Shader "Custom/FinalDemoShaderUV" {

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
                float2 uv : TEXCOORD0;
            };
            
            struct VertexData {
                float4 position : POSITION;
                float2 uv : TEXCOORD0;
            };

            Interpolators MyVertProgram (VertexData v) {
                Interpolators i;
                i.position = UnityObjectToClipPos(v.position);
                i.uv = v.uv;
                return i;
            }
            
            float4 MyFragProgram(Interpolators i) : SV_TARGET
            {
                return float4(i.uv, 1, 1);
            }
            
            ENDCG
        }
    
    }
}