/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.FinalIK
{
	public class Amplifier : OffsetModifier // TypeDefIndex: 9455
	{
		// Fields
		[Tooltip] // 0x00000001800B6D50-0x00000001800B6D80
		public Body[] bodies; // 0x30
	
		// Nested types
		[Serializable]
		public class Body // TypeDefIndex: 9456
		{
			// Fields
			[Tooltip] // 0x00000001800B6FA0-0x00000001800B6FD0
			public Transform transform; // 0x10
			[Tooltip] // 0x00000001800B70B0-0x00000001800B70E0
			public Transform relativeTo; // 0x18
			[Tooltip] // 0x00000001800B7200-0x00000001800B7230
			public EffectorLink[] effectorLinks; // 0x20
			[Tooltip] // 0x00000001800B72D0-0x00000001800B7300
			public float verticalWeight; // 0x28
			[Tooltip] // 0x00000001800B7420-0x00000001800B7450
			public float horizontalWeight; // 0x2C
			[Tooltip] // 0x00000001800B7620-0x00000001800B7650
			public float speed; // 0x30
			private Vector3 lastRelativePos; // 0x34
			private Vector3 smoothDelta; // 0x40
			private bool firstUpdate; // 0x4C
	
			// Nested types
			[Serializable]
			public class EffectorLink // TypeDefIndex: 9457
			{
				// Fields
				[Tooltip] // 0x00000001800B7710-0x00000001800B7740
				public FullBodyBipedEffector effector; // 0x10
				[Tooltip] // 0x00000001800B7940-0x00000001800B7970
				public float weight; // 0x14
	
				// Constructors
				public EffectorLink(); // 0x000000018036B6C0-0x000000018036B6D0
			}
	
			// Constructors
			public Body(); // 0x000000018181FD90-0x000000018181FDB0
	
			// Methods
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime); // 0x000000018181F730-0x000000018181FD90
			private static Vector3 Multiply(Vector3 v1, Vector3 v2); // 0x000000018181F6D0-0x000000018181F730
		}
	
		// Constructors
		public Amplifier(); // 0x0000000181638E90-0x0000000181638EA0
	
		// Methods
		protected override void OnModifyOffset(); // 0x000000018181D730-0x000000018181D890
	}
}
