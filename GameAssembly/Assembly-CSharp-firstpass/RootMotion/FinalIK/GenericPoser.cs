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
	public class GenericPoser : Poser // TypeDefIndex: 9436
	{
		// Fields
		public Map[] maps; // 0x50
	
		// Nested types
		[Serializable]
		public class Map // TypeDefIndex: 9437
		{
			// Fields
			public Transform bone; // 0x10
			public Transform target; // 0x18
			private Vector3 defaultLocalPosition; // 0x20
			private Quaternion defaultLocalRotation; // 0x2C
	
			// Constructors
			public Map(Transform bone, Transform target); // 0x0000000181C34890-0x0000000181C34920
	
			// Methods
			public void StoreDefaultState(); // 0x0000000181C12460-0x0000000181C124D0
			public void FixTransform(); // 0x0000000181C34600-0x0000000181C34670
			public void Update(float localRotationWeight, float localPositionWeight); // 0x0000000181C34670-0x0000000181C34890
		}
	
		// Constructors
		public GenericPoser(); // 0x0000000181C175C0-0x0000000181C175D0
	
		// Methods
		[ContextMenu] // 0x000000018016C410-0x000000018016C440
		public override void AutoMapping(); // 0x0000000181C16EA0-0x0000000181C171F0
		protected override void InitiatePoser(); // 0x0000000181C173A0-0x0000000181C173B0
		protected override void UpdatePoser(); // 0x0000000181C174A0-0x0000000181C175C0
		protected override void FixPoserTransforms(); // 0x0000000181C171F0-0x0000000181C172E0
		private void StoreDefaultState(); // 0x0000000181C173B0-0x0000000181C174A0
		private Transform GetTargetNamed(string tName, Transform[] array); // 0x0000000181C172E0-0x0000000181C173A0
	}
}
