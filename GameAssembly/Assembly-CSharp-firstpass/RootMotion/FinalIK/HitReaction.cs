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
	public class HitReaction : OffsetModifier // TypeDefIndex: 9459
	{
		// Fields
		[Tooltip] // 0x00000001800B83C0-0x00000001800B83F0
		public HitPointEffector[] effectorHitPoints; // 0x30
		[Tooltip] // 0x00000001800B86C0-0x00000001800B86F0
		public HitPointBone[] boneHitPoints; // 0x38
	
		// Properties
		public bool inProgress { get; } // 0x0000000181C24370-0x0000000181C24440 
	
		// Nested types
		[Serializable]
		public abstract class HitPoint // TypeDefIndex: 9460
		{
			// Fields
			[Tooltip] // 0x00000001800B8920-0x00000001800B8950
			public string name; // 0x10
			[Tooltip] // 0x00000001800B8AD0-0x00000001800B8B00
			public Collider collider; // 0x18
			[SerializeField] // 0x00000001800B8C80-0x00000001800B8CD0
			[Tooltip] // 0x00000001800B8C80-0x00000001800B8CD0
			private float crossFadeTime; // 0x20
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private float <crossFader>k__BackingField; // 0x24
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private float <timer>k__BackingField; // 0x28
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private Vector3 <force>k__BackingField; // 0x2C
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private Vector3 <point>k__BackingField; // 0x38
			private float length; // 0x44
			private float crossFadeSpeed; // 0x48
			private float lastTime; // 0x4C
	
			// Properties
			public bool inProgress { get; } // 0x0000000181C23BF0-0x0000000181C23C00 
			protected float crossFader { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804935B0-0x00000001804935C0 0x00000001811F74C0-0x00000001811F74D0
			protected float timer { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180487D50-0x0000000180487D60 0x00000001805D90B0-0x00000001805D90C0
			protected Vector3 force { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001811F7460-0x00000001811F7480 0x0000000181C23C00-0x0000000181C23C10
			protected Vector3 point { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001811F74A0-0x00000001811F74C0 0x0000000181C23C10-0x0000000181C23C20
	
			// Constructors
			protected HitPoint(); // 0x0000000181C23310-0x0000000181C23320
	
			// Methods
			public void Hit(Vector3 force, Vector3 point); // 0x0000000181C23AE0-0x0000000181C23BF0
			public void Apply(IKSolverFullBodyBiped solver, float weight); // 0x0000000181C23980-0x0000000181C23AE0
			protected abstract float GetLength();
			protected abstract void CrossFadeStart();
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);
		}
	
		[Serializable]
		public class HitPointEffector : HitPoint // TypeDefIndex: 9461
		{
			// Fields
			[Tooltip] // 0x00000001800BB100-0x00000001800BB130
			public AnimationCurve offsetInForceDirection; // 0x50
			[Tooltip] // 0x00000001800BB4A0-0x00000001800BB4D0
			public AnimationCurve offsetInUpDirection; // 0x58
			[Tooltip] // 0x00000001800BB560-0x00000001800BB590
			public EffectorLink[] effectorLinks; // 0x60
	
			// Nested types
			[Serializable]
			public class EffectorLink // TypeDefIndex: 9462
			{
				// Fields
				[Tooltip] // 0x00000001800BB670-0x00000001800BB6A0
				public FullBodyBipedEffector effector; // 0x10
				[Tooltip] // 0x00000001800BB790-0x00000001800BB7C0
				public float weight; // 0x14
				private Vector3 lastValue; // 0x18
				private Vector3 current; // 0x24
	
				// Constructors
				public EffectorLink(); // 0x000000018036B6C0-0x000000018036B6D0
	
				// Methods
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader); // 0x0000000181C146C0-0x0000000181C14850
				public void CrossFadeStart(); // 0x0000000181C14850-0x0000000181C14870
			}
	
			// Constructors
			public HitPointEffector(); // 0x0000000181C23310-0x0000000181C23320
	
			// Methods
			protected override float GetLength(); // 0x0000000181C23390-0x0000000181C23570
			protected override void CrossFadeStart(); // 0x0000000181C23320-0x0000000181C23390
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight); // 0x0000000181C23570-0x0000000181C23980
		}
	
		[Serializable]
		public class HitPointBone : HitPoint // TypeDefIndex: 9463
		{
			// Fields
			[Tooltip] // 0x00000001800BCB80-0x00000001800BCBB0
			public AnimationCurve aroundCenterOfMass; // 0x50
			[Tooltip] // 0x00000001800BCD60-0x00000001800BCD90
			public BoneLink[] boneLinks; // 0x58
			private Rigidbody rigidbody; // 0x60
	
			// Nested types
			[Serializable]
			public class BoneLink // TypeDefIndex: 9464
			{
				// Fields
				[Tooltip] // 0x00000001800BCFF0-0x00000001800BD020
				public Transform bone; // 0x10
				[Range] // 0x00000001800BD100-0x00000001800BD160
				[Tooltip] // 0x00000001800BD100-0x00000001800BD160
				public float weight; // 0x18
				private Quaternion lastValue; // 0x1C
				private Quaternion current; // 0x2C
	
				// Constructors
				public BoneLink(); // 0x0000000181C112C0-0x0000000181C11340
	
				// Methods
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader); // 0x0000000181C11140-0x0000000181C112B0
				public void CrossFadeStart(); // 0x0000000181C112B0-0x0000000181C112C0
			}
	
			// Constructors
			public HitPointBone(); // 0x0000000181C23310-0x0000000181C23320
	
			// Methods
			protected override float GetLength(); // 0x0000000181C22E80-0x0000000181C22F40
			protected override void CrossFadeStart(); // 0x0000000181C22E20-0x0000000181C22E80
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight); // 0x0000000181C22F40-0x0000000181C23310
		}
	
		// Constructors
		public HitReaction(); // 0x0000000181638E90-0x0000000181638EA0
	
		// Methods
		protected override void OnModifyOffset(); // 0x0000000181C24250-0x0000000181C24370
		public void Hit(Collider collider, Vector3 force, Vector3 point); // 0x0000000181C23FC0-0x0000000181C24250
	}
}
