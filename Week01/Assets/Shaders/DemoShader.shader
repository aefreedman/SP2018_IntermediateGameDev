Shader "Custom/DemoShader"
{
    Subshader
    {
    
        Pass
        {
            CGPROGRAM
            
            //The vertex program defines operations on vertices
            #pragma vertex MyVertProgram
            
            //The fragment program defines operations that display fragments
            #pragma fragment MyFragProgram
            
            #include "UnityCG.cginc"
            
// Step 1
            void MyVertProgram ()
            {
            }
           
            void MyFragProgram()
            {
            }
            
            
 // Step 2
            // Change the return type and define the "semantics" -- tell the shader what the output value is for
            // "SV" means "system value"
//            float4 MyVertProgram () : SV_POSITION
//            {
//                return 0; // return 0 for a float4 returns (0, 0, 0, 0)
//            }
//            
//            // Change the return type and tell the progam that we're targeting the frame buffer: SV_TARGET
//            float4 MyFragProgram() : SV_TARGET
//            {
//                return 0;
//            }

//Step 3

            // We didn't know where the vertices were, so we need to retrieve those values by adding a parameter
            // POSITION is the object-space positions of the vertices
//            float4 MyVertProgram (float4 position : POSITION) : SV_POSITION
//            {
//                return position;
//            }
//            

//Step 4
            //We don't want object-space positions however, we need world positions, so we have to transform these points by the
            // Model-view-projection matrix to get the vertex positions relative to the rendering camera
//            float4 MyVertProgram (float4 position : POSITION) : SV_POSITION
//            {
//                return mul(UNITY_MATRIX_MVP, position); <---
//            }
            
            ENDCG
        }
    
    }
}