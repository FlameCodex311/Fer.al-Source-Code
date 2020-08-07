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
	public class HitReactionVRIK : OffsetModifierVRIK // TypeDefIndex: 9999
	{
		// Fields
		public AnimationCurve[] offsetCurves; // 0x30
		[Tooltip] // 0x000000018027B130-0x000000018027B160
		public PositionOffset[] positionOffsets; // 0x38
		[Tooltip] // 0x000000018027B200-0x000000018027B230
		public RotationOffset[] rotationOffsets; // 0x40
	
		// Nested types
		[Serializable]
		public abstract class Offset // TypeDefIndex: 10000
		{
			// Fields
			[Tooltip] // 0x000000018027B330-0x000000018027B360
			public string name; // 0x10
			[Tooltip] // 0x000000018027B470-0x000000018027B4A0
			public Collider collider; // 0x18
			[SerializeField] // 0x000000018027B670-0x000000018027B6C0
			[Tooltip] // 0x000000018027B670-0x000000018027B6C0
			private float crossFadeTime; // 0x20
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private float <crossFader>k__BackingField; // 0x24
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private float <timer>k__BackingField; // 0x28
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private Vector3 <force>k__BackingField; // 0x2C
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private Vector3 <point>k__BackingField; // 0x38
			private float length; // 0x44
			private float crossFadeSpeed; // 0x48
			private float lastTime; // 0x4C
	
			// Properties
			protected float crossFader { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018090BD10-0x000000018090BD20 0x000000018094A6A0-0x000000018094A6B0
			protected float timer { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180491DA0-0x0000000180491DB0 0x0000000180626240-0x0000000180626250
			protected Vector3 force { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018094A640-0x000000018094A660 0x000000018188D690-0x000000018188D6A0
			protected Vector3 point { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018094A680-0x000000018094A6A0 0x00000001819DE4E0-0x00000001819DE4F0
	
			// Constructors
			protected Offset(); // 0x00000001819DDC10-0x00000001819DDC20
	
			// Methods
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point); // 0x00000001819F91A0-0x00000001819F92C0
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight); // 0x00000001819F9020-0x00000001819F91A0
			protected abstract float GetLength(AnimationCurve[] curves);
			protected abstract void CrossFadeStart();
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);
		}
	
		[Serializable]
		public class PositionOffset : Offset // TypeDefIndex: 10001
		{
			// Fields
			[Tooltip] // 0x000000018027C8E0-0x000000018027C910
			public int forceDirCurveIndex; // 0x50
			[Tooltip] // 0x000000018027CB70-0x000000018027CBA0
			public int upDirCurveIndex; // 0x54
			[Tooltip] // 0x0000000180280900-0x0000000180280930
			public PositionOffsetLink[] offsetLinks; // 0x58
	
			// Nested types
			[Serializable]
			public class PositionOffsetLink // TypeDefIndex: 10002
			{
				// Fields
				[Tooltip] // 0x000000018027CE60-0x000000018027CE90
				public IKSolverVR.PositionOffset positionOffset; // 0x10
				[Tooltip] // 0x000000018027CF20-0x000000018027CF50
				public float weight; // 0x14
				private Vector3 lastValue; // 0x18
				private Vector3 current; // 0x24
	
				// Constructors
				public PositionOffsetLink(); // 0x0000000180373240-0x0000000180373250
	
				// Methods
				public void Apply(VRIK ik, Vector3 offset, float crossFader); // 0x00000001819F9AF0-0x00000001819F9C40
				public void CrossFadeStart(); // 0x00000001819DA330-0x00000001819DA350
			}
	
			// Constructors
			public PositionOffset(); // 0x00000001819FA330-0x00000001819FA350
	
			// Methods
			protected override float GetLength(AnimationCurve[] curves); // 0x00000001819F9CB0-0x00000001819F9F50
			protected override void CrossFadeStart(); // 0x00000001819F9C40-0x00000001819F9CB0
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight); // 0x00000001819F9F50-0x00000001819FA330
		}
	
		[Serializable]
		public class RotationOffset : Offset // TypeDefIndex: 10003
		{
			// Fields
			[Tooltip] // 0x000000018027D090-0x000000018027D0C0
			public int curveIndex; // 0x50
			[Tooltip] // 0x000000018027D300-0x000000018027D330
			public RotationOffsetLink[] offsetLinks; // 0x58
			private Rigidbody rigidbody; // 0x60
	
			// Nested types
			[Serializable]
			public class RotationOffsetLink // TypeDefIndex: 10004
			{
				// Fields
				[Tooltip] // 0x000000018027D580-0x000000018027D5B0
				public IKSolverVR.RotationOffset rotationOffset; // 0x10
				[Range] // 0x000000018027D7A0-0x000000018027D800
				[Tooltip] // 0x000000018027D7A0-0x000000018027D800
				public float weight; // 0x14
				private Quaternion lastValue; // 0x18
				private Quaternion current; // 0x28
	
				// Constructors
				public RotationOffsetLink(); // 0x00000001819FA4A0-0x00000001819FA520
	
				// Methods
				public void Apply(VRIK ik, Quaternion offset, float crossFader); // 0x00000001819FA350-0x00000001819FA490
				public void CrossFadeStart(); // 0x00000001819FA490-0x00000001819FA4A0
			}
	
			// Constructors
			public RotationOffset(); // 0x00000001819DDC10-0x00000001819DDC20
	
			// Methods
			protected override float GetLength(AnimationCurve[] curves); // 0x00000001819FA580-0x00000001819FA6C0
			protected override void CrossFadeStart(); // 0x00000001819FA520-0x00000001819FA580
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight); // 0x00000001819FA6C0-0x00000001819FAAF0
		}
	
		// Constructors
		public HitReactionVRIK(); // 0x0000000181365EE0-0x0000000181365EF0
	
		// Methods
		protected override void OnModifyOffset(); // 0x00000001819DE780-0x00000001819DE880
		public void Hit(Collider collider, Vector3 force, Vector3 point); // 0x00000001819DE4F0-0x00000001819DE780
	}
}
