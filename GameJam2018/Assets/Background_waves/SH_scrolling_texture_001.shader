// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:2,bsrc:0,bdst:6,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:True,fgod:False,fgor:False,fgmd:0,fgcr:0,fgcg:0,fgcb:0,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:True,fnfb:True,fsmp:False;n:type:ShaderForge.SFN_Final,id:4795,x:32724,y:32693,varname:node_4795,prsc:2|emission-2393-OUT;n:type:ShaderForge.SFN_Tex2d,id:6074,x:32235,y:32601,ptovrint:False,ptlb:MainTex,ptin:_MainTex,varname:_MainTex,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:13daa030933ae490786da1e9bf48a5a7,ntxv:0,isnm:False|UVIN-251-OUT;n:type:ShaderForge.SFN_Multiply,id:2393,x:32495,y:32793,varname:node_2393,prsc:2|A-6074-RGB,B-2053-RGB,C-797-RGB,D-9248-OUT,E-3261-OUT;n:type:ShaderForge.SFN_VertexColor,id:2053,x:32235,y:32772,varname:node_2053,prsc:2;n:type:ShaderForge.SFN_Color,id:797,x:32235,y:32930,ptovrint:True,ptlb:Color,ptin:_TintColor,varname:_TintColor,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_Vector1,id:9248,x:32235,y:33081,varname:node_9248,prsc:2,v1:2;n:type:ShaderForge.SFN_Time,id:3799,x:31531,y:32589,varname:node_3799,prsc:2;n:type:ShaderForge.SFN_ValueProperty,id:9370,x:31366,y:32734,ptovrint:False,ptlb:U_speed,ptin:_U_speed,varname:node_9370,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1;n:type:ShaderForge.SFN_ValueProperty,id:6664,x:31366,y:32825,ptovrint:False,ptlb:V_speed,ptin:_V_speed,varname:_node_9370_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1;n:type:ShaderForge.SFN_Append,id:3386,x:31531,y:32714,varname:node_3386,prsc:2|A-9370-OUT,B-6664-OUT;n:type:ShaderForge.SFN_Multiply,id:8643,x:31712,y:32589,varname:node_8643,prsc:2|A-3799-T,B-3386-OUT;n:type:ShaderForge.SFN_Add,id:251,x:31928,y:32496,varname:node_251,prsc:2|A-8036-OUT,B-8643-OUT;n:type:ShaderForge.SFN_Tex2d,id:4525,x:32201,y:33264,ptovrint:False,ptlb:Flow,ptin:_Flow,varname:_MainTex_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:7bab62586e30a433b8f42713a10afd4b,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Multiply,id:3261,x:32372,y:33264,varname:node_3261,prsc:2|A-6074-A,B-4525-R;n:type:ShaderForge.SFN_ValueProperty,id:4632,x:31328,y:32037,ptovrint:False,ptlb:U_speed_noise,ptin:_U_speed_noise,varname:_U_speed_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0.1;n:type:ShaderForge.SFN_ValueProperty,id:4434,x:31328,y:32126,ptovrint:False,ptlb:V_speed_noise,ptin:_V_speed_noise,varname:_V_speed_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,v1:0;n:type:ShaderForge.SFN_Time,id:3763,x:31531,y:31867,varname:node_3763,prsc:2;n:type:ShaderForge.SFN_Append,id:1407,x:31531,y:32020,varname:node_1407,prsc:2|A-4632-OUT,B-4434-OUT;n:type:ShaderForge.SFN_Multiply,id:1076,x:31702,y:31867,varname:node_1076,prsc:2|A-3763-T,B-1407-OUT;n:type:ShaderForge.SFN_TexCoord,id:8538,x:31702,y:31717,varname:node_8538,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Add,id:8341,x:31873,y:31784,varname:node_8341,prsc:2|A-8538-UVOUT,B-1076-OUT;n:type:ShaderForge.SFN_Tex2d,id:3082,x:32108,y:31784,ptovrint:False,ptlb:NoiseTex,ptin:_NoiseTex,varname:node_3082,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:28c7aad1372ff114b90d330f8a2dd938,ntxv:0,isnm:False|UVIN-8341-OUT;n:type:ShaderForge.SFN_Slider,id:8552,x:31977,y:32033,ptovrint:False,ptlb:Noise_controller,ptin:_Noise_controller,varname:node_8552,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.9700792,max:1;n:type:ShaderForge.SFN_Lerp,id:1639,x:32321,y:31719,varname:node_1639,prsc:2|A-8538-UVOUT,B-3082-RGB,T-8552-OUT;n:type:ShaderForge.SFN_Lerp,id:8036,x:32756,y:31933,varname:node_8036,prsc:2|A-9970-UVOUT,B-1639-OUT,T-2179-R;n:type:ShaderForge.SFN_Tex2d,id:2179,x:32343,y:32209,ptovrint:False,ptlb:NoiseMask,ptin:_NoiseMask,varname:node_2179,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:aafe739ed954a48e496a86eab7a38eeb,ntxv:0,isnm:False;n:type:ShaderForge.SFN_TexCoord,id:9970,x:32315,y:31535,varname:node_9970,prsc:2,uv:0,uaff:False;proporder:6074-797-9370-6664-4525-4632-4434-3082-8552-2179;pass:END;sub:END;*/

Shader "Shader Forge/SH_scrolling_texture_001" {
    Properties {
        _MainTex ("MainTex", 2D) = "white" {}
        _TintColor ("Color", Color) = (0.5,0.5,0.5,1)
        _U_speed ("U_speed", Float ) = 0.1
        _V_speed ("V_speed", Float ) = 0.1
        _Flow ("Flow", 2D) = "white" {}
        _U_speed_noise ("U_speed_noise", Float ) = 0.1
        _V_speed_noise ("V_speed_noise", Float ) = 0
        _NoiseTex ("NoiseTex", 2D) = "white" {}
        _Noise_controller ("Noise_controller", Range(0, 1)) = 0.9700792
        _NoiseMask ("NoiseMask", 2D) = "white" {}
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend One OneMinusSrcColor
            Cull Off
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles gles3 metal d3d11_9x xboxone ps4 psp2 n3ds wiiu 
            #pragma target 3.0
            uniform sampler2D _MainTex; uniform float4 _MainTex_ST;
            uniform float4 _TintColor;
            uniform float _U_speed;
            uniform float _V_speed;
            uniform sampler2D _Flow; uniform float4 _Flow_ST;
            uniform float _U_speed_noise;
            uniform float _V_speed_noise;
            uniform sampler2D _NoiseTex; uniform float4 _NoiseTex_ST;
            uniform float _Noise_controller;
            uniform sampler2D _NoiseMask; uniform float4 _NoiseMask_ST;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 vertexColor : COLOR;
                UNITY_FOG_COORDS(1)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i, float facing : VFACE) : COLOR {
                float isFrontFace = ( facing >= 0 ? 1 : 0 );
                float faceSign = ( facing >= 0 ? 1 : -1 );
////// Lighting:
////// Emissive:
                float4 node_3763 = _Time;
                float2 node_8341 = (i.uv0+(node_3763.g*float2(_U_speed_noise,_V_speed_noise)));
                float4 _NoiseTex_var = tex2D(_NoiseTex,TRANSFORM_TEX(node_8341, _NoiseTex));
                float4 _NoiseMask_var = tex2D(_NoiseMask,TRANSFORM_TEX(i.uv0, _NoiseMask));
                float4 node_3799 = _Time;
                float3 node_251 = (lerp(float3(i.uv0,0.0),lerp(float3(i.uv0,0.0),_NoiseTex_var.rgb,_Noise_controller),_NoiseMask_var.r)+float3((node_3799.g*float2(_U_speed,_V_speed)),0.0));
                float4 _MainTex_var = tex2D(_MainTex,TRANSFORM_TEX(node_251, _MainTex));
                float4 _Flow_var = tex2D(_Flow,TRANSFORM_TEX(i.uv0, _Flow));
                float3 node_2393 = (_MainTex_var.rgb*i.vertexColor.rgb*_TintColor.rgb*2.0*(_MainTex_var.a*_Flow_var.r));
                float3 emissive = node_2393;
                float3 finalColor = emissive;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG_COLOR(i.fogCoord, finalRGBA, fixed4(0,0,0,1));
                return finalRGBA;
            }
            ENDCG
        }
    }
    CustomEditor "ShaderForgeMaterialInspector"
}
