/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 74: AmplifyOcclusion.dll - Assembly: AmplifyOcclusion, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8941-8957

[AddComponentMenu] // 0x00000001800B75F0-0x00000001800B7620
public class AmplifyOcclusionBase : UnityEngine.MonoBehaviour // TypeDefIndex: 8942
{
	// Fields
	[Header] // 0x0000000180173F80-0x0000000180173FE0
	[Tooltip] // 0x0000000180173F80-0x0000000180173FE0
	public ApplicationMethod ApplyMethod; // 0x18
	[Tooltip] // 0x0000000180174450-0x0000000180174480
	public SampleCountLevel SampleCount; // 0x1C
	[Tooltip] // 0x0000000180174780-0x00000001801747B0
	public PerPixelNormalSource PerPixelNormals; // 0x20
	[Range] // 0x0000000180174920-0x0000000180174980
	[Tooltip] // 0x0000000180174920-0x0000000180174980
	public float Intensity; // 0x24
	[Tooltip] // 0x0000000180174BE0-0x0000000180174C10
	public Color Tint; // 0x28
	[Range] // 0x0000000180174E00-0x0000000180174E60
	[Tooltip] // 0x0000000180174E00-0x0000000180174E60
	public float Radius; // 0x38
	[Range] // 0x0000000180175200-0x0000000180175260
	[Tooltip] // 0x0000000180175200-0x0000000180175260
	public float PowerExponent; // 0x3C
	[Range] // 0x00000001801754C0-0x0000000180175520
	[Tooltip] // 0x00000001801754C0-0x0000000180175520
	public float Bias; // 0x40
	[Range] // 0x00000001801756B0-0x0000000180175710
	[Tooltip] // 0x00000001801756B0-0x0000000180175710
	public float Thickness; // 0x44
	[Tooltip] // 0x00000001800B38F0-0x00000001800B3920
	public bool Downsample; // 0x48
	[Header] // 0x00000001800B3B50-0x00000001800B3BB0
	[Tooltip] // 0x00000001800B3B50-0x00000001800B3BB0
	public bool FadeEnabled; // 0x49
	[Tooltip] // 0x00000001800B3E50-0x00000001800B3E80
	public float FadeStart; // 0x4C
	[Tooltip] // 0x00000001800B4020-0x00000001800B4050
	public float FadeLength; // 0x50
	[Range] // 0x00000001800B4210-0x00000001800B4270
	[Tooltip] // 0x00000001800B4210-0x00000001800B4270
	public float FadeToIntensity; // 0x54
	public Color FadeToTint; // 0x58
	[Range] // 0x00000001800B5640-0x00000001800B56A0
	[Tooltip] // 0x00000001800B5640-0x00000001800B56A0
	public float FadeToRadius; // 0x68
	[Range] // 0x00000001800B5800-0x00000001800B5860
	[Tooltip] // 0x00000001800B5800-0x00000001800B5860
	public float FadeToPowerExponent; // 0x6C
	[Range] // 0x00000001800B59F0-0x00000001800B5A50
	[Tooltip] // 0x00000001800B59F0-0x00000001800B5A50
	public float FadeToThickness; // 0x70
	[Header] // 0x00000001800B5C50-0x00000001800B5C80
	public bool BlurEnabled; // 0x74
	[Range] // 0x00000001800B5E00-0x00000001800B5E60
	[Tooltip] // 0x00000001800B5E00-0x00000001800B5E60
	public int BlurRadius; // 0x78
	[Range] // 0x00000001800B6110-0x00000001800B6170
	[Tooltip] // 0x00000001800B6110-0x00000001800B6170
	public int BlurPasses; // 0x7C
	[Range] // 0x00000001800B63C0-0x00000001800B6420
	[Tooltip] // 0x00000001800B63C0-0x00000001800B6420
	public float BlurSharpness; // 0x80
	[Header] // 0x00000001800B6510-0x00000001800B6570
	[Tooltip] // 0x00000001800B6510-0x00000001800B6570
	public bool FilterEnabled; // 0x84
	[Range] // 0x00000001800B6670-0x00000001800B66D0
	[Tooltip] // 0x00000001800B6670-0x00000001800B66D0
	public float FilterBlending; // 0x88
	[Range] // 0x00000001800B6810-0x00000001800B6870
	[Tooltip] // 0x00000001800B6810-0x00000001800B6870
	public float FilterResponse; // 0x8C
	[Tooltip] // 0x00000001800B6A00-0x00000001800B6A30
	private bool TemporalDilation; // 0x90
	private bool m_HDR; // 0x91
	private bool m_MSAA; // 0x92
	private PerPixelNormalSource m_prevPerPixelNormals; // 0x94
	private ApplicationMethod m_prevApplyMethod; // 0x98
	private bool m_prevDeferredReflections; // 0x9C
	private SampleCountLevel m_prevSampleCount; // 0xA0
	private bool m_prevDownsample; // 0xA4
	private bool m_prevBlurEnabled; // 0xA5
	private int m_prevBlurRadius; // 0xA8
	private int m_prevBlurPasses; // 0xAC
	private bool m_prevFilterEnabled; // 0xB0
	private bool m_prevHDR; // 0xB1
	private bool m_prevMSAA; // 0xB2
	private Camera m_targetCamera; // 0xB8
	private RenderTargetIdentifier[] applyDebugTargetsTemporal; // 0xC0
	private RenderTargetIdentifier[] applyDeferredTargets_Log_Temporal; // 0xC8
	private RenderTargetIdentifier[] applyDeferredTargetsTemporal; // 0xD0
	private RenderTargetIdentifier[] applyOcclusionTemporal; // 0xD8
	private RenderTargetIdentifier[] applyPostEffectTargetsTemporal; // 0xE0
	private bool useMRTBlendingFallback; // 0xE8
	private CmdBuffer m_commandBuffer_Occlusion; // 0xF0
	private CmdBuffer m_commandBuffer_Apply; // 0x108
	private static Mesh m_quadMesh; // 0x00
	private static Material m_occlusionMat; // 0x08
	private static Material m_blurMat; // 0x10
	private static Material m_applyOcclusionMat; // 0x18
	private RenderTextureFormat m_occlusionRTFormat; // 0x120
	private RenderTextureFormat m_accumTemporalRTFormat; // 0x124
	private RenderTextureFormat m_temporaryEmissionRTFormat; // 0x128
	private bool m_paramsChanged; // 0x12C
	private RenderTexture m_occlusionDepthRT; // 0x130
	private RenderTexture[] m_temporalAccumRT; // 0x138
	private uint m_sampleStep; // 0x140
	private uint m_curStepIdx; // 0x144
	private static readonly int PerPixelNormalSourceCount; // 0x20
	private Matrix4x4 m_prevViewProjMatrixLeft; // 0x148
	private Matrix4x4 m_prevInvViewProjMatrixLeft; // 0x188
	private Matrix4x4 m_prevViewProjMatrixRight; // 0x1C8
	private Matrix4x4 m_prevInvViewProjMatrixRight; // 0x208
	private static readonly float[] m_temporalRotations; // 0x28
	private static readonly float[] m_spatialOffsets; // 0x30
	private readonly RenderTargetIdentifier[] m_applyDeferredTargets; // 0x248
	private readonly RenderTargetIdentifier[] m_applyDeferredTargets_Log; // 0x250
	private TargetDesc m_target; // 0x258

	// Properties
	private bool UsingTemporalFilter { get; } // 0x00000001822BB4E0-0x00000001822BB520 
	private bool UsingMotionVectors { get; } // 0x00000001822BB490-0x00000001822BB4E0 

	// Nested types
	public enum ApplicationMethod // TypeDefIndex: 8943
	{
		PostEffect = 0,
		Deferred = 1,
		Debug = 2
	}

	public enum PerPixelNormalSource // TypeDefIndex: 8944
	{
		None = 0,
		Camera = 1,
		GBuffer = 2,
		GBufferOctaEncoded = 3
	}

	public enum SampleCountLevel // TypeDefIndex: 8945
	{
		Low = 0,
		Medium = 1,
		High = 2,
		VeryHigh = 3
	}

	private struct CmdBuffer // TypeDefIndex: 8946
	{
		// Fields
		public CommandBuffer cmdBuffer; // 0x00
		public CameraEvent cmdBufferEvent; // 0x08
		public string cmdBufferName; // 0x10
	}

	private struct TargetDesc // TypeDefIndex: 8947
	{
		// Fields
		public int fullWidth; // 0x00
		public int fullHeight; // 0x04
		public int width; // 0x08
		public int height; // 0x0C
		public float oneOverWidth; // 0x10
		public float oneOverHeight; // 0x14
	}

	private static class ShaderPass // TypeDefIndex: 8948
	{
		// Fields
		public const int CombineDownsampledOcclusionDepth = 16; // Metadata: 0x00743E69
		public const int BlurHorizontal1 = 0; // Metadata: 0x00743E6D
		public const int BlurVertical1 = 1; // Metadata: 0x00743E71
		public const int BlurHorizontal2 = 2; // Metadata: 0x00743E75
		public const int BlurVertical2 = 3; // Metadata: 0x00743E79
		public const int BlurHorizontal3 = 4; // Metadata: 0x00743E7D
		public const int BlurVertical3 = 5; // Metadata: 0x00743E81
		public const int BlurHorizontal4 = 6; // Metadata: 0x00743E85
		public const int BlurVertical4 = 7; // Metadata: 0x00743E89
		public const int ApplyDebug = 0; // Metadata: 0x00743E8D
		public const int ApplyDebugTemporal = 1; // Metadata: 0x00743E91
		public const int ApplyDeferred = 5; // Metadata: 0x00743E95
		public const int ApplyDeferredTemporal = 6; // Metadata: 0x00743E99
		public const int ApplyDeferredLog = 10; // Metadata: 0x00743E9D
		public const int ApplyDeferredLogTemporal = 11; // Metadata: 0x00743EA1
		public const int ApplyPostEffect = 15; // Metadata: 0x00743EA5
		public const int ApplyPostEffectTemporal = 16; // Metadata: 0x00743EA9
		public const int ApplyPostEffectTemporalMultiply = 20; // Metadata: 0x00743EAD
		public const int ApplyDeferredTemporalMultiply = 21; // Metadata: 0x00743EB1
		public const int OcclusionLow_None = 0; // Metadata: 0x00743EB5
		public const int OcclusionLow_Camera = 1; // Metadata: 0x00743EB9
		public const int OcclusionLow_GBuffer = 2; // Metadata: 0x00743EBD
		public const int OcclusionLow_GBufferOctaEncoded = 3; // Metadata: 0x00743EC1
	}

	private static class PropertyID // TypeDefIndex: 8949
	{
		// Fields
		public static readonly int _AO_Radius; // 0x00
		public static readonly int _AO_PowExponent; // 0x04
		public static readonly int _AO_Bias; // 0x08
		public static readonly int _AO_Levels; // 0x0C
		public static readonly int _AO_ThicknessDecay; // 0x10
		public static readonly int _AO_BlurSharpness; // 0x14
		public static readonly int _AO_CameraViewLeft; // 0x18
		public static readonly int _AO_CameraViewRight; // 0x1C
		public static readonly int _AO_ProjMatrixLeft; // 0x20
		public static readonly int _AO_ProjMatrixRight; // 0x24
		public static readonly int _AO_InvViewProjMatrixLeft; // 0x28
		public static readonly int _AO_PrevViewProjMatrixLeft; // 0x2C
		public static readonly int _AO_PrevInvViewProjMatrixLeft; // 0x30
		public static readonly int _AO_InvViewProjMatrixRight; // 0x34
		public static readonly int _AO_PrevViewProjMatrixRight; // 0x38
		public static readonly int _AO_PrevInvViewProjMatrixRight; // 0x3C
		public static readonly int _AO_GBufferNormals; // 0x40
		public static readonly int _AO_Target_TexelSize; // 0x44
		public static readonly int _AO_TemporalCurveAdj; // 0x48
		public static readonly int _AO_TemporalMotionSensibility; // 0x4C
		public static readonly int _AO_CurrOcclusionDepth; // 0x50
		public static readonly int _AO_TemporalAccumm; // 0x54
		public static readonly int _AO_TemporalDirections; // 0x58
		public static readonly int _AO_TemporalOffsets; // 0x5C
		public static readonly int _AO_OcclusionTexture; // 0x60
		public static readonly int _AO_GBufferAlbedo; // 0x64
		public static readonly int _AO_GBufferEmission; // 0x68
		public static readonly int _AO_UVToView; // 0x6C
		public static readonly int _AO_HalfProjScale; // 0x70
		public static readonly int _AO_FadeParams; // 0x74
		public static readonly int _AO_FadeValues; // 0x78
		public static readonly int _AO_FadeToTint; // 0x7C
		public static readonly int _AO_Source_TexelSize; // 0x80
		public static readonly int _AO_Source; // 0x84

		// Constructors
		static PropertyID(); // 0x00000001822BCD60-0x00000001822BD1B0
	}

	// Constructors
	public AmplifyOcclusionBase(); // 0x00000001822B77F0-0x00000001822B7BF0
	static AmplifyOcclusionBase(); // 0x00000001822B76F0-0x00000001822B77F0

	// Methods
	private void createCommandBuffer(ref CmdBuffer aCmdBuffer, string aCmdBufferName, CameraEvent aCameraEvent); // 0x00000001822BAC70-0x00000001822BAD40
	private void cleanupCommandBuffer(ref CmdBuffer aCmdBuffer); // 0x00000001822B8550-0x00000001822B8680
	private void createQuadMesh(); // 0x00000001822BAEB0-0x00000001822BB420
	private void PerformBlit(CommandBuffer cb, Material mat, int pass); // 0x00000001822B5F30-0x00000001822B6040
	private Material createMaterialWithShaderName(string aShaderName, bool aThroughErrorMsg); // 0x00000001822BAD40-0x00000001822BAEB0
	private void checkMaterials(bool aThroughErrorMsg); // 0x00000001822B7BF0-0x00000001822B7E40
	private bool checkRenderTextureFormats(); // 0x00000001822B84D0-0x00000001822B8550
	private void OnEnable(); // 0x00000001822B58C0-0x00000001822B5A40
	private void Reset(); // 0x00000001822B5870-0x00000001822B58C0
	private void OnDisable(); // 0x00000001822B5870-0x00000001822B58C0
	private void releaseRT(); // 0x00000001822BB5A0-0x00000001822BB660
	private void ClearHistory(); // 0x00000001822B5730-0x00000001822B5840
	private bool checkParamsChanged(); // 0x00000001822B7E40-0x00000001822B84D0
	private void updateParams(); // 0x00000001822BB900-0x00000001822BB960
	private void Update(); // 0x00000001822B74A0-0x00000001822B76F0
	private void OnPreRender(); // 0x00000001822B5B10-0x00000001822B5F30
	private void OnPostRender(); // 0x00000001822B5A40-0x00000001822B5B10
	private int safeAllocateTemporaryRT(CommandBuffer cb, string propertyName, int width, int height, RenderTextureFormat format = RenderTextureFormat.Default /* Metadata: 0x00743E29 */, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default /* Metadata: 0x00743E2D */, FilterMode filterMode = FilterMode.Point /* Metadata: 0x00743E31 */); // 0x00000001822BB7B0-0x00000001822BB840
	private void safeReleaseTemporaryRT(CommandBuffer cb, int id); // 0x00000001818D8BE0-0x00000001818D8C10
	private RenderTexture safeAllocateRT(string name, int width, int height, RenderTextureFormat format, RenderTextureReadWrite readWrite, FilterMode filterMode = FilterMode.Point /* Metadata: 0x00743E35 */, int antiAliasing = 1 /* Metadata: 0x00743E39 */); // 0x00000001822BB660-0x00000001822BB7B0
	private void safeReleaseRT(ref RenderTexture rt); // 0x00000001822BB840-0x00000001822BB900
	private void BeginSample(CommandBuffer cb, string name); // 0x00000001822B5700-0x00000001822B5730
	private void EndSample(CommandBuffer cb, string name); // 0x00000001822B5840-0x00000001822B5870
	private void commandBuffer_FillComputeOcclusion(CommandBuffer cb); // 0x00000001822BA240-0x00000001822BA900
	private void commandBuffer_Blur(CommandBuffer cb, RenderTargetIdentifier aSourceRT, int aSourceWidth, int aSourceHeight); // 0x00000001822B8680-0x00000001822B8980
	private int getTemporalPass(); // 0x00000001822BB420-0x00000001822BB490
	private void commandBuffer_TemporalFilter(CommandBuffer cb); // 0x00000001822BA900-0x00000001822BAC70
	private void commandBuffer_FillApplyDeferred(CommandBuffer cb, bool logTarget); // 0x00000001822B8D90-0x00000001822B9C90
	private void commandBuffer_FillApplyPostEffect(CommandBuffer cb); // 0x00000001822B9C90-0x00000001822BA240
	private void commandBuffer_FillApplyDebug(CommandBuffer cb); // 0x00000001822B8980-0x00000001822B8D90
	private bool isStereoSinglePassEnabled(); // 0x00000001822BB520-0x00000001822BB5A0
	private void UpdateGlobalShaderConstants(); // 0x00000001822B6E50-0x00000001822B74A0
	private void UpdateGlobalShaderConstants_AmbientOcclusion(); // 0x00000001822B6040-0x00000001822B61E0
	private void UpdateGlobalShaderConstants_Matrices(); // 0x00000001822B61E0-0x00000001822B6E50
}

