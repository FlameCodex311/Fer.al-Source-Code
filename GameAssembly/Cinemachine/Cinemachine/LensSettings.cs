/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

namespace Cinemachine
{
	[Serializable]
	[DocumentationSorting] // 0x00000001800B83F0-0x00000001800B8410
	public struct LensSettings // TypeDefIndex: 7371
	{
		// Fields
		public static LensSettings Default; // 0x00
		[Range] // 0x000000018015E5D0-0x000000018015E630
		[Tooltip] // 0x000000018015E5D0-0x000000018015E630
		public float FieldOfView; // 0x00
		[Tooltip] // 0x000000018015E8D0-0x000000018015E900
		public float OrthographicSize; // 0x04
		[Tooltip] // 0x000000018015EAD0-0x000000018015EB00
		public float NearClipPlane; // 0x08
		[Tooltip] // 0x000000018015ECA0-0x000000018015ECD0
		public float FarClipPlane; // 0x0C
		[Range] // 0x000000018015EDA0-0x000000018015EDF0
		[Tooltip] // 0x000000018015EDA0-0x000000018015EDF0
		public float Dutch; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <Orthographic>k__BackingField; // 0x14
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <IsPhysicalCamera>k__BackingField; // 0x15
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector2 <SensorSize>k__BackingField; // 0x18
		public Vector2 LensShift; // 0x20
	
		// Properties
		public bool Orthographic { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018020A4D0-0x000000018020A4E0 0x000000018020A5C0-0x000000018020A5F0
		public bool IsPhysicalCamera { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001802991C0-0x00000001802991D0 0x00000001802991D0-0x00000001802992A0
		public Vector2 SensorSize { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180010FE0-0x0000000180011000 0x0000000180004CE0-0x0000000180004CF0
		public float Aspect { get; } // 0x0000000180299190-0x00000001802991C0 
	
		// Constructors
		public LensSettings(float fov, float orthographicSize, float nearClip, float farClip, float dutch); // 0x0000000180299150-0x0000000180299190
		static LensSettings(); // 0x00000001817E7B20-0x00000001817E7C90
	
		// Methods
		public static LensSettings FromCamera(Camera fromCamera); // 0x00000001817E75C0-0x00000001817E7700
		public void SnapshotCameraReadOnlyProperties(Camera camera); // 0x0000000180299130-0x0000000180299140
		public static LensSettings Lerp(LensSettings lensA, LensSettings lensB, float t); // 0x00000001817E7700-0x00000001817E7B20
		public void Validate(); // 0x0000000180299140-0x0000000180299150
	}
}
