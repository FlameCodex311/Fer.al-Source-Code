/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.Demos
{
	[RequireComponent] // 0x00000001800D7ED0-0x00000001800D7F50
	[RequireComponent] // 0x00000001800D7ED0-0x00000001800D7F50
	public class FPSCharacter : UnityEngine.MonoBehaviour // TypeDefIndex: 9520
	{
		// Fields
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float walkSpeed; // 0x18
		private float sVel; // 0x1C
		private Animator animator; // 0x20
		private FPSAiming FPSAiming; // 0x28
	
		// Constructors
		public FPSCharacter(); // 0x00000001818316D0-0x00000001818316E0
	
		// Methods
		private void Start(); // 0x0000000181831510-0x0000000181831560
		private void Update(); // 0x0000000181831560-0x00000001818316D0
		private void OnGUI(); // 0x0000000181831460-0x0000000181831510
	}
}
