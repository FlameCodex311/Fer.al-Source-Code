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
	public class Inertia : OffsetModifier // TypeDefIndex: 9471
	{
		// Fields
		[Tooltip] // 0x00000001800C0D00-0x00000001800C0D30
		public Body[] bodies; // 0x30
		[Tooltip] // 0x00000001800C0E30-0x00000001800C0E60
		public OffsetLimits[] limits; // 0x38
	
		// Nested types
		[Serializable]
		public class Body // TypeDefIndex: 9472
		{
			// Fields
			[Tooltip] // 0x00000001800C1070-0x00000001800C10A0
			public Transform transform; // 0x10
			[Tooltip] // 0x00000001800C11C0-0x00000001800C11F0
			public EffectorLink[] effectorLinks; // 0x18
			[Tooltip] // 0x00000001800C1350-0x00000001800C1380
			public float speed; // 0x20
			[Tooltip] // 0x00000001800C1620-0x00000001800C1650
			public float acceleration; // 0x24
			[Range] // 0x00000001800C17F0-0x00000001800C1850
			[Tooltip] // 0x00000001800C17F0-0x00000001800C1850
			public float matchVelocity; // 0x28
			[Tooltip] // 0x00000001800C1AD0-0x00000001800C1B00
			public float gravity; // 0x2C
			private Vector3 delta; // 0x30
			private Vector3 lazyPoint; // 0x3C
			private Vector3 direction; // 0x48
			private Vector3 lastPosition; // 0x54
			private bool firstUpdate; // 0x60
	
			// Nested types
			[Serializable]
			public class EffectorLink // TypeDefIndex: 9473
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
			public Body(); // 0x0000000181AF2D90-0x0000000181AF2DB0
	
			// Methods
			public void Reset(); // 0x0000000181AF26C0-0x0000000181AF27D0
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime); // 0x0000000181AF27D0-0x0000000181AF2D90
		}
	
		// Constructors
		public Inertia(); // 0x000000018183B940-0x000000018183B950
	
		// Methods
		public void ResetBodies(); // 0x0000000181AF4780-0x0000000181AF4800
		protected override void OnModifyOffset(); // 0x0000000181AF45C0-0x0000000181AF4780
	}
}
