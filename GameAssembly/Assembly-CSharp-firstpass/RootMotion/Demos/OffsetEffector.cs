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
	public class OffsetEffector : OffsetModifier // TypeDefIndex: 9819
	{
		// Fields
		public EffectorLink[] effectorLinks; // 0x30
	
		// Nested types
		[Serializable]
		public class EffectorLink // TypeDefIndex: 9820
		{
			// Fields
			public FullBodyBipedEffector effectorType; // 0x10
			public float weightMultiplier; // 0x14
			[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
			public Vector3 localPosition; // 0x18
	
			// Constructors
			public EffectorLink(); // 0x00000001807843A0-0x00000001807843B0
		}
	
		// Constructors
		public OffsetEffector(); // 0x0000000181365EE0-0x0000000181365EF0
	
		// Methods
		protected override void Start(); // 0x000000018137E2A0-0x000000018137E430
		protected override void OnModifyOffset(); // 0x000000018137DF10-0x000000018137E2A0
	}
}
