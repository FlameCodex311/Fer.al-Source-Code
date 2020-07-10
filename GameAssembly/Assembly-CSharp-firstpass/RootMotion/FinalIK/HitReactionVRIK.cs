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
	public class HitReactionVRIK : OffsetModifierVRIK // TypeDefIndex: 9465
	{
		// Fields
		public AnimationCurve[] offsetCurves; // 0x30
		[Tooltip] // 0x00000001800B83C0-0x00000001800B83F0
		public PositionOffset[] positionOffsets; // 0x38
		[Tooltip] // 0x00000001800B86C0-0x00000001800B86F0
		public RotationOffset[] rotationOffsets; // 0x40
	
		// Nested types
		[Serializable]
		public abstract class Offset // TypeDefIndex: 9466
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
			protected float crossFader { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804935B0-0x00000001804935C0 0x00000001811F74C0-0x00000001811F74D0
			protected float timer { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180487D50-0x0000000180487D60 0x00000001805D90B0-0x00000001805D90C0
			protected Vector3 force { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001811F7460-0x00000001811F7480 0x0000000181C23C00-0x0000000181C23C10
			protected Vector3 point { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001811F74A0-0x00000001811F74C0 0x0000000181C23C10-0x0000000181C23C20
	
			// Constructors
			protected Offset(); // 0x0000000181C23310-0x0000000181C23320
	
			// Methods
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point); // 0x0000000181C34C20-0x0000000181C34D40
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight); // 0x0000000181C34AA0-0x0000000181C34C20
			protected abstract float GetLength(AnimationCurve[] curves);
			protected abstract void CrossFadeStart();
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);
		}
	
		[Serializable]
		public class PositionOffset : Offset // TypeDefIndex: 9467
		{
			// Fields
			[Tooltip] // 0x00000001800BB100-0x00000001800BB130
			public int forceDirCurveIndex; // 0x50
			[Tooltip] // 0x00000001800BB4A0-0x00000001800BB4D0
			public int upDirCurveIndex; // 0x54
			[Tooltip] // 0x00000001800C0350-0x00000001800C0380
			public PositionOffsetLink[] offsetLinks; // 0x58
	
			// Nested types
			[Serializable]
			public class PositionOffsetLink // TypeDefIndex: 9468
			{
				// Fields
				[Tooltip] // 0x00000001800BB670-0x00000001800BB6A0
				public IKSolverVR.PositionOffset positionOffset; // 0x10
				[Tooltip] // 0x00000001800BB790-0x00000001800BB7C0
				public float weight; // 0x14
				private Vector3 lastValue; // 0x18
				private Vector3 current; // 0x24
	
				// Constructors
				public PositionOffsetLink(); // 0x000000018036B6C0-0x000000018036B6D0
	
				// Methods
				public void Apply(VRIK ik, Vector3 offset, float crossFader); // 0x0000000181C355E0-0x0000000181C35730
				public void CrossFadeStart(); // 0x0000000181C14850-0x0000000181C14870
			}
	
			// Constructors
			public PositionOffset(); // 0x0000000181C35E60-0x0000000181C35E80
	
			// Methods
			protected override float GetLength(AnimationCurve[] curves); // 0x0000000181C357A0-0x0000000181C35A70
			protected override void CrossFadeStart(); // 0x0000000181C35730-0x0000000181C357A0
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight); // 0x0000000181C35A70-0x0000000181C35E60
		}
	
		[Serializable]
		public class RotationOffset : Offset // TypeDefIndex: 9469
		{
			// Fields
			[Tooltip] // 0x00000001800BCB80-0x00000001800BCBB0
			public int curveIndex; // 0x50
			[Tooltip] // 0x00000001800BCD60-0x00000001800BCD90
			public RotationOffsetLink[] offsetLinks; // 0x58
			private Rigidbody rigidbody; // 0x60
	
			// Nested types
			[Serializable]
			public class RotationOffsetLink // TypeDefIndex: 9470
			{
				// Fields
				[Tooltip] // 0x00000001800BCFF0-0x00000001800BD020
				public IKSolverVR.RotationOffset rotationOffset; // 0x10
				[Range] // 0x00000001800BD100-0x00000001800BD160
				[Tooltip] // 0x00000001800BD100-0x00000001800BD160
				public float weight; // 0x14
				private Quaternion lastValue; // 0x18
				private Quaternion current; // 0x28
	
				// Constructors
				public RotationOffsetLink(); // 0x0000000181C35FD0-0x0000000181C36050
	
				// Methods
				public void Apply(VRIK ik, Quaternion offset, float crossFader); // 0x0000000181C35E80-0x0000000181C35FC0
				public void CrossFadeStart(); // 0x0000000181C35FC0-0x0000000181C35FD0
			}
	
			// Constructors
			public RotationOffset(); // 0x0000000181C23310-0x0000000181C23320
	
			// Methods
			protected override float GetLength(AnimationCurve[] curves); // 0x0000000181C360B0-0x0000000181C36210
			protected override void CrossFadeStart(); // 0x0000000181C36050-0x0000000181C360B0
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight); // 0x0000000181C36210-0x0000000181C36650
		}
	
		// Constructors
		public HitReactionVRIK(); // 0x0000000181638E90-0x0000000181638EA0
	
		// Methods
		protected override void OnModifyOffset(); // 0x0000000181C23EC0-0x0000000181C23FC0
		public void Hit(Collider collider, Vector3 force, Vector3 point); // 0x0000000181C23C20-0x0000000181C23EC0
	}
}
