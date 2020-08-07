/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.FinalIK
{
	public class Amplifier : OffsetModifier // TypeDefIndex: 9989
	{
		// Fields
		[Tooltip] // 0x0000000180278770-0x00000001802787A0
		public Body[] bodies; // 0x30
	
		// Nested types
		[Serializable]
		public class Body // TypeDefIndex: 9990
		{
			// Fields
			[Tooltip] // 0x0000000180278950-0x0000000180278980
			public Transform transform; // 0x10
			[Tooltip] // 0x0000000180278B70-0x0000000180278BA0
			public Transform relativeTo; // 0x18
			[Tooltip] // 0x0000000180278D80-0x0000000180278DB0
			public EffectorLink[] effectorLinks; // 0x20
			[Tooltip] // 0x0000000180278F20-0x0000000180278F50
			public float verticalWeight; // 0x28
			[Tooltip] // 0x0000000180279090-0x00000001802790C0
			public float horizontalWeight; // 0x2C
			[Tooltip] // 0x00000001802792B0-0x00000001802792E0
			public float speed; // 0x30
			private Vector3 lastRelativePos; // 0x34
			private Vector3 smoothDelta; // 0x40
			private bool firstUpdate; // 0x4C
	
			// Nested types
			[Serializable]
			public class EffectorLink // TypeDefIndex: 9991
			{
				// Fields
				[Tooltip] // 0x0000000180279410-0x0000000180279440
				public FullBodyBipedEffector effector; // 0x10
				[Tooltip] // 0x00000001802795C0-0x00000001802795F0
				public float weight; // 0x14
	
				// Constructors
				public EffectorLink(); // 0x0000000180373240-0x0000000180373250
			}
	
			// Constructors
			public Body(); // 0x0000000181425470-0x0000000181425490
	
			// Methods
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime); // 0x0000000181424E30-0x0000000181425470
			private static Vector3 Multiply(Vector3 v1, Vector3 v2); // 0x0000000181424DD0-0x0000000181424E30
		}
	
		// Constructors
		public Amplifier(); // 0x0000000181365EE0-0x0000000181365EF0
	
		// Methods
		protected override void OnModifyOffset(); // 0x0000000181422F00-0x0000000181423050
	}
}
