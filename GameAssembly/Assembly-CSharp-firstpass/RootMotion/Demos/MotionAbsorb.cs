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
	public class MotionAbsorb : OffsetModifier // TypeDefIndex: 9815
	{
		// Fields
		[Tooltip] // 0x0000000180212F10-0x0000000180212F40
		public Mode mode; // 0x30
		[Tooltip] // 0x00000001802130D0-0x0000000180213100
		public Absorber[] absorbers; // 0x38
		[Tooltip] // 0x00000001802132C0-0x00000001802132F0
		public AnimationCurve falloff; // 0x40
		[Tooltip] // 0x00000001802135D0-0x0000000180213600
		public float falloffSpeed; // 0x48
		private float timer; // 0x4C
		private float w; // 0x50
		private Mode initialMode; // 0x54
	
		// Nested types
		[Serializable]
		public enum Mode // TypeDefIndex: 9816
		{
			Position = 0,
			PositionOffset = 1
		}
	
		[Serializable]
		public class Absorber // TypeDefIndex: 9817
		{
			// Fields
			[Tooltip] // 0x0000000180213810-0x0000000180213840
			public FullBodyBipedEffector effector; // 0x10
			[Tooltip] // 0x0000000180213B20-0x0000000180213B50
			public float weight; // 0x14
			private Vector3 position; // 0x18
			private Quaternion rotation; // 0x24
			private IKEffector e; // 0x38
	
			// Constructors
			public Absorber(); // 0x00000001813651F0-0x0000000181365260
	
			// Methods
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode); // 0x0000000181365040-0x00000001813651B0
			public void UpdateEffectorWeights(float w); // 0x00000001813651B0-0x00000001813651F0
			public void SetPosition(float w); // 0x0000000181364D30-0x0000000181364F00
			public void SetRotation(float w); // 0x0000000181364F00-0x0000000181365040
		}
	
		// Constructors
		public MotionAbsorb(); // 0x000000018137D140-0x000000018137D150
	
		// Methods
		protected override void Start(); // 0x000000018137D060-0x000000018137D140
		private void OnCollisionEnter(Collision c); // 0x000000018137C970-0x000000018137CB90
		protected override void OnModifyOffset(); // 0x000000018137CC90-0x000000018137D060
		private void AfterIK(); // 0x000000018137C780-0x000000018137C970
		protected override void OnDestroy(); // 0x000000018137CB90-0x000000018137CC90
	}
}
