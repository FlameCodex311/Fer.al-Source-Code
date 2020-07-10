/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

namespace Cinemachine
{
	public struct CameraState // TypeDefIndex: 7334
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private LensSettings <Lens>k__BackingField; // 0x00
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector3 <ReferenceUp>k__BackingField; // 0x28
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector3 <ReferenceLookAt>k__BackingField; // 0x34
		public static Vector3 kNoPoint; // 0x00
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector3 <RawPosition>k__BackingField; // 0x40
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Quaternion <RawOrientation>k__BackingField; // 0x4C
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector3 <PositionDampingBypass>k__BackingField; // 0x5C
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private float <ShotQuality>k__BackingField; // 0x68
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector3 <PositionCorrection>k__BackingField; // 0x6C
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Quaternion <OrientationCorrection>k__BackingField; // 0x78
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private BlendHintValue <BlendHint>k__BackingField; // 0x88
		private CustomBlendable mCustom0; // 0x90
		private CustomBlendable mCustom1; // 0xA0
		private CustomBlendable mCustom2; // 0xB0
		private CustomBlendable mCustom3; // 0xC0
		private List<CustomBlendable> m_CustomOverflow; // 0xD0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <NumCustomBlendables>k__BackingField; // 0xD8
	
		// Properties
		public LensSettings Lens { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001802A31A0-0x00000001802A31C0 0x000000018021DFD0-0x000000018021DFF0
		public Vector3 ReferenceUp { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001802A3270-0x00000001802A3290 0x00000001802A3330-0x00000001802A3360
		public Vector3 ReferenceLookAt { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001802A3250-0x00000001802A3270 0x00000001802A3320-0x00000001802A3330
		public bool HasLookAt { get; } // 0x00000001802A3190-0x00000001802A31A0 
		public Vector3 RawPosition { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001802A3230-0x00000001802A3250 0x00000001802A3310-0x00000001802A3320
		public Quaternion RawOrientation { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001802A3220-0x00000001802A3230 0x00000001802A3300-0x00000001802A3310
		public Vector3 PositionDampingBypass { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001802A3200-0x00000001802A3220 0x00000001802A32F0-0x00000001802A3300
		public float ShotQuality { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001802A3290-0x00000001802A32A0 0x000000018002ADB0-0x000000018002ADC0
		public Vector3 PositionCorrection { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001802A31E0-0x00000001802A3200 0x00000001802A32D0-0x00000001802A32F0
		public Quaternion OrientationCorrection { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001802A31D0-0x00000001802A31E0 0x00000001802A32C0-0x00000001802A32D0
		public Vector3 CorrectedPosition { get; } // 0x00000001802A3130-0x00000001802A3150 
		public Quaternion CorrectedOrientation { get; } // 0x00000001802A3110-0x00000001802A3130 
		public Vector3 FinalPosition { get; } // 0x00000001802A3170-0x00000001802A3190 
		public Quaternion FinalOrientation { get; } // 0x00000001802A3150-0x00000001802A3170 
		public BlendHintValue BlendHint { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180004F50-0x0000000180004FF0 0x00000001802A32A0-0x00000001802A32B0
		public static CameraState Default { get; } // 0x00000001818A43E0-0x00000001818A4900 
		public int NumCustomBlendables { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001802A31C0-0x00000001802A31D0 0x00000001802A32B0-0x00000001802A32C0
	
		// Nested types
		public enum BlendHintValue // TypeDefIndex: 7335
		{
			Nothing = 0,
			NoPosition = 1,
			NoOrientation = 2,
			NoTransform = 3,
			SphericalPositionBlend = 4,
			CylindricalPositionBlend = 8,
			RadialAimBlend = 16,
			IgnoreLookAtTarget = 32,
			NoLens = 64
		}
	
		public struct CustomBlendable // TypeDefIndex: 7336
		{
			// Fields
			public UnityEngine.Object m_Custom; // 0x00
			public float m_Weight; // 0x08
	
			// Constructors
			public CustomBlendable(UnityEngine.Object custom, float weight); // 0x00000001802A3420-0x00000001802A3480
		}
	
		// Constructors
		static CameraState(); // 0x00000001818A4200-0x00000001818A43E0
	
		// Methods
		public CustomBlendable GetCustomBlendable(int index); // 0x00000001802A3040-0x00000001802A3060
		private int FindCustomBlendable(UnityEngine.Object custom); // 0x00000001802A3030-0x00000001802A3040
		public void AddCustomBlendable(CustomBlendable b); // 0x00000001802A3010-0x00000001802A3030
		public static CameraState Lerp(CameraState stateA, CameraState stateB, float t); // 0x00000001818A2F90-0x00000001818A4200
		private static float InterpolateFOV(float fovA, float fovB, float dA, float dB, float t); // 0x00000001818A2890-0x00000001818A2F90
		private static Vector3 ApplyPosBlendHint(Vector3 posA, BlendHintValue hintA, Vector3 posB, BlendHintValue hintB, Vector3 original, Vector3 blended); // 0x00000001818A2490-0x00000001818A2510
		private static Quaternion ApplyRotBlendHint(Quaternion rotA, BlendHintValue hintA, Quaternion rotB, BlendHintValue hintB, Quaternion original, Quaternion blended); // 0x00000001818A2510-0x00000001818A2890
		private Vector3 InterpolatePosition(Vector3 posA, Vector3 pivotA, Vector3 posB, Vector3 pivotB, float t); // 0x00000001802A3060-0x00000001802A3110
	}
}
