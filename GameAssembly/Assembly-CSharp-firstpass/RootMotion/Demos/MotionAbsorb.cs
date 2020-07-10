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
	public class MotionAbsorb : OffsetModifier // TypeDefIndex: 9528
	{
		// Fields
		[Tooltip] // 0x00000001800D94B0-0x00000001800D94E0
		public Mode mode; // 0x30
		[Tooltip] // 0x00000001800D9690-0x00000001800D96C0
		public Absorber[] absorbers; // 0x38
		[Tooltip] // 0x00000001800D9990-0x00000001800D99C0
		public AnimationCurve falloff; // 0x40
		[Tooltip] // 0x00000001800D9BC0-0x00000001800D9BF0
		public float falloffSpeed; // 0x48
		private float timer; // 0x4C
		private float w; // 0x50
		private Mode initialMode; // 0x54
	
		// Nested types
		[Serializable]
		public enum Mode // TypeDefIndex: 9529
		{
			Position = 0,
			PositionOffset = 1
		}
	
		[Serializable]
		public class Absorber // TypeDefIndex: 9530
		{
			// Fields
			[Tooltip] // 0x00000001800D9DD0-0x00000001800D9E00
			public FullBodyBipedEffector effector; // 0x10
			[Tooltip] // 0x00000001800DA090-0x00000001800DA0C0
			public float weight; // 0x14
			private Vector3 position; // 0x18
			private Quaternion rotation; // 0x24
			private IKEffector e; // 0x38
	
			// Constructors
			public Absorber(); // 0x000000018181BBE0-0x000000018181BC50
	
			// Methods
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode); // 0x000000018181BA00-0x000000018181BB90
			public void UpdateEffectorWeights(float w); // 0x000000018181BB90-0x000000018181BBE0
			public void SetPosition(float w); // 0x000000018181B6F0-0x000000018181B8C0
			public void SetRotation(float w); // 0x000000018181B8C0-0x000000018181BA00
		}
	
		// Constructors
		public MotionAbsorb(); // 0x00000001818366A0-0x00000001818366B0
	
		// Methods
		protected override void Start(); // 0x00000001818365C0-0x00000001818366A0
		private void OnCollisionEnter(Collision c); // 0x0000000181836010-0x00000001818360D0
		protected override void OnModifyOffset(); // 0x00000001818361E0-0x00000001818365C0
		private void AfterIK(); // 0x0000000181835E10-0x0000000181836010
		protected override void OnDestroy(); // 0x00000001818360D0-0x00000001818361E0
	}
}
