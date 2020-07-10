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
	public class OffsetEffector : OffsetModifier // TypeDefIndex: 9532
	{
		// Fields
		public EffectorLink[] effectorLinks; // 0x30
	
		// Nested types
		[Serializable]
		public class EffectorLink // TypeDefIndex: 9533
		{
			// Fields
			public FullBodyBipedEffector effectorType; // 0x10
			public float weightMultiplier; // 0x14
			[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
			public Vector3 localPosition; // 0x18
	
			// Constructors
			public EffectorLink(); // 0x000000018127EAF0-0x000000018127EB00
		}
	
		// Constructors
		public OffsetEffector(); // 0x0000000181638E90-0x0000000181638EA0
	
		// Methods
		protected override void Start(); // 0x0000000181837830-0x00000001818379D0
		protected override void OnModifyOffset(); // 0x0000000181837490-0x0000000181837830
	}
}
