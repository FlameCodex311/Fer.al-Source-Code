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
	public class SplineCamera : ICameraState // TypeDefIndex: 13879
	{
		// Fields
		private SplineCameraStateSettings _stateSettings; // 0x10
		private Transform _cameraLookAtTransform; // 0x18
		private float _currentSplineT; // 0x20
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector3 <Position>k__BackingField; // 0x24
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Quaternion <Rotation>k__BackingField; // 0x30
	
		// Properties
		public ICameraStateSettings StateSettings { get; } // 0x000000018036AC80-0x000000018036AC90 
		public CameraSystem.CameraStateEnum StateType { get; } // 0x000000018042E670-0x000000018042E680 
		public bool AllowsModifiers { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		public Vector3 Position { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001807A1520-0x00000001807A1540 0x0000000181203B60-0x0000000181203B70
		public Quaternion Rotation { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018038E0C0-0x000000018038E0D0 0x0000000180DD2D40-0x0000000180DD2D50
	
		// Constructors
		public SplineCamera(ICameraStateSettings stateSettings); // 0x0000000181203AC0-0x0000000181203B60
	
		// Methods
		public void UpdateCamera(float deltaTime); // 0x0000000181203160-0x0000000181203AC0
		public void Cleanup(); // 0x0000000181203150-0x0000000181203160
	}
}
