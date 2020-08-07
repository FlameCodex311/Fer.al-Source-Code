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
	public class PenetrationAvoidance : OffsetModifier // TypeDefIndex: 10016
	{
		// Fields
		[Tooltip] // 0x00000001802871A0-0x00000001802871D0
		public Avoider[] avoiders; // 0x30
	
		// Nested types
		[Serializable]
		public class Avoider // TypeDefIndex: 10017
		{
			// Fields
			[Tooltip] // 0x0000000180287380-0x00000001802873B0
			public Transform[] raycastFrom; // 0x10
			[Tooltip] // 0x0000000180288780-0x00000001802887B0
			public Transform raycastTo; // 0x18
			[Range] // 0x00000001802888D0-0x0000000180288930
			[Tooltip] // 0x00000001802888D0-0x0000000180288930
			public float raycastRadius; // 0x20
			[Tooltip] // 0x0000000180288A30-0x0000000180288A60
			public EffectorLink[] effectors; // 0x28
			[Tooltip] // 0x0000000180288B10-0x0000000180288B40
			public float smoothTimeIn; // 0x30
			[Tooltip] // 0x0000000180288C50-0x0000000180288C80
			public float smoothTimeOut; // 0x34
			[Tooltip] // 0x0000000180288E40-0x0000000180288E70
			public LayerMask layers; // 0x38
			private Vector3 offset; // 0x3C
			private Vector3 offsetTarget; // 0x48
			private Vector3 offsetV; // 0x54
	
			// Nested types
			[Serializable]
			public class EffectorLink // TypeDefIndex: 10018
			{
				// Fields
				[Tooltip] // 0x0000000180289010-0x0000000180289040
				public FullBodyBipedEffector effector; // 0x10
				[Tooltip] // 0x0000000180289160-0x0000000180289190
				public float weight; // 0x14
	
				// Constructors
				public EffectorLink(); // 0x0000000180373240-0x0000000180373250
			}
	
			// Constructors
			public Avoider(); // 0x000000018162B280-0x000000018162B2A0
	
			// Methods
			public void Solve(IKSolverFullBodyBiped solver, float weight); // 0x000000018162AE30-0x000000018162B280
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver); // 0x000000018162A8E0-0x000000018162AB30
			private Vector3 Raycast(Vector3 from, Vector3 to); // 0x000000018162AB30-0x000000018162AE30
		}
	
		// Constructors
		public PenetrationAvoidance(); // 0x0000000181381DA0-0x0000000181381DB0
	
		// Methods
		protected override void OnModifyOffset(); // 0x000000018163BA70-0x000000018163BB00
	}
}
