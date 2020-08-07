/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

namespace Cinemachine
{
	public struct CameraState // TypeDefIndex: 7500
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private LensSettings <Lens>k__BackingField; // 0x00
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector3 <ReferenceUp>k__BackingField; // 0x28
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector3 <ReferenceLookAt>k__BackingField; // 0x34
		public static Vector3 kNoPoint; // 0x00
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector3 <RawPosition>k__BackingField; // 0x40
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Quaternion <RawOrientation>k__BackingField; // 0x4C
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector3 <PositionDampingBypass>k__BackingField; // 0x5C
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float <ShotQuality>k__BackingField; // 0x68
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector3 <PositionCorrection>k__BackingField; // 0x6C
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Quaternion <OrientationCorrection>k__BackingField; // 0x78
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private BlendHintValue <BlendHint>k__BackingField; // 0x88
		private CustomBlendable mCustom0; // 0x90
		private CustomBlendable mCustom1; // 0xA0
		private CustomBlendable mCustom2; // 0xB0
		private CustomBlendable mCustom3; // 0xC0
		private List<CustomBlendable> m_CustomOverflow; // 0xD0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <NumCustomBlendables>k__BackingField; // 0xD8
	
		// Properties
		public LensSettings Lens { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001800C0B00-0x00000001800C0B20 0x000000018002D290-0x000000018002D2B0
		public Vector3 ReferenceUp { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001800C0BD0-0x00000001800C0BF0 0x00000001800C0C90-0x00000001800C0CA0
		public Vector3 ReferenceLookAt { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001800C0BB0-0x00000001800C0BD0 0x00000001800C0C80-0x00000001800C0C90
		public bool HasLookAt { get; } // 0x00000001800C0AF0-0x00000001800C0B00 
		public Vector3 RawPosition { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001800C0B90-0x00000001800C0BB0 0x00000001800C0C70-0x00000001800C0C80
		public Quaternion RawOrientation { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001800C0B80-0x00000001800C0B90 0x00000001800C0C60-0x00000001800C0C70
		public Vector3 PositionDampingBypass { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001800C0B60-0x00000001800C0B80 0x00000001800C0C50-0x00000001800C0C60
		public float ShotQuality { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001800C0BF0-0x00000001800C0C00 0x00000001800C0CA0-0x00000001800C0CD0
		public Vector3 PositionCorrection { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001800C0B40-0x00000001800C0B60 0x00000001800C0C30-0x00000001800C0C50
		public Quaternion OrientationCorrection { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001800C0B30-0x00000001800C0B40 0x00000001800C0C20-0x00000001800C0C30
		public Vector3 CorrectedPosition { get; } // 0x00000001800C0A90-0x00000001800C0AB0 
		public Quaternion CorrectedOrientation { get; } // 0x00000001800C0A70-0x00000001800C0A90 
		public Vector3 FinalPosition { get; } // 0x00000001800C0AD0-0x00000001800C0AF0 
		public Quaternion FinalOrientation { get; } // 0x00000001800C0AB0-0x00000001800C0AD0 
		public BlendHintValue BlendHint { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180021790-0x0000000180021830 0x00000001800C0C00-0x00000001800C0C10
		public static CameraState Default { get; } // 0x000000018134A920-0x000000018134AE40 
		public int NumCustomBlendables { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001800C0B20-0x00000001800C0B30 0x00000001800C0C10-0x00000001800C0C20
	
		// Nested types
		public enum BlendHintValue // TypeDefIndex: 7501
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
	
		public struct CustomBlendable // TypeDefIndex: 7502
		{
			// Fields
			public UnityEngine.Object m_Custom; // 0x00
			public float m_Weight; // 0x08
	
			// Constructors
			public CustomBlendable(UnityEngine.Object custom, float weight); // 0x00000001800C0D90-0x00000001800C0DF0
		}
	
		// Constructors
		static CameraState(); // 0x000000018134A740-0x000000018134A920
	
		// Methods
		public CustomBlendable GetCustomBlendable(int index); // 0x00000001800C09A0-0x00000001800C09C0
		private int FindCustomBlendable(UnityEngine.Object custom); // 0x00000001800C0990-0x00000001800C09A0
		public void AddCustomBlendable(CustomBlendable b); // 0x00000001800C0970-0x00000001800C0990
		public static CameraState Lerp(CameraState stateA, CameraState stateB, float t); // 0x00000001813494D0-0x000000018134A740
		private static float InterpolateFOV(float fovA, float fovB, float dA, float dB, float t); // 0x0000000181348DD0-0x00000001813494D0
		private static Vector3 ApplyPosBlendHint(Vector3 posA, BlendHintValue hintA, Vector3 posB, BlendHintValue hintB, Vector3 original, Vector3 blended); // 0x00000001813489E0-0x0000000181348A60
		private static Quaternion ApplyRotBlendHint(Quaternion rotA, BlendHintValue hintA, Quaternion rotB, BlendHintValue hintB, Quaternion original, Quaternion blended); // 0x0000000181348A60-0x0000000181348DD0
		private Vector3 InterpolatePosition(Vector3 posA, Vector3 pivotA, Vector3 posB, Vector3 pivotB, float t); // 0x00000001800C09C0-0x00000001800C0A70
	}
}
