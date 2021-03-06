﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace StrayTech
{
	public class PivotCamera : ICameraState // TypeDefIndex: 14545
	{
		// Fields
		private PivotCameraStateSettings _stateSettings; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector3 <Position>k__BackingField; // 0x18
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Quaternion <Rotation>k__BackingField; // 0x24
	
		// Properties
		public ICameraStateSettings StateSettings { get; } // 0x0000000180372440-0x0000000180372450 
		public CameraSystem.CameraStateEnum StateType { get; } // 0x000000018040D640-0x000000018040D650 
		public bool AllowsModifiers { get; } // 0x0000000180380B60-0x0000000180380B70 
		public Vector3 Position { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180CB5AC0-0x0000000180CB5AE0 0x0000000180CB5AE0-0x0000000180CB5AF0
		public Quaternion Rotation { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001806CEAD0-0x00000001806CEAE0 0x0000000180CB5AF0-0x0000000180CB5B00
	
		// Constructors
		public PivotCamera(ICameraStateSettings stateSettings); // 0x0000000180CB67A0-0x0000000180CB6830
	
		// Methods
		public void UpdateCamera(float deltaTime); // 0x0000000180CB63A0-0x0000000180CB67A0
		public void Cleanup(); // 0x00000001803774A0-0x00000001803774B0
	}
}
