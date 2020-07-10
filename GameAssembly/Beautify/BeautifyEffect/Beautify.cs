/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 57: Beautify.dll - Assembly: Beautify, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7239-7251

namespace BeautifyEffect
{
	[AddComponentMenu] // 0x00000001800F5C70-0x00000001800F5D30
	[ExecuteInEditMode] // 0x00000001800F5C70-0x00000001800F5D30
	[HelpURL] // 0x00000001800F5C70-0x00000001800F5D30
	[ImageEffectAllowedInSceneView] // 0x00000001800F5C70-0x00000001800F5D30
	[RequireComponent] // 0x00000001800F5C70-0x00000001800F5D30
	public class Beautify : UnityEngine.MonoBehaviour // TypeDefIndex: 7249
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private BEAUTIFY_PRESET _preset; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private BEAUTIFY_QUALITY _quality; // 0x1C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private BeautifyProfile _profile; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _compareMode; // 0x28
		[Range] // 0x00000001800F6C70-0x00000001800F6CB0
		[SerializeField] // 0x00000001800F6C70-0x00000001800F6CB0
		private float _compareLineAngle; // 0x2C
		[Range] // 0x00000001800F6EE0-0x00000001800F6F20
		[SerializeField] // 0x00000001800F6EE0-0x00000001800F6F20
		private float _compareLineWidth; // 0x30
		[Range] // 0x00000001800F7150-0x00000001800F7190
		[SerializeField] // 0x00000001800F7150-0x00000001800F7190
		private float _dither; // 0x34
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _ditherDepth; // 0x38
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _sharpenMinDepth; // 0x3C
		[Range] // 0x00000001800F77C0-0x00000001800F7800
		[SerializeField] // 0x00000001800F77C0-0x00000001800F7800
		private float _sharpenMaxDepth; // 0x40
		[Range] // 0x00000001800F7A80-0x00000001800F7AC0
		[SerializeField] // 0x00000001800F7A80-0x00000001800F7AC0
		private float _sharpen; // 0x44
		[Range] // 0x00000001800F7D50-0x00000001800F7D90
		[SerializeField] // 0x00000001800F7D50-0x00000001800F7D90
		private float _sharpenDepthThreshold; // 0x48
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Color _tintColor; // 0x4C
		[Range] // 0x00000001800F7150-0x00000001800F7190
		[SerializeField] // 0x00000001800F7150-0x00000001800F7190
		private float _sharpenRelaxation; // 0x5C
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _sharpenClamp; // 0x60
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _sharpenMotionSensibility; // 0x64
		[Range] // 0x00000001800F83D0-0x00000001800F8410
		[SerializeField] // 0x00000001800F83D0-0x00000001800F8410
		private float _saturate; // 0x68
		[Range] // 0x00000001800F8670-0x00000001800F86B0
		[SerializeField] // 0x00000001800F8670-0x00000001800F86B0
		private float _contrast; // 0x6C
		[Range] // 0x00000001800F8910-0x00000001800F8950
		[SerializeField] // 0x00000001800F8910-0x00000001800F8950
		private float _brightness; // 0x70
		[Range] // 0x00000001800F8910-0x00000001800F8950
		[SerializeField] // 0x00000001800F8910-0x00000001800F8950
		private float _daltonize; // 0x74
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _vignetting; // 0x78
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Color _vignettingColor; // 0x7C
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _vignettingFade; // 0x8C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _vignettingCircularShape; // 0x90
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _vignettingAspectRatio; // 0x94
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _vignettingBlink; // 0x98
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Texture2D _vignettingMask; // 0xA0
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _frame; // 0xA8
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Color _frameColor; // 0xAC
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Texture2D _frameMask; // 0xC0
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _lut; // 0xC8
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _lutIntensity; // 0xCC
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Texture2D _lutTexture; // 0xD0
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _nightVision; // 0xD8
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Color _nightVisionColor; // 0xDC
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _outline; // 0xEC
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Color _outlineColor; // 0xF0
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _thermalVision; // 0x100
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _lensDirt; // 0x101
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _lensDirtThreshold; // 0x104
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _lensDirtIntensity; // 0x108
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Texture2D _lensDirtTexture; // 0x110
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _bloom; // 0x118
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private LayerMask _bloomCullingMask; // 0x11C
		[Range] // 0x00000001800FC650-0x00000001800FC690
		[SerializeField] // 0x00000001800FC650-0x00000001800FC690
		private float _bloomLayerMaskDownsampling; // 0x120
		[Range] // 0x00000001800F93B0-0x00000001800F93F0
		[SerializeField] // 0x00000001800F93B0-0x00000001800F93F0
		private float _bloomIntensity; // 0x124
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _bloomMaxBrightness; // 0x128
		[Range] // 0x00000001800FCD60-0x00000001800FCDA0
		[SerializeField] // 0x00000001800FCD60-0x00000001800FCDA0
		private float _bloomBoost0; // 0x12C
		[Range] // 0x00000001800FCD60-0x00000001800FCDA0
		[SerializeField] // 0x00000001800FCD60-0x00000001800FCDA0
		private float _bloomBoost1; // 0x130
		[Range] // 0x00000001800FCD60-0x00000001800FCDA0
		[SerializeField] // 0x00000001800FCD60-0x00000001800FCDA0
		private float _bloomBoost2; // 0x134
		[Range] // 0x00000001800FCD60-0x00000001800FCDA0
		[SerializeField] // 0x00000001800FCD60-0x00000001800FCDA0
		private float _bloomBoost3; // 0x138
		[Range] // 0x00000001800FCD60-0x00000001800FCDA0
		[SerializeField] // 0x00000001800FCD60-0x00000001800FCDA0
		private float _bloomBoost4; // 0x13C
		[Range] // 0x00000001800FCD60-0x00000001800FCDA0
		[SerializeField] // 0x00000001800FCD60-0x00000001800FCDA0
		private float _bloomBoost5; // 0x140
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _bloomAntiflicker; // 0x144
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _bloomUltra; // 0x145
		[Range] // 0x00000001800FDDF0-0x00000001800FDE30
		[SerializeField] // 0x00000001800FDDF0-0x00000001800FDE30
		private float _bloomThreshold; // 0x148
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _bloomCustomize; // 0x14C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _bloomDebug; // 0x14D
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _bloomWeight0; // 0x150
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _bloomWeight1; // 0x154
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _bloomWeight2; // 0x158
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _bloomWeight3; // 0x15C
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _bloomWeight4; // 0x160
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _bloomWeight5; // 0x164
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _bloomBlur; // 0x168
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _bloomDepthAtten; // 0x16C
		[Range] // 0x00000001800FEE90-0x00000001800FEED0
		[SerializeField] // 0x00000001800FEE90-0x00000001800FEED0
		private float _bloomLayerZBias; // 0x170
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _anamorphicFlares; // 0x174
		[Range] // 0x00000001800F93B0-0x00000001800F93F0
		[SerializeField] // 0x00000001800F93B0-0x00000001800F93F0
		private float _anamorphicFlaresIntensity; // 0x178
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _anamorphicFlaresAntiflicker; // 0x17C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _anamorphicFlaresUltra; // 0x17D
		[Range] // 0x00000001800FDDF0-0x00000001800FDE30
		[SerializeField] // 0x00000001800FDDF0-0x00000001800FDE30
		private float _anamorphicFlaresThreshold; // 0x180
		[Range] // 0x00000001800FF9E0-0x00000001800FFA20
		[SerializeField] // 0x00000001800FF9E0-0x00000001800FFA20
		private float _anamorphicFlaresSpread; // 0x184
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _anamorphicFlaresVertical; // 0x188
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Color _anamorphicFlaresTint; // 0x18C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _anamorphicFlaresBlur; // 0x19C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _depthOfField; // 0x19D
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _depthOfFieldTransparencySupport; // 0x19E
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Transform _depthOfFieldTargetFocus; // 0x1A0
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _depthOfFieldDebug; // 0x1A8
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _depthOfFieldAutofocus; // 0x1A9
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _depthOfFieldAutofocusMinDistance; // 0x1AC
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _depthOfFieldAutofocusMaxDistance; // 0x1B0
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private LayerMask _depthOfFieldAutofocusLayerMask; // 0x1B4
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private LayerMask _depthOfFieldExclusionLayerMask; // 0x1B8
		[Range] // 0x00000001800FC650-0x00000001800FC690
		[SerializeField] // 0x00000001800FC650-0x00000001800FC690
		private float _depthOfFieldExclusionLayerMaskDownsampling; // 0x1BC
		[Range] // 0x00000001800FC650-0x00000001800FC690
		[SerializeField] // 0x00000001800FC650-0x00000001800FC690
		private float _depthOfFieldTransparencySupportDownsampling; // 0x1C0
		[Range] // 0x0000000180100DF0-0x0000000180100E30
		[SerializeField] // 0x0000000180100DF0-0x0000000180100E30
		private float _depthOfFieldExclusionBias; // 0x1C4
		[Range] // 0x0000000180101070-0x00000001801010B0
		[SerializeField] // 0x0000000180101070-0x00000001801010B0
		private float _depthOfFieldDistance; // 0x1C8
		[Range] // 0x00000001801011B0-0x00000001801011F0
		[SerializeField] // 0x00000001801011B0-0x00000001801011F0
		private float _depthOfFieldFocusSpeed; // 0x1CC
		[Range] // 0x00000001800E0A30-0x00000001800E0A70
		[SerializeField] // 0x00000001800E0A30-0x00000001800E0A70
		private int _depthOfFieldDownsampling; // 0x1D0
		[Range] // 0x00000001801026D0-0x0000000180102710
		[SerializeField] // 0x00000001801026D0-0x0000000180102710
		private int _depthOfFieldMaxSamples; // 0x1D4
		[Range] // 0x0000000180102980-0x00000001801029C0
		[SerializeField] // 0x0000000180102980-0x00000001801029C0
		private float _depthOfFieldFocalLength; // 0x1D8
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _depthOfFieldAperture; // 0x1DC
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _depthOfFieldForegroundBlur; // 0x1E0
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _depthOfFieldForegroundBlurHQ; // 0x1E1
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _depthOfFieldForegroundDistance; // 0x1E4
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _depthOfFieldBokeh; // 0x1E8
		[Range] // 0x0000000180103040-0x0000000180103080
		[SerializeField] // 0x0000000180103040-0x0000000180103080
		private float _depthOfFieldBokehThreshold; // 0x1EC
		[Range] // 0x00000001801032F0-0x0000000180103330
		[SerializeField] // 0x00000001801032F0-0x0000000180103330
		private float _depthOfFieldBokehIntensity; // 0x1F0
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _depthOfFieldMaxBrightness; // 0x1F4
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private FilterMode _depthOfFieldFilterMode; // 0x1F8
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _eyeAdaptation; // 0x1FC
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _eyeAdaptationMinExposure; // 0x200
		[Range] // 0x0000000180101070-0x00000001801010B0
		[SerializeField] // 0x0000000180101070-0x00000001801010B0
		private float _eyeAdaptationMaxExposure; // 0x204
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _eyeAdaptationSpeedToLight; // 0x208
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _eyeAdaptationSpeedToDark; // 0x20C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _purkinje; // 0x210
		[Range] // 0x00000001800FDDF0-0x00000001800FDE30
		[SerializeField] // 0x00000001800FDDF0-0x00000001800FDE30
		private float _purkinjeAmount; // 0x214
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _purkinjeLuminanceThreshold; // 0x218
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private BEAUTIFY_TMO _tonemap; // 0x21C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _sunFlares; // 0x220
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Transform _sun; // 0x228
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private LayerMask _sunFlaresLayerMask; // 0x230
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _sunFlaresIntensity; // 0x234
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _sunFlaresSolarWindSpeed; // 0x238
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Color _sunFlaresTint; // 0x23C
		[Range] // 0x00000001800E0A30-0x00000001800E0A70
		[SerializeField] // 0x00000001800E0A30-0x00000001800E0A70
		private int _sunFlaresDownsampling; // 0x24C
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _sunFlaresSunIntensity; // 0x250
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _sunFlaresSunDiskSize; // 0x254
		[Range] // 0x00000001800F93B0-0x00000001800F93F0
		[SerializeField] // 0x00000001800F93B0-0x00000001800F93F0
		private float _sunFlaresSunRayDiffractionIntensity; // 0x258
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _sunFlaresSunRayDiffractionThreshold; // 0x25C
		[Range] // 0x00000001800F7150-0x00000001800F7190
		[SerializeField] // 0x00000001800F7150-0x00000001800F7190
		private float _sunFlaresCoronaRays1Length; // 0x260
		[Range] // 0x0000000180105AB0-0x0000000180105AF0
		[SerializeField] // 0x0000000180105AB0-0x0000000180105AF0
		private int _sunFlaresCoronaRays1Streaks; // 0x264
		[Range] // 0x0000000180105D10-0x0000000180105D50
		[SerializeField] // 0x0000000180105D10-0x0000000180105D50
		private float _sunFlaresCoronaRays1Spread; // 0x268
		[Range] // 0x0000000180105F90-0x0000000180105FD0
		[SerializeField] // 0x0000000180105F90-0x0000000180105FD0
		private float _sunFlaresCoronaRays1AngleOffset; // 0x26C
		[Range] // 0x00000001800F7150-0x00000001800F7190
		[SerializeField] // 0x00000001800F7150-0x00000001800F7190
		private float _sunFlaresCoronaRays2Length; // 0x270
		[Range] // 0x0000000180105AB0-0x0000000180105AF0
		[SerializeField] // 0x0000000180105AB0-0x0000000180105AF0
		private int _sunFlaresCoronaRays2Streaks; // 0x274
		[Range] // 0x0000000180105D10-0x0000000180105D50
		[SerializeField] // 0x0000000180105D10-0x0000000180105D50
		private float _sunFlaresCoronaRays2Spread; // 0x278
		[Range] // 0x0000000180105F90-0x0000000180105FD0
		[SerializeField] // 0x0000000180105F90-0x0000000180105FD0
		private float _sunFlaresCoronaRays2AngleOffset; // 0x27C
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _sunFlaresGhosts1Size; // 0x280
		[Range] // 0x0000000180106650-0x0000000180106690
		[SerializeField] // 0x0000000180106650-0x0000000180106690
		private float _sunFlaresGhosts1Offset; // 0x284
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _sunFlaresGhosts1Brightness; // 0x288
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _sunFlaresGhosts2Size; // 0x28C
		[Range] // 0x0000000180106650-0x0000000180106690
		[SerializeField] // 0x0000000180106650-0x0000000180106690
		private float _sunFlaresGhosts2Offset; // 0x290
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _sunFlaresGhosts2Brightness; // 0x294
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _sunFlaresGhosts3Size; // 0x298
		[Range] // 0x0000000180106650-0x0000000180106690
		[SerializeField] // 0x0000000180106650-0x0000000180106690
		private float _sunFlaresGhosts3Brightness; // 0x29C
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _sunFlaresGhosts3Offset; // 0x2A0
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _sunFlaresGhosts4Size; // 0x2A4
		[Range] // 0x0000000180106650-0x0000000180106690
		[SerializeField] // 0x0000000180106650-0x0000000180106690
		private float _sunFlaresGhosts4Offset; // 0x2A8
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _sunFlaresGhosts4Brightness; // 0x2AC
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _sunFlaresHaloOffset; // 0x2B0
		[Range] // 0x0000000180107D90-0x0000000180107DD0
		[SerializeField] // 0x0000000180107D90-0x0000000180107DD0
		private float _sunFlaresHaloAmplitude; // 0x2B4
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float _sunFlaresHaloIntensity; // 0x2B8
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _sunFlaresRotationDeadZone; // 0x2BC
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _blur; // 0x2BD
		[Range] // 0x00000001800E0910-0x00000001800E0950
		[SerializeField] // 0x00000001800E0910-0x00000001800E0950
		private float _blurIntensity; // 0x2C0
		[Range] // 0x0000000180108600-0x0000000180108640
		[SerializeField] // 0x0000000180108600-0x0000000180108640
		private int _pixelateAmount; // 0x2C4
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _pixelateDownscale; // 0x2C8
		[Range] // 0x0000000180108A00-0x0000000180108A40
		[SerializeField] // 0x0000000180108A00-0x0000000180108A40
		private float _antialiasStrength; // 0x2CC
		[Range] // 0x00000001800F7D50-0x00000001800F7D90
		[SerializeField] // 0x00000001800F7D50-0x00000001800F7D90
		private float _antialiasDepthThreshold; // 0x2D0
		public bool isDirty; // 0x2D4
		private static Beautify _beautify; // 0x00
		public const string SKW_BLOOM = "BEAUTIFY_BLOOM"; // Metadata: 0x007415E1
		public const string SKW_LUT = "BEAUTIFY_LUT"; // Metadata: 0x007415F3
		public const string SKW_NIGHT_VISION = "BEAUTIFY_NIGHT_VISION"; // Metadata: 0x00741603
		public const string SKW_THERMAL_VISION = "BEAUTIFY_THERMAL_VISION"; // Metadata: 0x0074161C
		public const string SKW_OUTLINE = "BEAUTIFY_OUTLINE"; // Metadata: 0x00741637
		public const string SKW_FRAME = "BEAUTIFY_FRAME"; // Metadata: 0x0074164B
		public const string SKW_FRAME_MASK = "BEAUTIFY_FRAME_MASK"; // Metadata: 0x0074165D
		public const string SKW_DALTONIZE = "BEAUTIFY_DALTONIZE"; // Metadata: 0x00741674
		public const string SKW_DIRT = "BEAUTIFY_DIRT"; // Metadata: 0x0074168A
		public const string SKW_VIGNETTING = "BEAUTIFY_VIGNETTING"; // Metadata: 0x0074169B
		public const string SKW_VIGNETTING_MASK = "BEAUTIFY_VIGNETTING_MASK"; // Metadata: 0x007416B2
		public const string SKW_DEPTH_OF_FIELD = "BEAUTIFY_DEPTH_OF_FIELD"; // Metadata: 0x007416CE
		public const string SKW_DEPTH_OF_FIELD_TRANSPARENT = "BEAUTIFY_DEPTH_OF_FIELD_TRANSPARENT"; // Metadata: 0x007416E9
		public const string SKW_EYE_ADAPTATION = "BEAUTIFY_EYE_ADAPTATION"; // Metadata: 0x00741710
		public const string SKW_TONEMAP_ACES = "BEAUTIFY_TONEMAP_ACES"; // Metadata: 0x0074172B
		public const string SKW_PURKINJE = "BEAUTIFY_PURKINJE"; // Metadata: 0x00741744
		public const string SKW_BLOOM_USE_DEPTH = "BEAUTIFY_BLOOM_USE_DEPTH"; // Metadata: 0x00741759
		public const string SKW_BLOOM_USE_LAYER = "BEAUTIFY_BLOOM_USE_LAYER"; // Metadata: 0x00741775
		private Material bMatDesktop; // 0x2D8
		private Material bMatMobile; // 0x2E0
		private Material bMatBasic; // 0x2E8
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Material bMat; // 0x2F0
		private Camera currentCamera; // 0x2F8
		private Vector3 camPrevForward; // 0x300
		private Vector3 camPrevPos; // 0x30C
		private float currSens; // 0x318
		private int renderPass; // 0x31C
		private RenderTextureFormat rtFormat; // 0x320
		private RenderTexture[] rt; // 0x328
		private RenderTexture[] rtAF; // 0x330
		private RenderTexture[] rtEA; // 0x338
		private RenderTexture rtEAacum; // 0x340
		private RenderTexture rtEAHist; // 0x348
		private float dofPrevDistance; // 0x350
		private float dofLastAutofocusDistance; // 0x354
		private Vector4 dofLastBokehData; // 0x358
		private Camera sceneCamera; // 0x368
		private Camera depthCam; // 0x370
		private GameObject depthCamObj; // 0x378
		private List<string> shaderKeywords; // 0x380
		private Shader depthShader; // 0x388
		private Shader dofExclusionShader; // 0x390
		private bool shouldUpdateMaterialProperties; // 0x398
		private const string BEAUTIFY_BUILD_HINT = "BeautifyBuildHint70b3"; // Metadata: 0x00741791
		private float sunFlareCurrentIntensity; // 0x39C
		private Vector4 sunLastScrPos; // 0x3A0
		private float sunLastRot; // 0x3B0
		private Texture2D flareNoise; // 0x3B8
		private RenderTexture dofDepthTexture; // 0x3C0
		private RenderTexture dofExclusionTexture; // 0x3C8
		private RenderTexture bloomSourceTexture; // 0x3D0
		private RenderTexture bloomSourceDepthTexture; // 0x3D8
		private RenderTexture pixelateTexture; // 0x3E0
		private RenderTextureDescriptor rtDescBase; // 0x3E8
		private float sunFlareTime; // 0x418
		private int dofCurrentLayerMaskValue; // 0x41C
	
		// Properties
		public BEAUTIFY_PRESET preset { get; set; } // 0x0000000180367710-0x0000000180367720 0x0000000182273760-0x00000001822737A0
		public BEAUTIFY_QUALITY quality { get; set; } // 0x000000018037E420-0x000000018037E430 0x0000000182273A10-0x0000000182273AA0
		public BeautifyProfile profile { get; set; } // 0x000000018036AC70-0x000000018036AC80 0x00000001822737A0-0x0000000182273870
		public bool compareMode { get; set; } // 0x00000001803A2790-0x00000001803A27A0 0x0000000182271FF0-0x0000000182272030
		public float compareLineAngle { get; set; } // 0x0000000180487D70-0x0000000180487D80 0x0000000182271F50-0x0000000182271FA0
		public float compareLineWidth { get; set; } // 0x0000000180485990-0x00000001804859A0 0x0000000182271FA0-0x0000000182271FF0
		public float dither { get; set; } // 0x00000001804C16A0-0x00000001804C16B0 0x0000000182272D80-0x0000000182272DD0
		public float ditherDepth { get; set; } // 0x0000000180487DD0-0x0000000180487DE0 0x0000000182272D30-0x0000000182272D80
		public float sharpenMinDepth { get; set; } // 0x0000000180E426C0-0x0000000180E426D0 0x0000000182273BE0-0x0000000182273C30
		public float sharpenMaxDepth { get; set; } // 0x0000000180487DB0-0x0000000180487DC0 0x0000000182273B90-0x0000000182273BE0
		public float sharpen { get; set; } // 0x0000000180487D40-0x0000000180487D50 0x0000000182273CD0-0x0000000182273D20
		public float sharpenDepthThreshold { get; set; } // 0x0000000180487CC0-0x0000000180487CD0 0x0000000182273B40-0x0000000182273B90
		public Color tintColor { get; set; } // 0x00000001822711A0-0x00000001822711B0 0x0000000182274990-0x0000000182274A00
		public float sharpenRelaxation { get; set; } // 0x0000000180487CB0-0x0000000180487CC0 0x0000000182273C80-0x0000000182273CD0
		public float sharpenClamp { get; set; } // 0x0000000180487CD0-0x0000000180487CE0 0x0000000182273AF0-0x0000000182273B40
		public float sharpenMotionSensibility { get; set; } // 0x0000000180487D10-0x0000000180487D20 0x0000000182273C30-0x0000000182273C80
		public float saturate { get; set; } // 0x0000000180487D00-0x0000000180487D10 0x0000000182273AA0-0x0000000182273AF0
		public float contrast { get; set; } // 0x0000000180EF1650-0x0000000180EF1660 0x0000000182272030-0x0000000182272080
		public float brightness { get; set; } // 0x0000000181128C90-0x0000000181128CA0 0x0000000182271F00-0x0000000182271F50
		public float daltonize { get; set; } // 0x0000000181411C40-0x0000000181411C50 0x0000000182272080-0x00000001822720D0
		public bool vignetting { get; set; } // 0x00000001804A2540-0x00000001804A2550 0x0000000182274CB0-0x0000000182274CF0
		public Color vignettingColor { get; set; } // 0x00000001813639F0-0x0000000181363A00 0x0000000182274B40-0x0000000182274BB0
		public float vignettingFade { get; set; } // 0x0000000181027850-0x0000000181027860 0x0000000182274BB0-0x0000000182274C00
		public bool vignettingCircularShape { get; set; } // 0x0000000180369C50-0x0000000180369C60 0x0000000182274B00-0x0000000182274B40
		public float vignettingAspectRatio { get; set; } // 0x00000001822711C0-0x00000001822711D0 0x0000000182274A60-0x0000000182274AB0
		public float vignettingBlink { get; set; } // 0x0000000181128CA0-0x0000000181128CB0 0x0000000182274AB0-0x0000000182274B00
		public Texture2D vignettingMask { get; set; } // 0x0000000180382AA0-0x0000000180382AB0 0x0000000182274C00-0x0000000182274CB0
		public bool frame { get; set; } // 0x000000018073CF80-0x000000018073CF90 0x00000001822731D0-0x0000000182273210
		public Color frameColor { get; set; } // 0x0000000182270DB0-0x0000000182270DC0 0x00000001822730A0-0x0000000182273120
		public Texture2D frameMask { get; set; } // 0x00000001804A1050-0x00000001804A1060 0x0000000182273120-0x00000001822731D0
		public bool lut { get; set; } // 0x00000001804E7B40-0x00000001804E7B50 0x00000001822734A0-0x00000001822734F0
		public float lutIntensity { get; set; } // 0x0000000182270F20-0x0000000182270F30 0x00000001822733A0-0x00000001822733F0
		public Texture2D lutTexture { get; set; } // 0x00000001804A24D0-0x00000001804A24E0 0x00000001822733F0-0x00000001822734A0
		public bool nightVision { get; set; } // 0x00000001809336D0-0x00000001809336E0 0x0000000182273570-0x0000000182273620
		public Color nightVisionColor { get; set; } // 0x0000000182270F30-0x0000000182270F40 0x00000001822734F0-0x0000000182273570
		public bool outline { get; set; } // 0x0000000182270F50-0x0000000182270F60 0x00000001822736A0-0x00000001822736E0
		public Color outlineColor { get; set; } // 0x0000000182270F40-0x0000000182270F50 0x0000000182273620-0x00000001822736A0
		public bool thermalVision { get; set; } // 0x00000001804E99C0-0x00000001804E99D0 0x00000001822748E0-0x0000000182274990
		public bool lensDirt { get; set; } // 0x0000000180CB7790-0x0000000180CB77A0 0x0000000182273360-0x00000001822733A0
		public float lensDirtThreshold { get; set; } // 0x000000018122A4B0-0x000000018122A4C0 0x0000000182273310-0x0000000182273360
		public float lensDirtIntensity { get; set; } // 0x0000000182270F10-0x0000000182270F20 0x0000000182273210-0x0000000182273260
		public Texture2D lensDirtTexture { get; set; } // 0x00000001803BD380-0x00000001803BD390 0x0000000182273260-0x0000000182273310
		public bool bloom { get; set; } // 0x0000000182270BC0-0x0000000182270BD0 0x0000000182271E30-0x0000000182271E70
		public LayerMask bloomCullingMask { get; set; } // 0x0000000180641670-0x0000000180641680 0x00000001822717D0-0x0000000182271850
		public float bloomLayerMaskDownsampling { get; set; } // 0x0000000182270B70-0x0000000182270B80 0x00000001822719C0-0x0000000182271A70
		public float bloomIntensity { get; set; } // 0x0000000182270B60-0x0000000182270B70 0x0000000182271920-0x00000001822719C0
		public float bloomMaxBrightness { get; set; } // 0x00000001810E24F0-0x00000001810E2500 0x0000000182271B20-0x0000000182271BC0
		public float bloomBoost0 { get; set; } // 0x0000000182270B20-0x0000000182270B30 0x00000001822715F0-0x0000000182271640
		public float bloomBoost1 { get; set; } // 0x00000001806416E0-0x00000001806416F0 0x0000000182271640-0x0000000182271690
		public float bloomBoost2 { get; set; } // 0x0000000182270B30-0x0000000182270B40 0x0000000182271690-0x00000001822716E0
		public float bloomBoost3 { get; set; } // 0x0000000181441620-0x0000000181441630 0x00000001822716E0-0x0000000182271730
		public float bloomBoost4 { get; set; } // 0x0000000181441630-0x0000000181441640 0x0000000182271730-0x0000000182271780
		public float bloomBoost5 { get; set; } // 0x000000018122C460-0x000000018122C470 0x0000000182271780-0x00000001822717D0
		public bool bloomAntiflicker { get; set; } // 0x0000000182270B10-0x0000000182270B20 0x0000000182271570-0x00000001822715B0
		public bool bloomUltra { get; set; } // 0x0000000182270B90-0x0000000182270BA0 0x0000000182271C10-0x0000000182271C50
		public float bloomThreshold { get; set; } // 0x0000000182270B80-0x0000000182270B90 0x0000000182271BC0-0x0000000182271C10
		public bool bloomCustomize { get; set; } // 0x0000000182270B40-0x0000000182270B50 0x0000000182271850-0x0000000182271890
		public bool bloomDebug { get; set; } // 0x0000000182270B50-0x0000000182270B60 0x0000000182271890-0x00000001822718D0
		public float bloomWeight0 { get; set; } // 0x00000001810E2340-0x00000001810E2350 0x0000000182271C50-0x0000000182271CA0
		public float bloomWeight1 { get; set; } // 0x000000018123F530-0x000000018123F540 0x0000000182271CA0-0x0000000182271CF0
		public float bloomWeight2 { get; set; } // 0x0000000181441680-0x0000000181441690 0x0000000182271CF0-0x0000000182271D40
		public float bloomWeight3 { get; set; } // 0x0000000182270BA0-0x0000000182270BB0 0x0000000182271D40-0x0000000182271D90
		public float bloomWeight4 { get; set; } // 0x00000001814416B0-0x00000001814416C0 0x0000000182271D90-0x0000000182271DE0
		public float bloomWeight5 { get; set; } // 0x0000000182270BB0-0x0000000182270BC0 0x0000000182271DE0-0x0000000182271E30
		public bool bloomBlur { get; set; } // 0x00000001819202A0-0x00000001819202B0 0x00000001822715B0-0x00000001822715F0
		public float bloomDepthAtten { get; set; } // 0x00000001819203A0-0x00000001819203B0 0x00000001822718D0-0x0000000182271920
		public float bloomLayerZBias { get; set; } // 0x00000001813EB630-0x00000001813EB640 0x0000000182271A70-0x0000000182271B20
		public bool anamorphicFlares { get; set; } // 0x0000000181920330-0x0000000181920340 0x0000000182271490-0x00000001822714D0
		public float anamorphicFlaresIntensity { get; set; } // 0x0000000182270AA0-0x0000000182270AB0 0x0000000182271250-0x00000001822712F0
		public bool anamorphicFlaresAntiflicker { get; set; } // 0x0000000182270A90-0x0000000182270AA0 0x00000001822711D0-0x0000000182271210
		public bool anamorphicFlaresUltra { get; set; } // 0x0000000182270AE0-0x0000000182270AF0 0x0000000182271410-0x0000000182271450
		public float anamorphicFlaresThreshold { get; set; } // 0x0000000182270AC0-0x0000000182270AD0 0x0000000182271340-0x0000000182271390
		public float anamorphicFlaresSpread { get; set; } // 0x0000000182270AB0-0x0000000182270AC0 0x00000001822712F0-0x0000000182271340
		public bool anamorphicFlaresVertical { get; set; } // 0x000000018191A060-0x000000018191A070 0x0000000182271450-0x0000000182271490
		public Color anamorphicFlaresTint { get; set; } // 0x0000000182270AD0-0x0000000182270AE0 0x0000000182271390-0x0000000182271410
		public bool anamorphicFlaresBlur { get; set; } // 0x0000000181919C90-0x0000000181919CA0 0x0000000182271210-0x0000000182271250
		public bool depthOfField { get; set; } // 0x0000000182270D50-0x0000000182270D60 0x0000000182272CF0-0x0000000182272D30
		public bool depthOfFieldTransparencySupport { get; set; } // 0x0000000182270D40-0x0000000182270D50 0x0000000182272CB0-0x0000000182272CF0
		public Transform depthOfFieldTargetFocus { get; set; } // 0x0000000182270D20-0x0000000182270D30 0x0000000182272B50-0x0000000182272C00
		public bool depthOfFieldDebug { get; set; } // 0x0000000182270C60-0x0000000182270C70 0x0000000182272450-0x0000000182272490
		public bool depthOfFieldAutofocus { get; set; } // 0x0000000182270C20-0x0000000182270C30 0x0000000182272290-0x00000001822722D0
		public float depthOfFieldAutofocusMinDistance { get; set; } // 0x0000000182270C10-0x0000000182270C20 0x0000000182272240-0x0000000182272290
		public float depthOfFieldAutofocusMaxDistance { get; set; } // 0x0000000180F0FB80-0x0000000180F0FB90 0x00000001822721F0-0x0000000182272240
		public LayerMask depthOfFieldAutofocusLayerMask { get; set; } // 0x0000000182270C00-0x0000000182270C10 0x0000000182272170-0x00000001822721F0
		public LayerMask depthOfFieldExclusionLayerMask { get; set; } // 0x0000000182270CB0-0x0000000182270CC0 0x0000000182272730-0x00000001822727B0
		public float depthOfFieldExclusionLayerMaskDownsampling { get; set; } // 0x0000000182270CA0-0x0000000182270CB0 0x0000000182272680-0x0000000182272730
		public float depthOfFieldTransparencySupportDownsampling { get; set; } // 0x0000000182270D30-0x0000000182270D40 0x0000000182272C00-0x0000000182272CB0
		public float depthOfFieldExclusionBias { get; set; } // 0x0000000182270C90-0x0000000182270CA0 0x00000001822725E0-0x0000000182272680
		public float depthOfFieldDistance { get; set; } // 0x0000000182270C70-0x0000000182270C80 0x0000000182272490-0x0000000182272540
		public float depthOfFieldFocusSpeed { get; set; } // 0x0000000182270CE0-0x0000000182270CF0 0x0000000182272890-0x0000000182272940
		public int depthOfFieldDownsampling { get; set; } // 0x0000000182270C80-0x0000000182270C90 0x0000000182272540-0x00000001822725E0
		public int depthOfFieldMaxSamples { get; set; } // 0x00000001810E1F10-0x00000001810E1F20 0x0000000182272AB0-0x0000000182272B50
		public float depthOfFieldFocalLength { get; set; } // 0x0000000182270CD0-0x0000000182270CE0 0x00000001822727F0-0x0000000182272890
		public float depthOfFieldAperture { get; set; } // 0x0000000182270BF0-0x0000000182270C00 0x00000001822720D0-0x0000000182272170
		public bool depthOfFieldForegroundBlur { get; set; } // 0x0000000181A3C6A0-0x0000000181A3C6B0 0x0000000182272980-0x00000001822729C0
		public bool depthOfFieldForegroundBlurHQ { get; set; } // 0x0000000182270CF0-0x0000000182270D00 0x0000000182272940-0x0000000182272980
		public float depthOfFieldForegroundDistance { get; set; } // 0x0000000182270D00-0x0000000182270D10 0x00000001822729C0-0x0000000182272A10
		public bool depthOfFieldBokeh { get; set; } // 0x0000000182270C50-0x0000000182270C60 0x0000000182272410-0x0000000182272450
		public float depthOfFieldBokehThreshold { get; set; } // 0x0000000182270C40-0x0000000182270C50 0x0000000182272370-0x0000000182272410
		public float depthOfFieldBokehIntensity { get; set; } // 0x0000000182270C30-0x0000000182270C40 0x00000001822722D0-0x0000000182272370
		public float depthOfFieldMaxBrightness { get; set; } // 0x0000000182270D10-0x0000000182270D20 0x0000000182272A10-0x0000000182272AB0
		public FilterMode depthOfFieldFilterMode { get; set; } // 0x0000000182270CC0-0x0000000182270CD0 0x00000001822727B0-0x00000001822727F0
		public bool eyeAdaptation { get; set; } // 0x0000000182270DA0-0x0000000182270DB0 0x0000000182273060-0x00000001822730A0
		public float eyeAdaptationMinExposure { get; set; } // 0x0000000182270D70-0x0000000182270D80 0x0000000182272E80-0x0000000182272F20
		public float eyeAdaptationMaxExposure { get; set; } // 0x0000000182270D60-0x0000000182270D70 0x0000000182272DD0-0x0000000182272E80
		public float eyeAdaptationSpeedToLight { get; set; } // 0x0000000182270D90-0x0000000182270DA0 0x0000000182272FC0-0x0000000182273060
		public float eyeAdaptationSpeedToDark { get; set; } // 0x0000000182270D80-0x0000000182270D90 0x0000000182272F20-0x0000000182272FC0
		public bool purkinje { get; set; } // 0x00000001811C6E60-0x00000001811C6E70 0x00000001822739D0-0x0000000182273A10
		public float purkinjeAmount { get; set; } // 0x0000000182270F80-0x0000000182270F90 0x0000000182273870-0x0000000182273920
		public float purkinjeLuminanceThreshold { get; set; } // 0x0000000182270F90-0x0000000182270FA0 0x0000000182273920-0x00000001822739D0
		public BEAUTIFY_TMO tonemap { get; set; } // 0x00000001822711B0-0x00000001822711C0 0x0000000182274A00-0x0000000182274A60
		public bool sunFlares { get; set; } // 0x0000000182271180-0x0000000182271190 0x00000001822747F0-0x0000000182274830
		public Transform sun { get; set; } // 0x0000000182271190-0x00000001822711A0 0x0000000182274830-0x00000001822748E0
		public LayerMask sunFlaresLayerMask { get; set; } // 0x0000000182271100-0x0000000182271110 0x0000000182274520-0x00000001822745A0
		public float sunFlaresIntensity { get; set; } // 0x00000001822710F0-0x0000000182271100 0x00000001822744D0-0x0000000182274520
		public float sunFlaresSolarWindSpeed { get; set; } // 0x0000000182271120-0x0000000182271130 0x00000001822745E0-0x0000000182274630
		public Color sunFlaresTint { get; set; } // 0x0000000182271170-0x0000000182271180 0x0000000182274770-0x00000001822747F0
		public int sunFlaresDownsampling { get; set; } // 0x0000000182271010-0x0000000182271020 0x0000000182273F80-0x0000000182274020
		public float sunFlaresSunIntensity { get; set; } // 0x0000000182271140-0x0000000182271150 0x0000000182274680-0x00000001822746D0
		public float sunFlaresSunDiskSize { get; set; } // 0x0000000182271130-0x0000000182271140 0x0000000182274630-0x0000000182274680
		public float sunFlaresSunRayDiffractionIntensity { get; set; } // 0x0000000182271150-0x0000000182271160 0x00000001822746D0-0x0000000182274720
		public float sunFlaresSunRayDiffractionThreshold { get; set; } // 0x0000000182271160-0x0000000182271170 0x0000000182274720-0x0000000182274770
		public float sunFlaresCoronaRays1Length { get; set; } // 0x0000000182270FB0-0x0000000182270FC0 0x0000000182273D70-0x0000000182273DC0
		public int sunFlaresCoronaRays1Streaks { get; set; } // 0x0000000182270FD0-0x0000000182270FE0 0x0000000182273E10-0x0000000182273E50
		public float sunFlaresCoronaRays1Spread { get; set; } // 0x0000000182270FC0-0x0000000182270FD0 0x0000000182273DC0-0x0000000182273E10
		public float sunFlaresCoronaRays1AngleOffset { get; set; } // 0x0000000182270FA0-0x0000000182270FB0 0x0000000182273D20-0x0000000182273D70
		public float sunFlaresCoronaRays2Length { get; set; } // 0x0000000182270FF0-0x0000000182271000 0x0000000182273EA0-0x0000000182273EF0
		public int sunFlaresCoronaRays2Streaks { get; set; } // 0x0000000182271000-0x0000000182271010 0x0000000182273F40-0x0000000182273F80
		public float sunFlaresCoronaRays2Spread { get; set; } // 0x00000001811C69F0-0x00000001811C6A00 0x0000000182273EF0-0x0000000182273F40
		public float sunFlaresCoronaRays2AngleOffset { get; set; } // 0x0000000182270FE0-0x0000000182270FF0 0x0000000182273E50-0x0000000182273EA0
		public float sunFlaresGhosts1Size { get; set; } // 0x0000000182271040-0x0000000182271050 0x00000001822740C0-0x0000000182274110
		public float sunFlaresGhosts1Offset { get; set; } // 0x0000000182271030-0x0000000182271040 0x0000000182274070-0x00000001822740C0
		public float sunFlaresGhosts1Brightness { get; set; } // 0x0000000182271020-0x0000000182271030 0x0000000182274020-0x0000000182274070
		public float sunFlaresGhosts2Size { get; set; } // 0x0000000182271060-0x0000000182271070 0x00000001822741B0-0x0000000182274200
		public float sunFlaresGhosts2Offset { get; set; } // 0x000000018123F2E0-0x000000018123F2F0 0x0000000182274160-0x00000001822741B0
		public float sunFlaresGhosts2Brightness { get; set; } // 0x0000000182271050-0x0000000182271060 0x0000000182274110-0x0000000182274160
		public float sunFlaresGhosts3Size { get; set; } // 0x0000000182271090-0x00000001822710A0 0x00000001822742A0-0x00000001822742F0
		public float sunFlaresGhosts3Brightness { get; set; } // 0x0000000182271070-0x0000000182271080 0x0000000182274200-0x0000000182274250
		public float sunFlaresGhosts3Offset { get; set; } // 0x0000000182271080-0x0000000182271090 0x0000000182274250-0x00000001822742A0
		public float sunFlaresGhosts4Size { get; set; } // 0x00000001822710C0-0x00000001822710D0 0x0000000182274390-0x00000001822743E0
		public float sunFlaresGhosts4Offset { get; set; } // 0x00000001822710B0-0x00000001822710C0 0x0000000182274340-0x0000000182274390
		public float sunFlaresGhosts4Brightness { get; set; } // 0x00000001822710A0-0x00000001822710B0 0x00000001822742F0-0x0000000182274340
		public float sunFlaresHaloOffset { get; set; } // 0x00000001822710E0-0x00000001822710F0 0x0000000182274480-0x00000001822744D0
		public float sunFlaresHaloAmplitude { get; set; } // 0x00000001822710D0-0x00000001822710E0 0x00000001822743E0-0x0000000182274430
		public float sunFlaresHaloIntensity { get; set; } // 0x00000001811C6790-0x00000001811C67A0 0x0000000182274430-0x0000000182274480
		public bool sunFlaresRotationDeadZone { get; set; } // 0x0000000182271110-0x0000000182271120 0x00000001822745A0-0x00000001822745E0
		public bool blur { get; set; } // 0x0000000182270BE0-0x0000000182270BF0 0x0000000182271EC0-0x0000000182271F00
		public float blurIntensity { get; set; } // 0x0000000182270BD0-0x0000000182270BE0 0x0000000182271E70-0x0000000182271EC0
		public int pixelateAmount { get; set; } // 0x0000000182270F60-0x0000000182270F70 0x00000001822736E0-0x0000000182273720
		public bool pixelateDownscale { get; set; } // 0x0000000182270F70-0x0000000182270F80 0x0000000182273720-0x0000000182273760
		public float antialiasStrength { get; set; } // 0x0000000182270B00-0x0000000182270B10 0x0000000182271520-0x0000000182271570
		public float antialiasDepthThreshold { get; set; } // 0x0000000182270AF0-0x0000000182270B00 0x00000001822714D0-0x0000000182271520
		public static Beautify instance { get; } // 0x0000000182270DC0-0x0000000182270F10 
		public Camera cameraEffect { get; } // 0x00000001811C6BD0-0x00000001811C6BE0 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <DoBlink>d__699 : IEnumerator<object> // TypeDefIndex: 7250
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public float duration; // 0x20
			public Beautify <>4__this; // 0x28
			public float maxValue; // 0x30
			private float <start>5__2; // 0x34
			private float <t>5__3; // 0x38
			private WaitForEndOfFrame <w>5__4; // 0x40
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <DoBlink>d__699(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000182276CA0-0x0000000182276ED0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000182276ED0-0x0000000182276F20
		}
	
		// Constructors
		public Beautify(); // 0x0000000182270540-0x0000000182270A90
	
		// Methods
		private void OnEnable(); // 0x000000018226A0F0-0x000000018226A190
		private void OnDestroy(); // 0x0000000182269E40-0x000000018226A0E0
		private void Reset(); // 0x000000018226DE50-0x000000018226DE60
		private void LateUpdate(); // 0x0000000182269A50-0x0000000182269E40
		private void OnPreCull(); // 0x000000018226A290-0x000000018226A440
		private void OnPreRender(); // 0x000000018226A440-0x000000018226A650
		private void CleanUpRT(); // 0x0000000182269460-0x0000000182269620
		private void CheckDoFTransparencySupport(); // 0x0000000182268FE0-0x0000000182269460
		private void CheckDoFExclusionMask(); // 0x0000000182268B60-0x0000000182268FE0
		private void CheckBloomCullingLayer(); // 0x00000001822685A0-0x0000000182268B60
		protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination); // 0x000000018226A650-0x000000018226DE50
		private void OnPostRender(); // 0x000000018226A190-0x000000018226A290
		private void BlurThis(RenderTexture rt, float blurScale = 1f /* Metadata: 0x007415CD */); // 0x0000000182268430-0x00000001822685A0
		private void BlurThisDownscaling(RenderTexture rt, RenderTexture downscaled, float blurScale = 1f /* Metadata: 0x007415D1 */); // 0x0000000182268070-0x00000001822682C0
		private RenderTexture BlurThisOneDirection(RenderTexture rt, bool vertical, float blurScale = 1f /* Metadata: 0x007415D5 */); // 0x00000001822682C0-0x0000000182268430
		private void BlurThisDoF(RenderTexture rt, int renderPass); // 0x0000000182267DF0-0x0000000182268070
		private void BlurThisAlpha(RenderTexture rt, float blurScale = 1f /* Metadata: 0x007415D9 */); // 0x0000000182267C80-0x0000000182267DF0
		private void OnDidApplyAnimationProperties(); // 0x000000018226A0E0-0x000000018226A0F0
		public void UpdateQualitySettings(); // 0x0000000182270430-0x0000000182270490
		public void UpdateMaterialProperties(); // 0x0000000182270400-0x0000000182270430
		public void UpdateMaterialPropertiesNow(); // 0x000000018226E790-0x0000000182270400
		private void UpdateMaterialBloomIntensityAndThreshold(); // 0x000000018226E6B0-0x000000018226E790
		private void UpdateMaterialAnamorphicIntensityAndThreshold(); // 0x000000018226E5E0-0x000000018226E6B0
		private void UpdateSharpenParams(float sharpen); // 0x0000000182270490-0x0000000182270540
		private void UpdateDepthOfFieldData(); // 0x000000018226DF40-0x000000018226E3A0
		private void UpdateDepthOfFieldBlurData(Vector2 blurDir); // 0x000000018226DE60-0x000000018226DF40
		private void UpdateDoFAutofocusDistance(); // 0x000000018226E3A0-0x000000018226E5E0
		public Texture2D GenerateSepiaLUT(); // 0x00000001822696A0-0x0000000182269A50
		public void Blink(float duration, float maxValue = 1f /* Metadata: 0x007415DD */); // 0x0000000182267BE0-0x0000000182267C80
		[IteratorStateMachine] // 0x0000000180109190-0x00000001801091E0
		private IEnumerator DoBlink(float duration, float maxValue); // 0x0000000182269620-0x00000001822696A0
	}
}
