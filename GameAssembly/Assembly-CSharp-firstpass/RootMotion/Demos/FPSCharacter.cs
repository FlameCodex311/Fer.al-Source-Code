/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.Demos
{
	[RequireComponent] // 0x0000000180210EE0-0x0000000180210F60
	[RequireComponent] // 0x0000000180210EE0-0x0000000180210F60
	public class FPSCharacter : UnityEngine.MonoBehaviour // TypeDefIndex: 9807
	{
		// Fields
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float walkSpeed; // 0x18
		private float sVel; // 0x1C
		private Animator animator; // 0x20
		private FPSAiming FPSAiming; // 0x28
	
		// Constructors
		public FPSCharacter(); // 0x0000000181378170-0x0000000181378180
	
		// Methods
		private void Start(); // 0x0000000181377FC0-0x0000000181378010
		private void Update(); // 0x0000000181378010-0x0000000181378170
		private void OnGUI(); // 0x0000000181377F10-0x0000000181377FC0
	}
}
