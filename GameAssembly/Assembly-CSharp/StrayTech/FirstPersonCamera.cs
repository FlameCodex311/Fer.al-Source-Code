/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace StrayTech
{
	public class FirstPersonCamera : ICameraState // TypeDefIndex: 14541
	{
		// Fields
		private FirstPersonCameraStateSettings _stateSettings; // 0x10
		private Quaternion _characterTargetRot; // 0x18
		private Quaternion _cameraTargetRot; // 0x28
		private Quaternion _cameraPitchRotation; // 0x38
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector3 <Position>k__BackingField; // 0x48
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Quaternion <Rotation>k__BackingField; // 0x54
	
		// Properties
		public ICameraStateSettings StateSettings { get; } // 0x0000000180372440-0x0000000180372450 
		public CameraSystem.CameraStateEnum StateType { get; } // 0x0000000180411150-0x0000000180411160 
		public bool AllowsModifiers { get; } // 0x0000000180380B60-0x0000000180380B70 
		public Vector3 Position { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180CB3D10-0x0000000180CB3D30 0x0000000180CB3D30-0x0000000180CB3D40
		public Quaternion Rotation { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018078D410-0x000000018078D420 0x0000000180CB3D40-0x0000000180CB3D50
	
		// Constructors
		public FirstPersonCamera(ICameraStateSettings stateSettings); // 0x0000000180CB3BA0-0x0000000180CB3D10
	
		// Methods
		public void UpdateCamera(float deltaTime); // 0x0000000180CB3630-0x0000000180CB3BA0
		private Quaternion ClampRotationAroundXAxis(Quaternion q); // 0x0000000180CB3530-0x0000000180CB3630
		public void Cleanup(); // 0x00000001803774A0-0x00000001803774B0
	}
}
