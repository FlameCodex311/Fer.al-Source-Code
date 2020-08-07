/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Beautify.dll - Assembly: Beautify, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7405-7417

namespace BeautifyEffect
{
	[CreateAssetMenu] // 0x00000001802700A0-0x00000001802700F0
	public class BeautifyProfile : ScriptableObject // TypeDefIndex: 7417
	{
		// Fields
		[Range] // 0x0000000180270310-0x0000000180270330
		public float dither; // 0x18
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float ditherDepth; // 0x1C
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float sharpenMinDepth; // 0x20
		[Range] // 0x0000000180270800-0x0000000180270820
		public float sharpenMaxDepth; // 0x24
		[Range] // 0x00000001802709A0-0x00000001802709C0
		public float sharpen; // 0x28
		[Range] // 0x0000000180270B10-0x0000000180270B30
		public float sharpenDepthThreshold; // 0x2C
		public Color tintColor; // 0x30
		[Range] // 0x0000000180270310-0x0000000180270330
		public float sharpenRelaxation; // 0x40
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float sharpenClamp; // 0x44
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float sharpenMotionSensibility; // 0x48
		[Range] // 0x0000000180270F60-0x0000000180270F80
		public float antialiasStrength; // 0x4C
		[Range] // 0x0000000180270B10-0x0000000180270B30
		public float antialiasDepthThreshold; // 0x50
		[Range] // 0x0000000180271320-0x0000000180271340
		public float saturate; // 0x54
		[Range] // 0x0000000180271480-0x00000001802714A0
		public float contrast; // 0x58
		[Range] // 0x0000000180247A20-0x0000000180247A40
		public float brightness; // 0x5C
		[Range] // 0x0000000180247A20-0x0000000180247A40
		public float daltonize; // 0x60
		public bool vignetting; // 0x64
		public Color vignettingColor; // 0x68
		public float vignettingFade; // 0x78
		public bool vignettingCircularShape; // 0x7C
		public float vignettingAspectRatio; // 0x80
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float vignettingBlink; // 0x84
		public Texture2D vignettingMask; // 0x88
		public bool frame; // 0x90
		public Color frameColor; // 0x94
		public Texture2D frameMask; // 0xA8
		public bool lut; // 0xB0
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float lutIntensity; // 0xB4
		public Texture2D lutTexture; // 0xB8
		public bool nightVision; // 0xC0
		public Color nightVisionColor; // 0xC4
		public bool outline; // 0xD4
		public Color outlineColor; // 0xD8
		public bool thermalVision; // 0xE8
		public bool lensDirt; // 0xE9
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float lensDirtThreshold; // 0xEC
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float lensDirtIntensity; // 0xF0
		public Texture2D lensDirtTexture; // 0xF8
		public bool bloom; // 0x100
		public LayerMask bloomCullingMask; // 0x104
		[Range] // 0x0000000180271E90-0x0000000180271EB0
		public float bloomLayerMaskDownsampling; // 0x108
		[Range] // 0x0000000180247EA0-0x0000000180247EC0
		public float bloomIntensity; // 0x10C
		public float bloomMaxBrightness; // 0x110
		[Range] // 0x00000001802711B0-0x00000001802711D0
		public float bloomBoost0; // 0x114
		[Range] // 0x00000001802711B0-0x00000001802711D0
		public float bloomBoost1; // 0x118
		[Range] // 0x00000001802711B0-0x00000001802711D0
		public float bloomBoost2; // 0x11C
		[Range] // 0x00000001802711B0-0x00000001802711D0
		public float bloomBoost3; // 0x120
		[Range] // 0x00000001802711B0-0x00000001802711D0
		public float bloomBoost4; // 0x124
		[Range] // 0x00000001802711B0-0x00000001802711D0
		public float bloomBoost5; // 0x128
		public bool bloomAntiflicker; // 0x12C
		public bool bloomUltra; // 0x12D
		[Range] // 0x0000000180273FE0-0x0000000180274000
		public float bloomThreshold; // 0x130
		public bool bloomCustomize; // 0x134
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float bloomWeight0; // 0x138
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float bloomWeight1; // 0x13C
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float bloomWeight2; // 0x140
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float bloomWeight3; // 0x144
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float bloomWeight4; // 0x148
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float bloomWeight5; // 0x14C
		public bool bloomBlur; // 0x150
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float bloomDepthAtten; // 0x154
		[Range] // 0x0000000180244630-0x0000000180244650
		public float bloomLayerZBias; // 0x158
		public bool anamorphicFlares; // 0x15C
		[Range] // 0x0000000180247EA0-0x0000000180247EC0
		public float anamorphicFlaresIntensity; // 0x160
		public bool anamorphicFlaresAntiflicker; // 0x164
		public bool anamorphicFlaresUltra; // 0x165
		[Range] // 0x0000000180273FE0-0x0000000180274000
		public float anamorphicFlaresThreshold; // 0x168
		[Range] // 0x0000000180276600-0x0000000180276620
		public float anamorphicFlaresSpread; // 0x16C
		public bool anamorphicFlaresVertical; // 0x170
		public Color anamorphicFlaresTint; // 0x174
		public bool anamorphicFlaresBlur; // 0x184
		public bool depthOfField; // 0x185
		public bool depthOfFieldTransparencySupport; // 0x186
		public Transform depthOfFieldTargetFocus; // 0x188
		public bool depthOfFieldAutofocus; // 0x190
		public LayerMask depthOfFieldAutofocusLayerMask; // 0x194
		public float depthOfFieldAutofocusMinDistance; // 0x198
		public float depthOfFieldAutofocusMaxDistance; // 0x19C
		public LayerMask depthOfFieldExclusionLayerMask; // 0x1A0
		[Range] // 0x0000000180271E90-0x0000000180271EB0
		public float depthOfFieldExclusionLayerMaskDownsampling; // 0x1A4
		[Range] // 0x0000000180271E90-0x0000000180271EB0
		public float depthOfFieldTransparencySupportDownsampling; // 0x1A8
		[Range] // 0x0000000180276A00-0x0000000180276A20
		public float depthOfFieldExclusionBias; // 0x1AC
		[Range] // 0x0000000180276DB0-0x0000000180276DD0
		public float depthOfFieldDistance; // 0x1B0
		[Range] // 0x0000000180276FC0-0x0000000180276FE0
		public float depthOfFieldFocusSpeed; // 0x1B4
		[Range] // 0x0000000180277110-0x0000000180277130
		public int depthOfFieldDownsampling; // 0x1B8
		[Range] // 0x0000000180277240-0x0000000180277260
		public int depthOfFieldMaxSamples; // 0x1BC
		[Range] // 0x0000000180277330-0x0000000180277350
		public float depthOfFieldFocalLength; // 0x1C0
		public float depthOfFieldAperture; // 0x1C4
		public bool depthOfFieldForegroundBlur; // 0x1C8
		public bool depthOfFieldForegroundBlurHQ; // 0x1C9
		public float depthOfFieldForegroundDistance; // 0x1CC
		public bool depthOfFieldBokeh; // 0x1D0
		[Range] // 0x0000000180277530-0x0000000180277550
		public float depthOfFieldBokehThreshold; // 0x1D4
		[Range] // 0x00000001801E5720-0x00000001801E5740
		public float depthOfFieldBokehIntensity; // 0x1D8
		public float depthOfFieldMaxBrightness; // 0x1DC
		public FilterMode depthOfFieldFilterMode; // 0x1E0
		public bool eyeAdaptation; // 0x1E4
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float eyeAdaptationMinExposure; // 0x1E8
		[Range] // 0x0000000180276DB0-0x0000000180276DD0
		public float eyeAdaptationMaxExposure; // 0x1EC
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float eyeAdaptationSpeedToLight; // 0x1F0
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float eyeAdaptationSpeedToDark; // 0x1F4
		public bool purkinje; // 0x1F8
		[Range] // 0x0000000180273FE0-0x0000000180274000
		public float purkinjeAmount; // 0x1FC
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float purkinjeLuminanceThreshold; // 0x200
		public BEAUTIFY_TMO tonemap; // 0x204
		public bool sunFlares; // 0x208
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float sunFlaresIntensity; // 0x20C
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float sunFlaresSolarWindSpeed; // 0x210
		public Color sunFlaresTint; // 0x214
		[Range] // 0x0000000180277110-0x0000000180277130
		public int sunFlaresDownsampling; // 0x224
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float sunFlaresSunIntensity; // 0x228
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float sunFlaresSunDiskSize; // 0x22C
		[Range] // 0x0000000180247EA0-0x0000000180247EC0
		public float sunFlaresSunRayDiffractionIntensity; // 0x230
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float sunFlaresSunRayDiffractionThreshold; // 0x234
		[Range] // 0x0000000180270310-0x0000000180270330
		public float sunFlaresCoronaRays1Length; // 0x238
		[Range] // 0x0000000180278F90-0x0000000180278FB0
		public int sunFlaresCoronaRays1Streaks; // 0x23C
		[Range] // 0x00000001802790C0-0x00000001802790E0
		public float sunFlaresCoronaRays1Spread; // 0x240
		[Range] // 0x00000001802792E0-0x0000000180279300
		public float sunFlaresCoronaRays1AngleOffset; // 0x244
		[Range] // 0x0000000180270310-0x0000000180270330
		public float sunFlaresCoronaRays2Length; // 0x248
		[Range] // 0x0000000180278F90-0x0000000180278FB0
		public int sunFlaresCoronaRays2Streaks; // 0x24C
		[Range] // 0x00000001802790C0-0x00000001802790E0
		public float sunFlaresCoronaRays2Spread; // 0x250
		[Range] // 0x00000001802792E0-0x0000000180279300
		public float sunFlaresCoronaRays2AngleOffset; // 0x254
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float sunFlaresGhosts1Size; // 0x258
		[Range] // 0x0000000180279B90-0x0000000180279BB0
		public float sunFlaresGhosts1Offset; // 0x25C
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float sunFlaresGhosts1Brightness; // 0x260
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float sunFlaresGhosts2Size; // 0x264
		[Range] // 0x0000000180279B90-0x0000000180279BB0
		public float sunFlaresGhosts2Offset; // 0x268
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float sunFlaresGhosts2Brightness; // 0x26C
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float sunFlaresGhosts3Size; // 0x270
		[Range] // 0x0000000180279B90-0x0000000180279BB0
		public float sunFlaresGhosts3Brightness; // 0x274
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float sunFlaresGhosts3Offset; // 0x278
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float sunFlaresGhosts4Size; // 0x27C
		[Range] // 0x0000000180279B90-0x0000000180279BB0
		public float sunFlaresGhosts4Offset; // 0x280
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float sunFlaresGhosts4Brightness; // 0x284
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float sunFlaresHaloOffset; // 0x288
		[Range] // 0x000000018027BB80-0x000000018027BBA0
		public float sunFlaresHaloAmplitude; // 0x28C
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float sunFlaresHaloIntensity; // 0x290
		public bool sunFlaresRotationDeadZone; // 0x294
		public bool blur; // 0x295
		[Range] // 0x000000018027BD90-0x000000018027BDB0
		public float blurIntensity; // 0x298
		public int pixelateAmount; // 0x29C
		public bool pixelateDownscale; // 0x2A0
	
		// Constructors
		public BeautifyProfile(); // 0x0000000181F55B60-0x0000000181F56090
	
		// Methods
		public void Load(Beautify b); // 0x0000000181F52BC0-0x0000000181F554D0
		public void Save(Beautify b); // 0x0000000181F554D0-0x0000000181F55B60
	}
}
