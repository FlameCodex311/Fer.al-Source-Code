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
	public class ThirdPersonCamera : ICameraState // TypeDefIndex: 14547
	{
		// Fields
		private ThirdPersonCameraStateSettings _stateSettings; // 0x10
		private Transform _cameraLookAtTransform; // 0x18
		private float _orbitDistance; // 0x20
		private float _mouseOrbitY; // 0x24
		private float _mouseOrbitX; // 0x28
		private Quaternion _currentOrbitRotation; // 0x2C
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector3 <Position>k__BackingField; // 0x3C
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Quaternion <Rotation>k__BackingField; // 0x48
	
		// Properties
		public ICameraStateSettings StateSettings { get; } // 0x0000000180372440-0x0000000180372450 
		public CameraSystem.CameraStateEnum StateType { get; } // 0x000000018043E010-0x000000018043E020 
		public bool AllowsModifiers { get; } // 0x0000000180380B60-0x0000000180380B70 
		public Vector3 Position { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180CBD400-0x0000000180CBD420 0x0000000180CBD420-0x0000000180CBD600
		public Quaternion Rotation { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018099C970-0x000000018099C980 0x0000000180A92490-0x0000000180A924A0
	
		// Constructors
		public ThirdPersonCamera(ICameraStateSettings stateSettings); // 0x0000000180CBD120-0x0000000180CBD400
	
		// Methods
		public void UpdateCamera(float deltaTime); // 0x0000000180CBC9E0-0x0000000180CBD120
		public void Cleanup(); // 0x00000001803774A0-0x00000001803774B0
		public static float ClampAngle(float angle, float min, float max); // 0x0000000180CBC940-0x0000000180CBC9E0
	}
}
