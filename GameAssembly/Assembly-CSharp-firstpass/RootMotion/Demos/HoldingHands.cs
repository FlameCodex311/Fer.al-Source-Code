/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.Demos
{
	public class HoldingHands : UnityEngine.MonoBehaviour // TypeDefIndex: 9522
	{
		// Fields
		public FullBodyBipedIK rightHandChar; // 0x18
		public FullBodyBipedIK leftHandChar; // 0x20
		public Transform rightHandTarget; // 0x28
		public Transform leftHandTarget; // 0x30
		public float crossFade; // 0x38
		public float speed; // 0x3C
		private Quaternion rightHandRotation; // 0x40
		private Quaternion leftHandRotation; // 0x50
	
		// Constructors
		public HoldingHands(); // 0x0000000181832600-0x0000000181832610
	
		// Methods
		private void Start(); // 0x0000000181832400-0x0000000181832600
		private void LateUpdate(); // 0x0000000181831E60-0x0000000181832400
	}
}
