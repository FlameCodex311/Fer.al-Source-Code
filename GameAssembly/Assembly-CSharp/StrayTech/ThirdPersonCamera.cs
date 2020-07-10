/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace StrayTech
{
	public class ThirdPersonCamera : ICameraState // TypeDefIndex: 13880
	{
		// Fields
		private ThirdPersonCameraStateSettings _stateSettings; // 0x10
		private Transform _cameraLookAtTransform; // 0x18
		private float _orbitDistance; // 0x20
		private float _mouseOrbitY; // 0x24
		private float _mouseOrbitX; // 0x28
		private Quaternion _currentOrbitRotation; // 0x2C
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector3 <Position>k__BackingField; // 0x3C
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Quaternion <Rotation>k__BackingField; // 0x48
	
		// Properties
		public ICameraStateSettings StateSettings { get; } // 0x000000018036AC80-0x000000018036AC90 
		public CameraSystem.CameraStateEnum StateType { get; } // 0x000000018038FAD0-0x000000018038FAE0 
		public bool AllowsModifiers { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		public Vector3 Position { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000181211870-0x0000000181211890 0x0000000181211890-0x00000001812118A0
		public Quaternion Rotation { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180485980-0x0000000180485990 0x00000001804D5370-0x00000001804D5380
	
		// Constructors
		public ThirdPersonCamera(ICameraStateSettings stateSettings); // 0x0000000181211590-0x0000000181211870
	
		// Methods
		public void UpdateCamera(float deltaTime); // 0x0000000181210E40-0x0000000181211590
		public void Cleanup(); // 0x00000001803581E0-0x00000001803581F0
		public static float ClampAngle(float angle, float min, float max); // 0x0000000181210DA0-0x0000000181210E40
	}
}
