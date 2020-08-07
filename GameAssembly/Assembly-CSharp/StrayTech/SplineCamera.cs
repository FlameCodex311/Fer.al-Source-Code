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
	public class SplineCamera : ICameraState // TypeDefIndex: 14546
	{
		// Fields
		private SplineCameraStateSettings _stateSettings; // 0x10
		private Transform _cameraLookAtTransform; // 0x18
		private float _currentSplineT; // 0x20
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector3 <Position>k__BackingField; // 0x24
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Quaternion <Rotation>k__BackingField; // 0x30
	
		// Properties
		public ICameraStateSettings StateSettings { get; } // 0x0000000180372440-0x0000000180372450 
		public CameraSystem.CameraStateEnum StateType { get; } // 0x000000018058C710-0x000000018058C720 
		public bool AllowsModifiers { get; } // 0x0000000180380B60-0x0000000180380B70 
		public Vector3 Position { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001806757C0-0x00000001806757E0 0x0000000180CA4690-0x0000000180CA46A0
		public Quaternion Rotation { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018043C660-0x000000018043C670 0x0000000180CA46A0-0x0000000180CA46B0
	
		// Constructors
		public SplineCamera(ICameraStateSettings stateSettings); // 0x0000000180CB82C0-0x0000000180CB8360
	
		// Methods
		public void UpdateCamera(float deltaTime); // 0x0000000180CB77B0-0x0000000180CB82C0
		public void Cleanup(); // 0x0000000180CB77A0-0x0000000180CB77B0
	}
}
