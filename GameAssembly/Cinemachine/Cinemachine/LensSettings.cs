/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

namespace Cinemachine
{
	[Serializable]
	[DocumentationSorting] // 0x00000001801D04D0-0x00000001801D04F0
	public struct LensSettings // TypeDefIndex: 7537
	{
		// Fields
		public static LensSettings Default; // 0x00
		[Range] // 0x00000001801FFB00-0x00000001801FFB60
		[Tooltip] // 0x00000001801FFB00-0x00000001801FFB60
		public float FieldOfView; // 0x00
		[Tooltip] // 0x00000001801FFC40-0x00000001801FFC70
		public float OrthographicSize; // 0x04
		[Tooltip] // 0x00000001801FFD90-0x00000001801FFDC0
		public float NearClipPlane; // 0x08
		[Tooltip] // 0x00000001801FFEF0-0x00000001801FFF20
		public float FarClipPlane; // 0x0C
		[Range] // 0x00000001802001D0-0x0000000180200220
		[Tooltip] // 0x00000001802001D0-0x0000000180200220
		public float Dutch; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <Orthographic>k__BackingField; // 0x14
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <IsPhysicalCamera>k__BackingField; // 0x15
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector2 <SensorSize>k__BackingField; // 0x18
		public Vector2 LensShift; // 0x20
	
		// Properties
		public bool Orthographic { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180006D20-0x0000000180006D30 0x0000000180006E10-0x0000000180006E20
		public bool IsPhysicalCamera { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018013D030-0x000000018013D040 0x000000018013D040-0x000000018013D110
		public Vector2 SensorSize { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001800B56E0-0x00000001800B5700 0x00000001800215D0-0x0000000180021790
		public float Aspect { get; } // 0x000000018013D000-0x000000018013D030 
	
		// Constructors
		public LensSettings(float fov, float orthographicSize, float nearClip, float farClip, float dutch); // 0x000000018013CFC0-0x000000018013D000
		static LensSettings(); // 0x0000000181FF7000-0x0000000181FF7170
	
		// Methods
		public static LensSettings FromCamera(Camera fromCamera); // 0x0000000181FF6AA0-0x0000000181FF6BE0
		public void SnapshotCameraReadOnlyProperties(Camera camera); // 0x000000018013CEE0-0x000000018013CEF0
		public static LensSettings Lerp(LensSettings lensA, LensSettings lensB, float t); // 0x0000000181FF6BE0-0x0000000181FF7000
		public void Validate(); // 0x000000018013CEF0-0x000000018013CFC0
	}
}
