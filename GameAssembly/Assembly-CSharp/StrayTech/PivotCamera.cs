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
	public class PivotCamera : ICameraState // TypeDefIndex: 13878
	{
		// Fields
		private PivotCameraStateSettings _stateSettings; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector3 <Position>k__BackingField; // 0x18
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Quaternion <Rotation>k__BackingField; // 0x24
	
		// Properties
		public ICameraStateSettings StateSettings { get; } // 0x000000018036AC80-0x000000018036AC90 
		public CameraSystem.CameraStateEnum StateType { get; } // 0x000000018035E180-0x000000018035E190 
		public bool AllowsModifiers { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		public Vector3 Position { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000181200DA0-0x0000000181200DC0 0x0000000181200DC0-0x0000000181200DD0
		public Quaternion Rotation { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180E98260-0x0000000180E98270 0x0000000181200DD0-0x0000000181200DE0
	
		// Constructors
		public PivotCamera(ICameraStateSettings stateSettings); // 0x0000000181201C40-0x0000000181201CD0
	
		// Methods
		public void UpdateCamera(float deltaTime); // 0x0000000181201830-0x0000000181201C40
		public void Cleanup(); // 0x00000001803581E0-0x00000001803581F0
	}
}
