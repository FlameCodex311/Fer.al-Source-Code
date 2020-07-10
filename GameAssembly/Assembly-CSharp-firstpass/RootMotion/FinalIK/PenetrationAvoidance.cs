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
	public class PenetrationAvoidance : OffsetModifier // TypeDefIndex: 9482
	{
		// Fields
		[Tooltip] // 0x00000001800C70A0-0x00000001800C70D0
		public Avoider[] avoiders; // 0x30
	
		// Nested types
		[Serializable]
		public class Avoider // TypeDefIndex: 9483
		{
			// Fields
			[Tooltip] // 0x00000001800C7280-0x00000001800C72B0
			public Transform[] raycastFrom; // 0x10
			[Tooltip] // 0x00000001800C74B0-0x00000001800C74E0
			public Transform raycastTo; // 0x18
			[Range] // 0x00000001800C7760-0x00000001800C77C0
			[Tooltip] // 0x00000001800C7760-0x00000001800C77C0
			public float raycastRadius; // 0x20
			[Tooltip] // 0x00000001800C7B40-0x00000001800C7B70
			public EffectorLink[] effectors; // 0x28
			[Tooltip] // 0x00000001800C7CD0-0x00000001800C7D00
			public float smoothTimeIn; // 0x30
			[Tooltip] // 0x00000001800C8110-0x00000001800C8140
			public float smoothTimeOut; // 0x34
			[Tooltip] // 0x00000001800C8450-0x00000001800C8480
			public LayerMask layers; // 0x38
			private Vector3 offset; // 0x3C
			private Vector3 offsetTarget; // 0x48
			private Vector3 offsetV; // 0x54
	
			// Nested types
			[Serializable]
			public class EffectorLink // TypeDefIndex: 9484
			{
				// Fields
				[Tooltip] // 0x00000001800C8730-0x00000001800C8760
				public FullBodyBipedEffector effector; // 0x10
				[Tooltip] // 0x00000001800C8A00-0x00000001800C8A30
				public float weight; // 0x14
	
				// Constructors
				public EffectorLink(); // 0x000000018036B6C0-0x000000018036B6D0
			}
	
			// Constructors
			public Avoider(); // 0x0000000181AF26A0-0x0000000181AF26C0
	
			// Methods
			public void Solve(IKSolverFullBodyBiped solver, float weight); // 0x0000000181AF23E0-0x0000000181AF26A0
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver); // 0x0000000181AF1E80-0x0000000181AF20E0
			private Vector3 Raycast(Vector3 from, Vector3 to); // 0x0000000181AF20E0-0x0000000181AF23E0
		}
	
		// Constructors
		public PenetrationAvoidance(); // 0x000000018183B940-0x000000018183B950
	
		// Methods
		protected override void OnModifyOffset(); // 0x0000000181B0AD00-0x0000000181B0ADA0
	}
}
