/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Beautify.dll - Assembly: Beautify, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7405-7417

namespace BeautifyEffect
{
	[AddComponentMenu] // 0x00000001802575C0-0x0000000180257680
	[ExecuteInEditMode] // 0x00000001802575C0-0x0000000180257680
	[HelpURL] // 0x00000001802575C0-0x0000000180257680
	[ImageEffectAllowedInSceneView] // 0x00000001802575C0-0x0000000180257680
	[RequireComponent] // 0x00000001802575C0-0x0000000180257680
	public class Beautify : UnityEngine.MonoBehaviour // TypeDefIndex: 7415
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private BEAUTIFY_PRESET _preset; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private BEAUTIFY_QUALITY _quality; // 0x1C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private BeautifyProfile _profile; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _compareMode; // 0x28
		[Range] // 0x0000000180257DA0-0x0000000180257DE0
		[SerializeField] // 0x0000000180257DA0-0x0000000180257DE0
		private float _compareLineAngle; // 0x2C
		[Range] // 0x00000001802580D0-0x0000000180258110
		[SerializeField] // 0x00000001802580D0-0x0000000180258110
		private float _compareLineWidth; // 0x30
		[Range] // 0x000000018020C740-0x000000018020C780
		[SerializeField] // 0x000000018020C740-0x000000018020C780
		private float _dither; // 0x34
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _ditherDepth; // 0x38
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _sharpenMinDepth; // 0x3C
		[Range] // 0x00000001802589C0-0x0000000180258A00
		[SerializeField] // 0x00000001802589C0-0x0000000180258A00
		private float _sharpenMaxDepth; // 0x40
		[Range] // 0x0000000180258BF0-0x0000000180258C30
		[SerializeField] // 0x0000000180258BF0-0x0000000180258C30
		private float _sharpen; // 0x44
		[Range] // 0x0000000180258E10-0x0000000180258E50
		[SerializeField] // 0x0000000180258E10-0x0000000180258E50
		private float _sharpenDepthThreshold; // 0x48
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Color _tintColor; // 0x4C
		[Range] // 0x000000018020C740-0x000000018020C780
		[SerializeField] // 0x000000018020C740-0x000000018020C780
		private float _sharpenRelaxation; // 0x5C
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _sharpenClamp; // 0x60
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _sharpenMotionSensibility; // 0x64
		[Range] // 0x00000001802598E0-0x0000000180259920
		[SerializeField] // 0x00000001802598E0-0x0000000180259920
		private float _saturate; // 0x68
		[Range] // 0x0000000180259B50-0x0000000180259B90
		[SerializeField] // 0x0000000180259B50-0x0000000180259B90
		private float _contrast; // 0x6C
		[Range] // 0x0000000180259D50-0x0000000180259D90
		[SerializeField] // 0x0000000180259D50-0x0000000180259D90
		private float _brightness; // 0x70
		[Range] // 0x0000000180259D50-0x0000000180259D90
		[SerializeField] // 0x0000000180259D50-0x0000000180259D90
		private float _daltonize; // 0x74
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _vignetting; // 0x78
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Color _vignettingColor; // 0x7C
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _vignettingFade; // 0x8C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _vignettingCircularShape; // 0x90
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _vignettingAspectRatio; // 0x94
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _vignettingBlink; // 0x98
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Texture2D _vignettingMask; // 0xA0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _frame; // 0xA8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Color _frameColor; // 0xAC
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Texture2D _frameMask; // 0xC0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _lut; // 0xC8
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _lutIntensity; // 0xCC
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Texture2D _lutTexture; // 0xD0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _nightVision; // 0xD8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Color _nightVisionColor; // 0xDC
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _outline; // 0xEC
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Color _outlineColor; // 0xF0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _thermalVision; // 0x100
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _lensDirt; // 0x101
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _lensDirtThreshold; // 0x104
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _lensDirtIntensity; // 0x108
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Texture2D _lensDirtTexture; // 0x110
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _bloom; // 0x118
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private LayerMask _bloomCullingMask; // 0x11C
		[Range] // 0x000000018025D7A0-0x000000018025D7E0
		[SerializeField] // 0x000000018025D7A0-0x000000018025D7E0
		private float _bloomLayerMaskDownsampling; // 0x120
		[Range] // 0x00000001801EAD10-0x00000001801EAD50
		[SerializeField] // 0x00000001801EAD10-0x00000001801EAD50
		private float _bloomIntensity; // 0x124
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _bloomMaxBrightness; // 0x128
		[Range] // 0x000000018025DA60-0x000000018025DAA0
		[SerializeField] // 0x000000018025DA60-0x000000018025DAA0
		private float _bloomBoost0; // 0x12C
		[Range] // 0x000000018025DA60-0x000000018025DAA0
		[SerializeField] // 0x000000018025DA60-0x000000018025DAA0
		private float _bloomBoost1; // 0x130
		[Range] // 0x000000018025DA60-0x000000018025DAA0
		[SerializeField] // 0x000000018025DA60-0x000000018025DAA0
		private float _bloomBoost2; // 0x134
		[Range] // 0x000000018025DA60-0x000000018025DAA0
		[SerializeField] // 0x000000018025DA60-0x000000018025DAA0
		private float _bloomBoost3; // 0x138
		[Range] // 0x000000018025DA60-0x000000018025DAA0
		[SerializeField] // 0x000000018025DA60-0x000000018025DAA0
		private float _bloomBoost4; // 0x13C
		[Range] // 0x000000018025DA60-0x000000018025DAA0
		[SerializeField] // 0x000000018025DA60-0x000000018025DAA0
		private float _bloomBoost5; // 0x140
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _bloomAntiflicker; // 0x144
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _bloomUltra; // 0x145
		[Range] // 0x000000018025E7A0-0x000000018025E7E0
		[SerializeField] // 0x000000018025E7A0-0x000000018025E7E0
		private float _bloomThreshold; // 0x148
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _bloomCustomize; // 0x14C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _bloomDebug; // 0x14D
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _bloomWeight0; // 0x150
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _bloomWeight1; // 0x154
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _bloomWeight2; // 0x158
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _bloomWeight3; // 0x15C
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _bloomWeight4; // 0x160
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _bloomWeight5; // 0x164
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _bloomBlur; // 0x168
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _bloomDepthAtten; // 0x16C
		[Range] // 0x000000018025FB70-0x000000018025FBB0
		[SerializeField] // 0x000000018025FB70-0x000000018025FBB0
		private float _bloomLayerZBias; // 0x170
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _anamorphicFlares; // 0x174
		[Range] // 0x00000001801EAD10-0x00000001801EAD50
		[SerializeField] // 0x00000001801EAD10-0x00000001801EAD50
		private float _anamorphicFlaresIntensity; // 0x178
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _anamorphicFlaresAntiflicker; // 0x17C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _anamorphicFlaresUltra; // 0x17D
		[Range] // 0x000000018025E7A0-0x000000018025E7E0
		[SerializeField] // 0x000000018025E7A0-0x000000018025E7E0
		private float _anamorphicFlaresThreshold; // 0x180
		[Range] // 0x00000001802603C0-0x0000000180260400
		[SerializeField] // 0x00000001802603C0-0x0000000180260400
		private float _anamorphicFlaresSpread; // 0x184
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _anamorphicFlaresVertical; // 0x188
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Color _anamorphicFlaresTint; // 0x18C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _anamorphicFlaresBlur; // 0x19C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _depthOfField; // 0x19D
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _depthOfFieldTransparencySupport; // 0x19E
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Transform _depthOfFieldTargetFocus; // 0x1A0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _depthOfFieldDebug; // 0x1A8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _depthOfFieldAutofocus; // 0x1A9
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _depthOfFieldAutofocusMinDistance; // 0x1AC
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _depthOfFieldAutofocusMaxDistance; // 0x1B0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private LayerMask _depthOfFieldAutofocusLayerMask; // 0x1B4
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private LayerMask _depthOfFieldExclusionLayerMask; // 0x1B8
		[Range] // 0x000000018025D7A0-0x000000018025D7E0
		[SerializeField] // 0x000000018025D7A0-0x000000018025D7E0
		private float _depthOfFieldExclusionLayerMaskDownsampling; // 0x1BC
		[Range] // 0x000000018025D7A0-0x000000018025D7E0
		[SerializeField] // 0x000000018025D7A0-0x000000018025D7E0
		private float _depthOfFieldTransparencySupportDownsampling; // 0x1C0
		[Range] // 0x00000001802632C0-0x0000000180263300
		[SerializeField] // 0x00000001802632C0-0x0000000180263300
		private float _depthOfFieldExclusionBias; // 0x1C4
		[Range] // 0x0000000180264750-0x0000000180264790
		[SerializeField] // 0x0000000180264750-0x0000000180264790
		private float _depthOfFieldDistance; // 0x1C8
		[Range] // 0x0000000180264A60-0x0000000180264AA0
		[SerializeField] // 0x0000000180264A60-0x0000000180264AA0
		private float _depthOfFieldFocusSpeed; // 0x1CC
		[Range] // 0x00000001801EA900-0x00000001801EA940
		[SerializeField] // 0x00000001801EA900-0x00000001801EA940
		private int _depthOfFieldDownsampling; // 0x1D0
		[Range] // 0x0000000180264F20-0x0000000180264F60
		[SerializeField] // 0x0000000180264F20-0x0000000180264F60
		private int _depthOfFieldMaxSamples; // 0x1D4
		[Range] // 0x00000001802663A0-0x00000001802663E0
		[SerializeField] // 0x00000001802663A0-0x00000001802663E0
		private float _depthOfFieldFocalLength; // 0x1D8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _depthOfFieldAperture; // 0x1DC
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _depthOfFieldForegroundBlur; // 0x1E0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _depthOfFieldForegroundBlurHQ; // 0x1E1
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _depthOfFieldForegroundDistance; // 0x1E4
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _depthOfFieldBokeh; // 0x1E8
		[Range] // 0x0000000180266D70-0x0000000180266DB0
		[SerializeField] // 0x0000000180266D70-0x0000000180266DB0
		private float _depthOfFieldBokehThreshold; // 0x1EC
		[Range] // 0x0000000180266F40-0x0000000180266F80
		[SerializeField] // 0x0000000180266F40-0x0000000180266F80
		private float _depthOfFieldBokehIntensity; // 0x1F0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _depthOfFieldMaxBrightness; // 0x1F4
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private FilterMode _depthOfFieldFilterMode; // 0x1F8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _eyeAdaptation; // 0x1FC
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _eyeAdaptationMinExposure; // 0x200
		[Range] // 0x0000000180264750-0x0000000180264790
		[SerializeField] // 0x0000000180264750-0x0000000180264790
		private float _eyeAdaptationMaxExposure; // 0x204
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _eyeAdaptationSpeedToLight; // 0x208
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _eyeAdaptationSpeedToDark; // 0x20C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _purkinje; // 0x210
		[Range] // 0x000000018025E7A0-0x000000018025E7E0
		[SerializeField] // 0x000000018025E7A0-0x000000018025E7E0
		private float _purkinjeAmount; // 0x214
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _purkinjeLuminanceThreshold; // 0x218
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private BEAUTIFY_TMO _tonemap; // 0x21C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _sunFlares; // 0x220
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Transform _sun; // 0x228
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private LayerMask _sunFlaresLayerMask; // 0x230
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _sunFlaresIntensity; // 0x234
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _sunFlaresSolarWindSpeed; // 0x238
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Color _sunFlaresTint; // 0x23C
		[Range] // 0x00000001801EA900-0x00000001801EA940
		[SerializeField] // 0x00000001801EA900-0x00000001801EA940
		private int _sunFlaresDownsampling; // 0x24C
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _sunFlaresSunIntensity; // 0x250
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _sunFlaresSunDiskSize; // 0x254
		[Range] // 0x00000001801EAD10-0x00000001801EAD50
		[SerializeField] // 0x00000001801EAD10-0x00000001801EAD50
		private float _sunFlaresSunRayDiffractionIntensity; // 0x258
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _sunFlaresSunRayDiffractionThreshold; // 0x25C
		[Range] // 0x000000018020C740-0x000000018020C780
		[SerializeField] // 0x000000018020C740-0x000000018020C780
		private float _sunFlaresCoronaRays1Length; // 0x260
		[Range] // 0x0000000180268FA0-0x0000000180268FE0
		[SerializeField] // 0x0000000180268FA0-0x0000000180268FE0
		private int _sunFlaresCoronaRays1Streaks; // 0x264
		[Range] // 0x00000001802693E0-0x0000000180269420
		[SerializeField] // 0x00000001802693E0-0x0000000180269420
		private float _sunFlaresCoronaRays1Spread; // 0x268
		[Range] // 0x0000000180269580-0x00000001802695C0
		[SerializeField] // 0x0000000180269580-0x00000001802695C0
		private float _sunFlaresCoronaRays1AngleOffset; // 0x26C
		[Range] // 0x000000018020C740-0x000000018020C780
		[SerializeField] // 0x000000018020C740-0x000000018020C780
		private float _sunFlaresCoronaRays2Length; // 0x270
		[Range] // 0x0000000180268FA0-0x0000000180268FE0
		[SerializeField] // 0x0000000180268FA0-0x0000000180268FE0
		private int _sunFlaresCoronaRays2Streaks; // 0x274
		[Range] // 0x00000001802693E0-0x0000000180269420
		[SerializeField] // 0x00000001802693E0-0x0000000180269420
		private float _sunFlaresCoronaRays2Spread; // 0x278
		[Range] // 0x0000000180269580-0x00000001802695C0
		[SerializeField] // 0x0000000180269580-0x00000001802695C0
		private float _sunFlaresCoronaRays2AngleOffset; // 0x27C
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _sunFlaresGhosts1Size; // 0x280
		[Range] // 0x000000018026A420-0x000000018026A460
		[SerializeField] // 0x000000018026A420-0x000000018026A460
		private float _sunFlaresGhosts1Offset; // 0x284
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _sunFlaresGhosts1Brightness; // 0x288
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _sunFlaresGhosts2Size; // 0x28C
		[Range] // 0x000000018026A420-0x000000018026A460
		[SerializeField] // 0x000000018026A420-0x000000018026A460
		private float _sunFlaresGhosts2Offset; // 0x290
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _sunFlaresGhosts2Brightness; // 0x294
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _sunFlaresGhosts3Size; // 0x298
		[Range] // 0x000000018026A420-0x000000018026A460
		[SerializeField] // 0x000000018026A420-0x000000018026A460
		private float _sunFlaresGhosts3Brightness; // 0x29C
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _sunFlaresGhosts3Offset; // 0x2A0
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _sunFlaresGhosts4Size; // 0x2A4
		[Range] // 0x000000018026A420-0x000000018026A460
		[SerializeField] // 0x000000018026A420-0x000000018026A460
		private float _sunFlaresGhosts4Offset; // 0x2A8
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _sunFlaresGhosts4Brightness; // 0x2AC
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _sunFlaresHaloOffset; // 0x2B0
		[Range] // 0x000000018026BDB0-0x000000018026BDF0
		[SerializeField] // 0x000000018026BDB0-0x000000018026BDF0
		private float _sunFlaresHaloAmplitude; // 0x2B4
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float _sunFlaresHaloIntensity; // 0x2B8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _sunFlaresRotationDeadZone; // 0x2BC
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _blur; // 0x2BD
		[Range] // 0x00000001801EA720-0x00000001801EA760
		[SerializeField] // 0x00000001801EA720-0x00000001801EA760
		private float _blurIntensity; // 0x2C0
		[Range] // 0x000000018026C960-0x000000018026C9A0
		[SerializeField] // 0x000000018026C960-0x000000018026C9A0
		private int _pixelateAmount; // 0x2C4
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _pixelateDownscale; // 0x2C8
		[Range] // 0x000000018026CC00-0x000000018026CC40
		[SerializeField] // 0x000000018026CC00-0x000000018026CC40
		private float _antialiasStrength; // 0x2CC
		[Range] // 0x0000000180258E10-0x0000000180258E50
		[SerializeField] // 0x0000000180258E10-0x0000000180258E50
		private float _antialiasDepthThreshold; // 0x2D0
		public bool isDirty; // 0x2D4
		private static Beautify _beautify; // 0x00
		public const string SKW_BLOOM = "BEAUTIFY_BLOOM"; // Metadata: 0x007762CF
		public const string SKW_LUT = "BEAUTIFY_LUT"; // Metadata: 0x007762E1
		public const string SKW_NIGHT_VISION = "BEAUTIFY_NIGHT_VISION"; // Metadata: 0x007762F1
		public const string SKW_THERMAL_VISION = "BEAUTIFY_THERMAL_VISION"; // Metadata: 0x0077630A
		public const string SKW_OUTLINE = "BEAUTIFY_OUTLINE"; // Metadata: 0x00776325
		public const string SKW_FRAME = "BEAUTIFY_FRAME"; // Metadata: 0x00776339
		public const string SKW_FRAME_MASK = "BEAUTIFY_FRAME_MASK"; // Metadata: 0x0077634B
		public const string SKW_DALTONIZE = "BEAUTIFY_DALTONIZE"; // Metadata: 0x00776362
		public const string SKW_DIRT = "BEAUTIFY_DIRT"; // Metadata: 0x00776378
		public const string SKW_VIGNETTING = "BEAUTIFY_VIGNETTING"; // Metadata: 0x00776389
		public const string SKW_VIGNETTING_MASK = "BEAUTIFY_VIGNETTING_MASK"; // Metadata: 0x007763A0
		public const string SKW_DEPTH_OF_FIELD = "BEAUTIFY_DEPTH_OF_FIELD"; // Metadata: 0x007763BC
		public const string SKW_DEPTH_OF_FIELD_TRANSPARENT = "BEAUTIFY_DEPTH_OF_FIELD_TRANSPARENT"; // Metadata: 0x007763D7
		public const string SKW_EYE_ADAPTATION = "BEAUTIFY_EYE_ADAPTATION"; // Metadata: 0x007763FE
		public const string SKW_TONEMAP_ACES = "BEAUTIFY_TONEMAP_ACES"; // Metadata: 0x00776419
		public const string SKW_PURKINJE = "BEAUTIFY_PURKINJE"; // Metadata: 0x00776432
		public const string SKW_BLOOM_USE_DEPTH = "BEAUTIFY_BLOOM_USE_DEPTH"; // Metadata: 0x00776447
		public const string SKW_BLOOM_USE_LAYER = "BEAUTIFY_BLOOM_USE_LAYER"; // Metadata: 0x00776463
		private Material bMatDesktop; // 0x2D8
		private Material bMatMobile; // 0x2E0
		private Material bMatBasic; // 0x2E8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
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
		private const string BEAUTIFY_BUILD_HINT = "BeautifyBuildHint70b3"; // Metadata: 0x0077647F
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
		private float sunFlareTime; // 0x41C
		private int dofCurrentLayerMaskValue; // 0x420
	
		// Properties
		public BEAUTIFY_PRESET preset { get; set; } // 0x00000001803F46B0-0x00000001803F46C0 0x0000000181F61A60-0x0000000181F61AA0
		public BEAUTIFY_QUALITY quality { get; set; } // 0x00000001803FB770-0x00000001803FB780 0x0000000181F61D10-0x0000000181F61DA0
		public BeautifyProfile profile { get; set; } // 0x0000000180374AF0-0x0000000180374B00 0x0000000181F61AA0-0x0000000181F61B70
		public bool compareMode { get; set; } // 0x00000001804C6790-0x00000001804C67A0 0x0000000181F602F0-0x0000000181F60330
		public float compareLineAngle { get; set; } // 0x00000001807DDA30-0x00000001807DDA40 0x0000000181F60250-0x0000000181F602A0
		public float compareLineWidth { get; set; } // 0x00000001806757B0-0x00000001806757C0 0x0000000181F602A0-0x0000000181F602F0
		public float dither { get; set; } // 0x00000001806CEAE0-0x00000001806CEAF0 0x0000000181F61080-0x0000000181F610D0
		public float ditherDepth { get; set; } // 0x0000000180788790-0x00000001807887A0 0x0000000181F61030-0x0000000181F61080
		public float sharpenMinDepth { get; set; } // 0x0000000180379EF0-0x0000000180379F00 0x0000000181F61EE0-0x0000000181F61F30
		public float sharpenMaxDepth { get; set; } // 0x00000001804D5800-0x00000001804D5810 0x0000000181F61E90-0x0000000181F61EE0
		public float sharpen { get; set; } // 0x0000000180690330-0x0000000180690340 0x0000000181F61FD0-0x0000000181F62020
		public float sharpenDepthThreshold { get; set; } // 0x00000001804D5810-0x00000001804D5820 0x0000000181F61E40-0x0000000181F61E90
		public Color tintColor { get; set; } // 0x0000000181F5F4A0-0x0000000181F5F4B0 0x0000000181F62C90-0x0000000181F62D00
		public float sharpenRelaxation { get; set; } // 0x000000018099EBB0-0x000000018099EBC0 0x0000000181F61F80-0x0000000181F61FD0
		public float sharpenClamp { get; set; } // 0x00000001804CD6D0-0x00000001804CD6E0 0x0000000181F61DF0-0x0000000181F61E40
		public float sharpenMotionSensibility { get; set; } // 0x000000018099EBD0-0x000000018099EBE0 0x0000000181F61F30-0x0000000181F61F80
		public float saturate { get; set; } // 0x00000001804C5F40-0x00000001804C5F50 0x0000000181F61DA0-0x0000000181F61DF0
		public float contrast { get; set; } // 0x00000001804C5F30-0x00000001804C5F40 0x0000000181F60330-0x0000000181F60380
		public float brightness { get; set; } // 0x000000018096DED0-0x000000018096DEE0 0x0000000181F60200-0x0000000181F60250
		public float daltonize { get; set; } // 0x0000000180F8A040-0x0000000180F8A050 0x0000000181F60380-0x0000000181F603D0
		public bool vignetting { get; set; } // 0x0000000180453D00-0x0000000180453D10 0x0000000181F62FB0-0x0000000181F62FF0
		public Color vignettingColor { get; set; } // 0x0000000180BEC1F0-0x0000000180BEC200 0x0000000181F62E40-0x0000000181F62EB0
		public float vignettingFade { get; set; } // 0x00000001804A0210-0x00000001804A0220 0x0000000181F62EB0-0x0000000181F62F00
		public bool vignettingCircularShape { get; set; } // 0x0000000180418A30-0x0000000180418A40 0x0000000181F62E00-0x0000000181F62E40
		public float vignettingAspectRatio { get; set; } // 0x0000000181F5F4C0-0x0000000181F5F4D0 0x0000000181F62D60-0x0000000181F62DB0
		public float vignettingBlink { get; set; } // 0x000000018096DEE0-0x000000018096DEF0 0x0000000181F62DB0-0x0000000181F62E00
		public Texture2D vignettingMask { get; set; } // 0x00000001803D6D90-0x00000001803D6DA0 0x0000000181F62F00-0x0000000181F62FB0
		public bool frame { get; set; } // 0x0000000180921730-0x0000000180921740 0x0000000181F614D0-0x0000000181F61510
		public Color frameColor { get; set; } // 0x0000000181F5F0D0-0x0000000181F5F0E0 0x0000000181F613A0-0x0000000181F61420
		public Texture2D frameMask { get; set; } // 0x0000000180529360-0x0000000180529370 0x0000000181F61420-0x0000000181F614D0
		public bool lut { get; set; } // 0x0000000180AB93C0-0x0000000180AB93D0 0x0000000181F617A0-0x0000000181F617F0
		public float lutIntensity { get; set; } // 0x00000001811C61E0-0x00000001811C61F0 0x0000000181F616A0-0x0000000181F616F0
		public Texture2D lutTexture { get; set; } // 0x00000001805293A0-0x00000001805293B0 0x0000000181F616F0-0x0000000181F617A0
		public bool nightVision { get; set; } // 0x0000000180556810-0x0000000180556820 0x0000000181F61870-0x0000000181F61920
		public Color nightVisionColor { get; set; } // 0x0000000181F5F230-0x0000000181F5F240 0x0000000181F617F0-0x0000000181F61870
		public bool outline { get; set; } // 0x0000000181F5F250-0x0000000181F5F260 0x0000000181F619A0-0x0000000181F619E0
		public Color outlineColor { get; set; } // 0x0000000181F5F240-0x0000000181F5F250 0x0000000181F61920-0x0000000181F619A0
		public bool thermalVision { get; set; } // 0x0000000180D18C60-0x0000000180D18C70 0x0000000181F62BE0-0x0000000181F62C90
		public bool lensDirt { get; set; } // 0x0000000181A221C0-0x0000000181A221D0 0x0000000181F61660-0x0000000181F616A0
		public float lensDirtThreshold { get; set; } // 0x0000000180D18B30-0x0000000180D18B40 0x0000000181F61610-0x0000000181F61660
		public float lensDirtIntensity { get; set; } // 0x0000000181629120-0x0000000181629130 0x0000000181F61510-0x0000000181F61560
		public Texture2D lensDirtTexture { get; set; } // 0x0000000180385320-0x0000000180385330 0x0000000181F61560-0x0000000181F61610
		public bool bloom { get; set; } // 0x0000000181F5EF20-0x0000000181F5EF30 0x0000000181F60130-0x0000000181F60170
		public LayerMask bloomCullingMask { get; set; } // 0x0000000180DBB690-0x0000000180DBB6A0 0x0000000181F5FAD0-0x0000000181F5FB50
		public float bloomLayerMaskDownsampling { get; set; } // 0x0000000181F5EEC0-0x0000000181F5EED0 0x0000000181F5FCC0-0x0000000181F5FD70
		public float bloomIntensity { get; set; } // 0x0000000181F5EEB0-0x0000000181F5EEC0 0x0000000181F5FC20-0x0000000181F5FCC0
		public float bloomMaxBrightness { get; set; } // 0x0000000181F5EED0-0x0000000181F5EEE0 0x0000000181F5FE20-0x0000000181F5FEC0
		public float bloomBoost0 { get; set; } // 0x0000000181F5EE60-0x0000000181F5EE70 0x0000000181F5F8F0-0x0000000181F5F940
		public float bloomBoost1 { get; set; } // 0x000000018058CA30-0x000000018058CA40 0x0000000181F5F940-0x0000000181F5F990
		public float bloomBoost2 { get; set; } // 0x0000000181F5EE70-0x0000000181F5EE80 0x0000000181F5F990-0x0000000181F5F9E0
		public float bloomBoost3 { get; set; } // 0x000000018091EE00-0x000000018091EE10 0x0000000181F5F9E0-0x0000000181F5FA30
		public float bloomBoost4 { get; set; } // 0x000000018091EE10-0x000000018091EE20 0x0000000181F5FA30-0x0000000181F5FA80
		public float bloomBoost5 { get; set; } // 0x0000000181F5EE80-0x0000000181F5EE90 0x0000000181F5FA80-0x0000000181F5FAD0
		public bool bloomAntiflicker { get; set; } // 0x0000000181F5EE50-0x0000000181F5EE60 0x0000000181F5F870-0x0000000181F5F8B0
		public bool bloomUltra { get; set; } // 0x0000000181F5EEE0-0x0000000181F5EEF0 0x0000000181F5FF10-0x0000000181F5FF50
		public float bloomThreshold { get; set; } // 0x0000000180678D00-0x0000000180678D10 0x0000000181F5FEC0-0x0000000181F5FF10
		public bool bloomCustomize { get; set; } // 0x0000000181F5EE90-0x0000000181F5EEA0 0x0000000181F5FB50-0x0000000181F5FB90
		public bool bloomDebug { get; set; } // 0x0000000181F5EEA0-0x0000000181F5EEB0 0x0000000181F5FB90-0x0000000181F5FBD0
		public float bloomWeight0 { get; set; } // 0x00000001810BFCA0-0x00000001810BFCB0 0x0000000181F5FF50-0x0000000181F5FFA0
		public float bloomWeight1 { get; set; } // 0x0000000181F5EEF0-0x0000000181F5EF00 0x0000000181F5FFA0-0x0000000181F5FFF0
		public float bloomWeight2 { get; set; } // 0x000000018058C870-0x000000018058C880 0x0000000181F5FFF0-0x0000000181F60040
		public float bloomWeight3 { get; set; } // 0x0000000181F5EF00-0x0000000181F5EF10 0x0000000181F60040-0x0000000181F60090
		public float bloomWeight4 { get; set; } // 0x000000018091EE80-0x000000018091EE90 0x0000000181F60090-0x0000000181F600E0
		public float bloomWeight5 { get; set; } // 0x0000000181F5EF10-0x0000000181F5EF20 0x0000000181F600E0-0x0000000181F60130
		public bool bloomBlur { get; set; } // 0x00000001810C5F50-0x00000001810C5F60 0x0000000181F5F8B0-0x0000000181F5F8F0
		public float bloomDepthAtten { get; set; } // 0x00000001810C6020-0x00000001810C6030 0x0000000181F5FBD0-0x0000000181F5FC20
		public float bloomLayerZBias { get; set; } // 0x0000000180982BD0-0x0000000180982BE0 0x0000000181F5FD70-0x0000000181F5FE20
		public bool anamorphicFlares { get; set; } // 0x00000001810C5FD0-0x00000001810C5FE0 0x0000000181F5F790-0x0000000181F5F7D0
		public float anamorphicFlaresIntensity { get; set; } // 0x0000000181F5EDE0-0x0000000181F5EDF0 0x0000000181F5F550-0x0000000181F5F5F0
		public bool anamorphicFlaresAntiflicker { get; set; } // 0x0000000181F5EDD0-0x0000000181F5EDE0 0x0000000181F5F4D0-0x0000000181F5F510
		public bool anamorphicFlaresUltra { get; set; } // 0x0000000181F5EE20-0x0000000181F5EE30 0x0000000181F5F710-0x0000000181F5F750
		public float anamorphicFlaresThreshold { get; set; } // 0x0000000181F5EE00-0x0000000181F5EE10 0x0000000181F5F640-0x0000000181F5F690
		public float anamorphicFlaresSpread { get; set; } // 0x0000000181F5EDF0-0x0000000181F5EE00 0x0000000181F5F5F0-0x0000000181F5F640
		public bool anamorphicFlaresVertical { get; set; } // 0x00000001810BFD80-0x00000001810BFD90 0x0000000181F5F750-0x0000000181F5F790
		public Color anamorphicFlaresTint { get; set; } // 0x0000000181F5EE10-0x0000000181F5EE20 0x0000000181F5F690-0x0000000181F5F710
		public bool anamorphicFlaresBlur { get; set; } // 0x00000001810BF9A0-0x00000001810BF9B0 0x0000000181F5F510-0x0000000181F5F550
		public bool depthOfField { get; set; } // 0x0000000181F5F070-0x0000000181F5F080 0x0000000181F60FF0-0x0000000181F61030
		public bool depthOfFieldTransparencySupport { get; set; } // 0x0000000181F5F060-0x0000000181F5F070 0x0000000181F60FB0-0x0000000181F60FF0
		public Transform depthOfFieldTargetFocus { get; set; } // 0x000000018058C860-0x000000018058C870 0x0000000181F60E50-0x0000000181F60F00
		public bool depthOfFieldDebug { get; set; } // 0x0000000181F5EFB0-0x0000000181F5EFC0 0x0000000181F60750-0x0000000181F60790
		public bool depthOfFieldAutofocus { get; set; } // 0x0000000181F5EF80-0x0000000181F5EF90 0x0000000181F60590-0x0000000181F605D0
		public float depthOfFieldAutofocusMinDistance { get; set; } // 0x0000000181F5EF70-0x0000000181F5EF80 0x0000000181F60540-0x0000000181F60590
		public float depthOfFieldAutofocusMaxDistance { get; set; } // 0x000000018048DC40-0x000000018048DC50 0x0000000181F604F0-0x0000000181F60540
		public LayerMask depthOfFieldAutofocusLayerMask { get; set; } // 0x0000000181F5EF60-0x0000000181F5EF70 0x0000000181F60470-0x0000000181F604F0
		public LayerMask depthOfFieldExclusionLayerMask { get; set; } // 0x0000000181F5EFF0-0x0000000181F5F000 0x0000000181F60A30-0x0000000181F60AB0
		public float depthOfFieldExclusionLayerMaskDownsampling { get; set; } // 0x0000000181F5EFE0-0x0000000181F5EFF0 0x0000000181F60980-0x0000000181F60A30
		public float depthOfFieldTransparencySupportDownsampling { get; set; } // 0x0000000181F5F050-0x0000000181F5F060 0x0000000181F60F00-0x0000000181F60FB0
		public float depthOfFieldExclusionBias { get; set; } // 0x0000000181F5EFD0-0x0000000181F5EFE0 0x0000000181F608E0-0x0000000181F60980
		public float depthOfFieldDistance { get; set; } // 0x0000000181F5EFC0-0x0000000181F5EFD0 0x0000000181F60790-0x0000000181F60840
		public float depthOfFieldFocusSpeed { get; set; } // 0x0000000181F5F010-0x0000000181F5F020 0x0000000181F60B90-0x0000000181F60C40
		public int depthOfFieldDownsampling { get; set; } // 0x0000000180739240-0x0000000180739250 0x0000000181F60840-0x0000000181F608E0
		public int depthOfFieldMaxSamples { get; set; } // 0x0000000181F5F040-0x0000000181F5F050 0x0000000181F60DB0-0x0000000181F60E50
		public float depthOfFieldFocalLength { get; set; } // 0x000000018058C330-0x000000018058C340 0x0000000181F60AF0-0x0000000181F60B90
		public float depthOfFieldAperture { get; set; } // 0x0000000181F5EF50-0x0000000181F5EF60 0x0000000181F603D0-0x0000000181F60470
		public bool depthOfFieldForegroundBlur { get; set; } // 0x000000018058C9F0-0x000000018058CA00 0x0000000181F60C80-0x0000000181F60CC0
		public bool depthOfFieldForegroundBlurHQ { get; set; } // 0x000000018058CA20-0x000000018058CA30 0x0000000181F60C40-0x0000000181F60C80
		public float depthOfFieldForegroundDistance { get; set; } // 0x0000000181F5F020-0x0000000181F5F030 0x0000000181F60CC0-0x0000000181F60D10
		public bool depthOfFieldBokeh { get; set; } // 0x0000000181498EA0-0x0000000181498EB0 0x0000000181F60710-0x0000000181F60750
		public float depthOfFieldBokehThreshold { get; set; } // 0x0000000181F5EFA0-0x0000000181F5EFB0 0x0000000181F60670-0x0000000181F60710
		public float depthOfFieldBokehIntensity { get; set; } // 0x0000000181F5EF90-0x0000000181F5EFA0 0x0000000181F605D0-0x0000000181F60670
		public float depthOfFieldMaxBrightness { get; set; } // 0x0000000181F5F030-0x0000000181F5F040 0x0000000181F60D10-0x0000000181F60DB0
		public FilterMode depthOfFieldFilterMode { get; set; } // 0x0000000181F5F000-0x0000000181F5F010 0x0000000181F60AB0-0x0000000181F60AF0
		public bool eyeAdaptation { get; set; } // 0x0000000181F5F0C0-0x0000000181F5F0D0 0x0000000181F61360-0x0000000181F613A0
		public float eyeAdaptationMinExposure { get; set; } // 0x0000000181F5F090-0x0000000181F5F0A0 0x0000000181F61180-0x0000000181F61220
		public float eyeAdaptationMaxExposure { get; set; } // 0x0000000181F5F080-0x0000000181F5F090 0x0000000181F610D0-0x0000000181F61180
		public float eyeAdaptationSpeedToLight { get; set; } // 0x0000000181F5F0B0-0x0000000181F5F0C0 0x0000000181F612C0-0x0000000181F61360
		public float eyeAdaptationSpeedToDark { get; set; } // 0x0000000181F5F0A0-0x0000000181F5F0B0 0x0000000181F61220-0x0000000181F612C0
		public bool purkinje { get; set; } // 0x00000001805CBB80-0x00000001805CBB90 0x0000000181F61CD0-0x0000000181F61D10
		public float purkinjeAmount { get; set; } // 0x0000000181F5F280-0x0000000181F5F290 0x0000000181F61B70-0x0000000181F61C20
		public float purkinjeLuminanceThreshold { get; set; } // 0x0000000181F5F290-0x0000000181F5F2A0 0x0000000181F61C20-0x0000000181F61CD0
		public BEAUTIFY_TMO tonemap { get; set; } // 0x0000000181F5F4B0-0x0000000181F5F4C0 0x0000000181F62D00-0x0000000181F62D60
		public bool sunFlares { get; set; } // 0x000000018058C6E0-0x000000018058C6F0 0x0000000181F62AF0-0x0000000181F62B30
		public Transform sun { get; set; } // 0x0000000181F5F490-0x0000000181F5F4A0 0x0000000181F62B30-0x0000000181F62BE0
		public LayerMask sunFlaresLayerMask { get; set; } // 0x0000000181F5F410-0x0000000181F5F420 0x0000000181F62820-0x0000000181F628A0
		public float sunFlaresIntensity { get; set; } // 0x0000000181F5F400-0x0000000181F5F410 0x0000000181F627D0-0x0000000181F62820
		public float sunFlaresSolarWindSpeed { get; set; } // 0x0000000181F5F430-0x0000000181F5F440 0x0000000181F628E0-0x0000000181F62930
		public Color sunFlaresTint { get; set; } // 0x0000000181F5F480-0x0000000181F5F490 0x0000000181F62A70-0x0000000181F62AF0
		public int sunFlaresDownsampling { get; set; } // 0x0000000181F5F310-0x0000000181F5F320 0x0000000181F62280-0x0000000181F62320
		public float sunFlaresSunIntensity { get; set; } // 0x0000000181F5F450-0x0000000181F5F460 0x0000000181F62980-0x0000000181F629D0
		public float sunFlaresSunDiskSize { get; set; } // 0x0000000181F5F440-0x0000000181F5F450 0x0000000181F62930-0x0000000181F62980
		public float sunFlaresSunRayDiffractionIntensity { get; set; } // 0x0000000181F5F460-0x0000000181F5F470 0x0000000181F629D0-0x0000000181F62A20
		public float sunFlaresSunRayDiffractionThreshold { get; set; } // 0x0000000181F5F470-0x0000000181F5F480 0x0000000181F62A20-0x0000000181F62A70
		public float sunFlaresCoronaRays1Length { get; set; } // 0x0000000181F5F2B0-0x0000000181F5F2C0 0x0000000181F62070-0x0000000181F620C0
		public int sunFlaresCoronaRays1Streaks { get; set; } // 0x0000000181F5F2D0-0x0000000181F5F2E0 0x0000000181F62110-0x0000000181F62150
		public float sunFlaresCoronaRays1Spread { get; set; } // 0x0000000181F5F2C0-0x0000000181F5F2D0 0x0000000181F620C0-0x0000000181F62110
		public float sunFlaresCoronaRays1AngleOffset { get; set; } // 0x0000000181F5F2A0-0x0000000181F5F2B0 0x0000000181F62020-0x0000000181F62070
		public float sunFlaresCoronaRays2Length { get; set; } // 0x0000000181F5F2F0-0x0000000181F5F300 0x0000000181F621A0-0x0000000181F621F0
		public int sunFlaresCoronaRays2Streaks { get; set; } // 0x0000000181F5F300-0x0000000181F5F310 0x0000000181F62240-0x0000000181F62280
		public float sunFlaresCoronaRays2Spread { get; set; } // 0x00000001805CB6F0-0x00000001805CB700 0x0000000181F621F0-0x0000000181F62240
		public float sunFlaresCoronaRays2AngleOffset { get; set; } // 0x0000000181F5F2E0-0x0000000181F5F2F0 0x0000000181F62150-0x0000000181F621A0
		public float sunFlaresGhosts1Size { get; set; } // 0x0000000181F5F340-0x0000000181F5F350 0x0000000181F623C0-0x0000000181F62410
		public float sunFlaresGhosts1Offset { get; set; } // 0x0000000181F5F330-0x0000000181F5F340 0x0000000181F62370-0x0000000181F623C0
		public float sunFlaresGhosts1Brightness { get; set; } // 0x0000000181F5F320-0x0000000181F5F330 0x0000000181F62320-0x0000000181F62370
		public float sunFlaresGhosts2Size { get; set; } // 0x0000000181F5F370-0x0000000181F5F380 0x0000000181F624B0-0x0000000181F62500
		public float sunFlaresGhosts2Offset { get; set; } // 0x0000000181F5F360-0x0000000181F5F370 0x0000000181F62460-0x0000000181F624B0
		public float sunFlaresGhosts2Brightness { get; set; } // 0x0000000181F5F350-0x0000000181F5F360 0x0000000181F62410-0x0000000181F62460
		public float sunFlaresGhosts3Size { get; set; } // 0x0000000181F5F3A0-0x0000000181F5F3B0 0x0000000181F625A0-0x0000000181F625F0
		public float sunFlaresGhosts3Brightness { get; set; } // 0x0000000181F5F380-0x0000000181F5F390 0x0000000181F62500-0x0000000181F62550
		public float sunFlaresGhosts3Offset { get; set; } // 0x0000000181F5F390-0x0000000181F5F3A0 0x0000000181F62550-0x0000000181F625A0
		public float sunFlaresGhosts4Size { get; set; } // 0x0000000181F5F3D0-0x0000000181F5F3E0 0x0000000181F62690-0x0000000181F626E0
		public float sunFlaresGhosts4Offset { get; set; } // 0x0000000181F5F3C0-0x0000000181F5F3D0 0x0000000181F62640-0x0000000181F62690
		public float sunFlaresGhosts4Brightness { get; set; } // 0x0000000181F5F3B0-0x0000000181F5F3C0 0x0000000181F625F0-0x0000000181F62640
		public float sunFlaresHaloOffset { get; set; } // 0x0000000181F5F3F0-0x0000000181F5F400 0x0000000181F62780-0x0000000181F627D0
		public float sunFlaresHaloAmplitude { get; set; } // 0x0000000181F5F3E0-0x0000000181F5F3F0 0x0000000181F626E0-0x0000000181F62730
		public float sunFlaresHaloIntensity { get; set; } // 0x00000001805CB480-0x00000001805CB490 0x0000000181F62730-0x0000000181F62780
		public bool sunFlaresRotationDeadZone { get; set; } // 0x0000000181F5F420-0x0000000181F5F430 0x0000000181F628A0-0x0000000181F628E0
		public bool blur { get; set; } // 0x0000000181F5EF40-0x0000000181F5EF50 0x0000000181F601C0-0x0000000181F60200
		public float blurIntensity { get; set; } // 0x0000000181F5EF30-0x0000000181F5EF40 0x0000000181F60170-0x0000000181F601C0
		public int pixelateAmount { get; set; } // 0x0000000181F5F260-0x0000000181F5F270 0x0000000181F619E0-0x0000000181F61A20
		public bool pixelateDownscale { get; set; } // 0x0000000181F5F270-0x0000000181F5F280 0x0000000181F61A20-0x0000000181F61A60
		public float antialiasStrength { get; set; } // 0x0000000181F5EE40-0x0000000181F5EE50 0x0000000181F5F820-0x0000000181F5F870
		public float antialiasDepthThreshold { get; set; } // 0x0000000181F5EE30-0x0000000181F5EE40 0x0000000181F5F7D0-0x0000000181F5F820
		public static Beautify instance { get; } // 0x0000000181F5F0E0-0x0000000181F5F230 
		public Camera cameraEffect { get; } // 0x00000001805CB8F0-0x00000001805CB900 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <DoBlink>d__699 : IEnumerator<object> // TypeDefIndex: 7416
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <DoBlink>d__699(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000181F64F00-0x0000000181F65130
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181F65130-0x0000000181F65180
		}
	
		// Constructors
		public Beautify(); // 0x0000000181F5E880-0x0000000181F5EDD0
	
		// Methods
		private void OnEnable(); // 0x0000000181F58580-0x0000000181F58620
		private void OnDestroy(); // 0x0000000181F582D0-0x0000000181F58570
		private void Reset(); // 0x0000000181F5C1E0-0x0000000181F5C1F0
		private void LateUpdate(); // 0x0000000181F57EF0-0x0000000181F582D0
		private void OnPreCull(); // 0x0000000181F58720-0x0000000181F588D0
		private void OnPreRender(); // 0x0000000181F588D0-0x0000000181F58AD0
		private void CleanUpRT(); // 0x0000000181F57900-0x0000000181F57AC0
		private void CheckDoFTransparencySupport(); // 0x0000000181F57480-0x0000000181F57900
		private void CheckDoFExclusionMask(); // 0x0000000181F57010-0x0000000181F57480
		private void CheckBloomCullingLayer(); // 0x0000000181F56A60-0x0000000181F57010
		protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination); // 0x0000000181F58AD0-0x0000000181F5C1E0
		private void OnPostRender(); // 0x0000000181F58620-0x0000000181F58720
		private void BlurThis(RenderTexture rt, float blurScale = 1f /* Metadata: 0x007762BB */); // 0x0000000181F568E0-0x0000000181F56A60
		private void BlurThisDownscaling(RenderTexture rt, RenderTexture downscaled, float blurScale = 1f /* Metadata: 0x007762BF */); // 0x0000000181F56540-0x0000000181F56770
		private RenderTexture BlurThisOneDirection(RenderTexture rt, bool vertical, float blurScale = 1f /* Metadata: 0x007762C3 */); // 0x0000000181F56770-0x0000000181F568E0
		private void BlurThisDoF(RenderTexture rt, int renderPass); // 0x0000000181F562B0-0x0000000181F56540
		private void BlurThisAlpha(RenderTexture rt, float blurScale = 1f /* Metadata: 0x007762C7 */); // 0x0000000181F56130-0x0000000181F562B0
		private void OnDidApplyAnimationProperties(); // 0x0000000181F58570-0x0000000181F58580
		public void UpdateQualitySettings(); // 0x0000000181F5E770-0x0000000181F5E7D0
		public void UpdateMaterialProperties(); // 0x0000000181F5E740-0x0000000181F5E770
		public void UpdateMaterialPropertiesNow(); // 0x0000000181F5CB10-0x0000000181F5E740
		private void UpdateMaterialBloomIntensityAndThreshold(); // 0x0000000181F5CA30-0x0000000181F5CB10
		private void UpdateMaterialAnamorphicIntensityAndThreshold(); // 0x0000000181F5C960-0x0000000181F5CA30
		private void UpdateSharpenParams(float sharpen); // 0x0000000181F5E7D0-0x0000000181F5E880
		private void UpdateDepthOfFieldData(); // 0x0000000181F5C2D0-0x0000000181F5C720
		private void UpdateDepthOfFieldBlurData(Vector2 blurDir); // 0x0000000181F5C1F0-0x0000000181F5C2D0
		private void UpdateDoFAutofocusDistance(); // 0x0000000181F5C720-0x0000000181F5C960
		public Texture2D GenerateSepiaLUT(); // 0x0000000181F57B40-0x0000000181F57EF0
		public void Blink(float duration, float maxValue = 1f /* Metadata: 0x007762CB */); // 0x0000000181F56090-0x0000000181F56130
		[IteratorStateMachine] // 0x000000018026E420-0x000000018026E470
		private IEnumerator DoBlink(float duration, float maxValue); // 0x0000000181F57AC0-0x0000000181F57B40
	}
}
