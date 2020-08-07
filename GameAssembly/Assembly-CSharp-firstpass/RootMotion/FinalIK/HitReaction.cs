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
	public class HitReaction : OffsetModifier // TypeDefIndex: 9993
	{
		// Fields
		[Tooltip] // 0x000000018027B130-0x000000018027B160
		public HitPointEffector[] effectorHitPoints; // 0x30
		[Tooltip] // 0x000000018027B200-0x000000018027B230
		public HitPointBone[] boneHitPoints; // 0x38
	
		// Properties
		public bool inProgress { get; } // 0x00000001819DEC30-0x00000001819DED00 
	
		// Nested types
		[Serializable]
		public abstract class HitPoint // TypeDefIndex: 9994
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
			public bool inProgress { get; } // 0x00000001819DE4D0-0x00000001819DE4E0 
			protected float crossFader { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018090BD10-0x000000018090BD20 0x000000018094A6A0-0x000000018094A6B0
			protected float timer { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180491DA0-0x0000000180491DB0 0x0000000180626240-0x0000000180626250
			protected Vector3 force { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018094A640-0x000000018094A660 0x000000018188D690-0x000000018188D6A0
			protected Vector3 point { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018094A680-0x000000018094A6A0 0x00000001819DE4E0-0x00000001819DE4F0
	
			// Constructors
			protected HitPoint(); // 0x00000001819DDC10-0x00000001819DDC20
	
			// Methods
			public void Hit(Vector3 force, Vector3 point); // 0x00000001819DE3C0-0x00000001819DE4D0
			public void Apply(IKSolverFullBodyBiped solver, float weight); // 0x00000001819DE260-0x00000001819DE3C0
			protected abstract float GetLength();
			protected abstract void CrossFadeStart();
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);
		}
	
		[Serializable]
		public class HitPointEffector : HitPoint // TypeDefIndex: 9995
		{
			// Fields
			[Tooltip] // 0x000000018027C8E0-0x000000018027C910
			public AnimationCurve offsetInForceDirection; // 0x50
			[Tooltip] // 0x000000018027CB70-0x000000018027CBA0
			public AnimationCurve offsetInUpDirection; // 0x58
			[Tooltip] // 0x000000018027CC20-0x000000018027CC50
			public EffectorLink[] effectorLinks; // 0x60
	
			// Nested types
			[Serializable]
			public class EffectorLink // TypeDefIndex: 9996
			{
				// Fields
				[Tooltip] // 0x000000018027CE60-0x000000018027CE90
				public FullBodyBipedEffector effector; // 0x10
				[Tooltip] // 0x000000018027CF20-0x000000018027CF50
				public float weight; // 0x14
				private Vector3 lastValue; // 0x18
				private Vector3 current; // 0x24
	
				// Constructors
				public EffectorLink(); // 0x0000000180373240-0x0000000180373250
	
				// Methods
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader); // 0x00000001819DA1A0-0x00000001819DA330
				public void CrossFadeStart(); // 0x00000001819DA330-0x00000001819DA350
			}
	
			// Constructors
			public HitPointEffector(); // 0x00000001819DDC10-0x00000001819DDC20
	
			// Methods
			protected override float GetLength(); // 0x00000001819DDC90-0x00000001819DDE60
			protected override void CrossFadeStart(); // 0x00000001819DDC20-0x00000001819DDC90
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight); // 0x00000001819DDE60-0x00000001819DE260
		}
	
		[Serializable]
		public class HitPointBone : HitPoint // TypeDefIndex: 9997
		{
			// Fields
			[Tooltip] // 0x000000018027D090-0x000000018027D0C0
			public AnimationCurve aroundCenterOfMass; // 0x50
			[Tooltip] // 0x000000018027D300-0x000000018027D330
			public BoneLink[] boneLinks; // 0x58
			private Rigidbody rigidbody; // 0x60
	
			// Nested types
			[Serializable]
			public class BoneLink // TypeDefIndex: 9998
			{
				// Fields
				[Tooltip] // 0x000000018027D580-0x000000018027D5B0
				public Transform bone; // 0x10
				[Range] // 0x000000018027D7A0-0x000000018027D800
				[Tooltip] // 0x000000018027D7A0-0x000000018027D800
				public float weight; // 0x18
				private Quaternion lastValue; // 0x1C
				private Quaternion current; // 0x2C
	
				// Constructors
				public BoneLink(); // 0x00000001819D7520-0x00000001819D75A0
	
				// Methods
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader); // 0x00000001819D73B0-0x00000001819D7510
				public void CrossFadeStart(); // 0x00000001819D7510-0x00000001819D7520
			}
	
			// Constructors
			public HitPointBone(); // 0x00000001819DDC10-0x00000001819DDC20
	
			// Methods
			protected override float GetLength(); // 0x00000001819DD790-0x00000001819DD850
			protected override void CrossFadeStart(); // 0x00000001819DD730-0x00000001819DD790
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight); // 0x00000001819DD850-0x00000001819DDC10
		}
	
		// Constructors
		public HitReaction(); // 0x0000000181365EE0-0x0000000181365EF0
	
		// Methods
		protected override void OnModifyOffset(); // 0x00000001819DEB10-0x00000001819DEC30
		public void Hit(Collider collider, Vector3 force, Vector3 point); // 0x00000001819DE880-0x00000001819DEB10
	}
}
