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
	public class FirstPersonCamera : ICameraState // TypeDefIndex: 13874
	{
		// Fields
		private FirstPersonCameraStateSettings _stateSettings; // 0x10
		private Quaternion _characterTargetRot; // 0x18
		private Quaternion _cameraTargetRot; // 0x28
		private Quaternion _cameraPitchRotation; // 0x38
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector3 <Position>k__BackingField; // 0x48
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Quaternion <Rotation>k__BackingField; // 0x54
	
		// Properties
		public ICameraStateSettings StateSettings { get; } // 0x000000018036AC80-0x000000018036AC90 
		public CameraSystem.CameraStateEnum StateType { get; } // 0x0000000180362180-0x0000000180362190 
		public bool AllowsModifiers { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		public Vector3 Position { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001811FE780-0x00000001811FE7A0 0x00000001811FE7B0-0x00000001811FE7C0
		public Quaternion Rotation { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001811FE7A0-0x00000001811FE7B0 0x00000001811FE7C0-0x00000001811FE7D0
	
		// Constructors
		public FirstPersonCamera(ICameraStateSettings stateSettings); // 0x00000001811FE610-0x00000001811FE780
	
		// Methods
		public void UpdateCamera(float deltaTime); // 0x00000001811FE080-0x00000001811FE610
		private Quaternion ClampRotationAroundXAxis(Quaternion q); // 0x00000001811FDF80-0x00000001811FE080
		public void Cleanup(); // 0x00000001803581E0-0x00000001803581F0
	}
}
