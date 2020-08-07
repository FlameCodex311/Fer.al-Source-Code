/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.Demos
{
	public class EffectorOffset : OffsetModifier // TypeDefIndex: 9799
	{
		// Fields
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float handsMaintainRelativePositionWeight; // 0x30
		public Vector3 bodyOffset; // 0x34
		public Vector3 leftShoulderOffset; // 0x40
		public Vector3 rightShoulderOffset; // 0x4C
		public Vector3 leftThighOffset; // 0x58
		public Vector3 rightThighOffset; // 0x64
		public Vector3 leftHandOffset; // 0x70
		public Vector3 rightHandOffset; // 0x7C
		public Vector3 leftFootOffset; // 0x88
		public Vector3 rightFootOffset; // 0x94
	
		// Constructors
		public EffectorOffset(); // 0x0000000181365EE0-0x0000000181365EF0
	
		// Methods
		protected override void OnModifyOffset(); // 0x0000000181373E70-0x00000001813748B0
	}
}
