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
	public class Inertia : OffsetModifier // TypeDefIndex: 10005
	{
		// Fields
		[Tooltip] // 0x00000001802811B0-0x00000001802811E0
		public Body[] bodies; // 0x30
		[Tooltip] // 0x00000001802813C0-0x00000001802813F0
		public OffsetLimits[] limits; // 0x38
	
		// Nested types
		[Serializable]
		public class Body // TypeDefIndex: 10006
		{
			// Fields
			[Tooltip] // 0x0000000180281650-0x0000000180281680
			public Transform transform; // 0x10
			[Tooltip] // 0x00000001802817D0-0x0000000180281800
			public EffectorLink[] effectorLinks; // 0x18
			[Tooltip] // 0x0000000180281910-0x0000000180281940
			public float speed; // 0x20
			[Tooltip] // 0x0000000180281A70-0x0000000180281AA0
			public float acceleration; // 0x24
			[Range] // 0x0000000180281C80-0x0000000180281CE0
			[Tooltip] // 0x0000000180281C80-0x0000000180281CE0
			public float matchVelocity; // 0x28
			[Tooltip] // 0x0000000180281EB0-0x0000000180281EE0
			public float gravity; // 0x2C
			private Vector3 delta; // 0x30
			private Vector3 lazyPoint; // 0x3C
			private Vector3 direction; // 0x48
			private Vector3 lastPosition; // 0x54
			private bool firstUpdate; // 0x60
	
			// Nested types
			[Serializable]
			public class EffectorLink // TypeDefIndex: 10007
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
			public Body(); // 0x000000018162B950-0x000000018162B970
	
			// Methods
			public void Reset(); // 0x000000018162B2A0-0x000000018162B3A0
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime); // 0x000000018162B3A0-0x000000018162B950
		}
	
		// Constructors
		public Inertia(); // 0x0000000181381DA0-0x0000000181381DB0
	
		// Methods
		public void ResetBodies(); // 0x000000018162D2E0-0x000000018162D360
		protected override void OnModifyOffset(); // 0x000000018162D130-0x000000018162D2E0
	}
}
