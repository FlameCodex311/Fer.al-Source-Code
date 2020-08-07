/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

// Image 75: AmplifyOcclusion.dll - Assembly: AmplifyOcclusion, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9107-9123

[AddComponentMenu] // 0x0000000180213020-0x0000000180213050
public class AmplifyOcclusionBase : UnityEngine.MonoBehaviour // TypeDefIndex: 9108
{
	// Fields
	[Header] // 0x0000000180213130-0x0000000180213190
	[Tooltip] // 0x0000000180213130-0x0000000180213190
	public ApplicationMethod ApplyMethod; // 0x18
	[Tooltip] // 0x0000000180213520-0x0000000180213550
	public SampleCountLevel SampleCount; // 0x1C
	[Tooltip] // 0x0000000180213740-0x0000000180213770
	public PerPixelNormalSource PerPixelNormals; // 0x20
	[Range] // 0x0000000180213AC0-0x0000000180213B20
	[Tooltip] // 0x0000000180213AC0-0x0000000180213B20
	public float Intensity; // 0x24
	[Tooltip] // 0x0000000180213D10-0x0000000180213D40
	public Color Tint; // 0x28
	[Range] // 0x0000000180213EA0-0x0000000180213F00
	[Tooltip] // 0x0000000180213EA0-0x0000000180213F00
	public float Radius; // 0x38
	[Range] // 0x0000000180214170-0x00000001802141D0
	[Tooltip] // 0x0000000180214170-0x00000001802141D0
	public float PowerExponent; // 0x3C
	[Range] // 0x0000000180214430-0x0000000180214490
	[Tooltip] // 0x0000000180214430-0x0000000180214490
	public float Bias; // 0x40
	[Range] // 0x0000000180214730-0x0000000180214790
	[Tooltip] // 0x0000000180214730-0x0000000180214790
	public float Thickness; // 0x44
	[Tooltip] // 0x0000000180214AF0-0x0000000180214B20
	public bool Downsample; // 0x48
	[Header] // 0x0000000180214E00-0x0000000180214E60
	[Tooltip] // 0x0000000180214E00-0x0000000180214E60
	public bool FadeEnabled; // 0x49
	[Tooltip] // 0x0000000180215070-0x00000001802150A0
	public float FadeStart; // 0x4C
	[Tooltip] // 0x0000000180215190-0x00000001802151C0
	public float FadeLength; // 0x50
	[Range] // 0x00000001802152D0-0x0000000180215330
	[Tooltip] // 0x00000001802152D0-0x0000000180215330
	public float FadeToIntensity; // 0x54
	public Color FadeToTint; // 0x58
	[Range] // 0x00000001802155C0-0x0000000180215620
	[Tooltip] // 0x00000001802155C0-0x0000000180215620
	public float FadeToRadius; // 0x68
	[Range] // 0x0000000180215810-0x0000000180215870
	[Tooltip] // 0x0000000180215810-0x0000000180215870
	public float FadeToPowerExponent; // 0x6C
	[Range] // 0x0000000180215B00-0x0000000180215B60
	[Tooltip] // 0x0000000180215B00-0x0000000180215B60
	public float FadeToThickness; // 0x70
	[Header] // 0x0000000180215D40-0x0000000180215D70
	public bool BlurEnabled; // 0x74
	[Range] // 0x0000000180216000-0x0000000180216060
	[Tooltip] // 0x0000000180216000-0x0000000180216060
	public int BlurRadius; // 0x78
	[Range] // 0x0000000180216270-0x00000001802162D0
	[Tooltip] // 0x0000000180216270-0x00000001802162D0
	public int BlurPasses; // 0x7C
	[Range] // 0x00000001802164E0-0x0000000180216540
	[Tooltip] // 0x00000001802164E0-0x0000000180216540
	public float BlurSharpness; // 0x80
	[Header] // 0x0000000180216720-0x0000000180216780
	[Tooltip] // 0x0000000180216720-0x0000000180216780
	public bool FilterEnabled; // 0x84
	[Range] // 0x0000000180216AF0-0x0000000180216B50
	[Tooltip] // 0x0000000180216AF0-0x0000000180216B50
	public float FilterBlending; // 0x88
	[Range] // 0x0000000180217020-0x0000000180217080
	[Tooltip] // 0x0000000180217020-0x0000000180217080
	public float FilterResponse; // 0x8C
	[Tooltip] // 0x0000000180217280-0x00000001802172B0
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
	private bool UsingTemporalFilter { get; } // 0x0000000182096910-0x0000000182096950 
	private bool UsingMotionVectors { get; } // 0x00000001820968C0-0x0000000182096910 

	// Nested types
	public enum ApplicationMethod // TypeDefIndex: 9109
	{
		PostEffect = 0,
		Deferred = 1,
		Debug = 2
	}

	public enum PerPixelNormalSource // TypeDefIndex: 9110
	{
		None = 0,
		Camera = 1,
		GBuffer = 2,
		GBufferOctaEncoded = 3
	}

	public enum SampleCountLevel // TypeDefIndex: 9111
	{
		Low = 0,
		Medium = 1,
		High = 2,
		VeryHigh = 3
	}

	private struct CmdBuffer // TypeDefIndex: 9112
	{
		// Fields
		public CommandBuffer cmdBuffer; // 0x00
		public CameraEvent cmdBufferEvent; // 0x08
		public string cmdBufferName; // 0x10
	}

	private struct TargetDesc // TypeDefIndex: 9113
	{
		// Fields
		public int fullWidth; // 0x00
		public int fullHeight; // 0x04
		public int width; // 0x08
		public int height; // 0x0C
		public float oneOverWidth; // 0x10
		public float oneOverHeight; // 0x14
	}

	private static class ShaderPass // TypeDefIndex: 9114
	{
		// Fields
		public const int CombineDownsampledOcclusionDepth = 16; // Metadata: 0x00778B57
		public const int BlurHorizontal1 = 0; // Metadata: 0x00778B5B
		public const int BlurVertical1 = 1; // Metadata: 0x00778B5F
		public const int BlurHorizontal2 = 2; // Metadata: 0x00778B63
		public const int BlurVertical2 = 3; // Metadata: 0x00778B67
		public const int BlurHorizontal3 = 4; // Metadata: 0x00778B6B
		public const int BlurVertical3 = 5; // Metadata: 0x00778B6F
		public const int BlurHorizontal4 = 6; // Metadata: 0x00778B73
		public const int BlurVertical4 = 7; // Metadata: 0x00778B77
		public const int ApplyDebug = 0; // Metadata: 0x00778B7B
		public const int ApplyDebugTemporal = 1; // Metadata: 0x00778B7F
		public const int ApplyDeferred = 5; // Metadata: 0x00778B83
		public const int ApplyDeferredTemporal = 6; // Metadata: 0x00778B87
		public const int ApplyDeferredLog = 10; // Metadata: 0x00778B8B
		public const int ApplyDeferredLogTemporal = 11; // Metadata: 0x00778B8F
		public const int ApplyPostEffect = 15; // Metadata: 0x00778B93
		public const int ApplyPostEffectTemporal = 16; // Metadata: 0x00778B97
		public const int ApplyPostEffectTemporalMultiply = 20; // Metadata: 0x00778B9B
		public const int ApplyDeferredTemporalMultiply = 21; // Metadata: 0x00778B9F
		public const int OcclusionLow_None = 0; // Metadata: 0x00778BA3
		public const int OcclusionLow_Camera = 1; // Metadata: 0x00778BA7
		public const int OcclusionLow_GBuffer = 2; // Metadata: 0x00778BAB
		public const int OcclusionLow_GBufferOctaEncoded = 3; // Metadata: 0x00778BAF
	}

	private static class PropertyID // TypeDefIndex: 9115
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
		static PropertyID(); // 0x0000000182098100-0x0000000182098550
	}

	// Constructors
	public AmplifyOcclusionBase(); // 0x0000000182092D60-0x0000000182093150
	static AmplifyOcclusionBase(); // 0x0000000182092C60-0x0000000182092D60

	// Methods
	private void createCommandBuffer(ref CmdBuffer aCmdBuffer, string aCmdBufferName, CameraEvent aCameraEvent); // 0x00000001820960D0-0x00000001820961A0
	private void cleanupCommandBuffer(ref CmdBuffer aCmdBuffer); // 0x0000000182093A90-0x0000000182093BB0
	private void createQuadMesh(); // 0x0000000182096310-0x0000000182096850
	private void PerformBlit(CommandBuffer cb, Material mat, int pass); // 0x0000000182091500-0x0000000182091610
	private Material createMaterialWithShaderName(string aShaderName, bool aThroughErrorMsg); // 0x00000001820961A0-0x0000000182096310
	private void checkMaterials(bool aThroughErrorMsg); // 0x0000000182093150-0x00000001820933A0
	private bool checkRenderTextureFormats(); // 0x0000000182093A10-0x0000000182093A90
	private void OnEnable(); // 0x0000000182090E90-0x0000000182091010
	private void Reset(); // 0x0000000182090E40-0x0000000182090E90
	private void OnDisable(); // 0x0000000182090E40-0x0000000182090E90
	private void releaseRT(); // 0x00000001820969B0-0x0000000182096A60
	private void ClearHistory(); // 0x0000000182090D00-0x0000000182090E10
	private bool checkParamsChanged(); // 0x00000001820933A0-0x0000000182093A10
	private void updateParams(); // 0x0000000182096CF0-0x0000000182096D50
	private void Update(); // 0x0000000182092A10-0x0000000182092C60
	private void OnPreRender(); // 0x00000001820910E0-0x0000000182091500
	private void OnPostRender(); // 0x0000000182091010-0x00000001820910E0
	private int safeAllocateTemporaryRT(CommandBuffer cb, string propertyName, int width, int height, RenderTextureFormat format = RenderTextureFormat.Default /* Metadata: 0x00778B17 */, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default /* Metadata: 0x00778B1B */, FilterMode filterMode = FilterMode.Point /* Metadata: 0x00778B1F */); // 0x0000000182096BB0-0x0000000182096C30
	private void safeReleaseTemporaryRT(CommandBuffer cb, int id); // 0x0000000180CF9890-0x0000000180CF98C0
	private RenderTexture safeAllocateRT(string name, int width, int height, RenderTextureFormat format, RenderTextureReadWrite readWrite, FilterMode filterMode = FilterMode.Point /* Metadata: 0x00778B23 */, int antiAliasing = 1 /* Metadata: 0x00778B27 */); // 0x0000000182096A60-0x0000000182096BB0
	private void safeReleaseRT(ref RenderTexture rt); // 0x0000000182096C30-0x0000000182096CF0
	private void BeginSample(CommandBuffer cb, string name); // 0x0000000182090CD0-0x0000000182090D00
	private void EndSample(CommandBuffer cb, string name); // 0x0000000182090E10-0x0000000182090E40
	private void commandBuffer_FillComputeOcclusion(CommandBuffer cb); // 0x00000001820956B0-0x0000000182095D70
	private void commandBuffer_Blur(CommandBuffer cb, RenderTargetIdentifier aSourceRT, int aSourceWidth, int aSourceHeight); // 0x0000000182093BB0-0x0000000182093EA0
	private int getTemporalPass(); // 0x0000000182096850-0x00000001820968C0
	private void commandBuffer_TemporalFilter(CommandBuffer cb); // 0x0000000182095D70-0x00000001820960D0
	private void commandBuffer_FillApplyDeferred(CommandBuffer cb, bool logTarget); // 0x00000001820942A0-0x0000000182095120
	private void commandBuffer_FillApplyPostEffect(CommandBuffer cb); // 0x0000000182095120-0x00000001820956B0
	private void commandBuffer_FillApplyDebug(CommandBuffer cb); // 0x0000000182093EA0-0x00000001820942A0
	private bool isStereoSinglePassEnabled(); // 0x0000000182096950-0x00000001820969B0
	private void UpdateGlobalShaderConstants(); // 0x0000000182092400-0x0000000182092A10
	private void UpdateGlobalShaderConstants_AmbientOcclusion(); // 0x0000000182091610-0x00000001820917B0
	private void UpdateGlobalShaderConstants_Matrices(); // 0x00000001820917B0-0x0000000182092400
}

