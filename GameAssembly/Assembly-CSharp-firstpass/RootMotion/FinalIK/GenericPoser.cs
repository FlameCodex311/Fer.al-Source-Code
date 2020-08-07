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
	public class GenericPoser : Poser // TypeDefIndex: 9970
	{
		// Fields
		public Map[] maps; // 0x50
	
		// Nested types
		[Serializable]
		public class Map // TypeDefIndex: 9971
		{
			// Fields
			public Transform bone; // 0x10
			public Transform target; // 0x18
			private Vector3 defaultLocalPosition; // 0x20
			private Quaternion defaultLocalRotation; // 0x2C
	
			// Constructors
			public Map(Transform bone, Transform target); // 0x000000018143E230-0x000000018143E2C0
	
			// Methods
			public void StoreDefaultState(); // 0x000000018143DFB0-0x000000018143E010
			public void FixTransform(); // 0x000000018143DF40-0x000000018143DFB0
			public void Update(float localRotationWeight, float localPositionWeight); // 0x000000018143E010-0x000000018143E230
		}
	
		// Constructors
		public GenericPoser(); // 0x00000001814359F0-0x0000000181435A00
	
		// Methods
		[ContextMenu] // 0x000000018026B470-0x000000018026B4A0
		public override void AutoMapping(); // 0x0000000181435300-0x0000000181435630
		protected override void InitiatePoser(); // 0x00000001814357E0-0x00000001814357F0
		protected override void UpdatePoser(); // 0x00000001814358D0-0x00000001814359F0
		protected override void FixPoserTransforms(); // 0x0000000181435630-0x0000000181435720
		private void StoreDefaultState(); // 0x00000001814357F0-0x00000001814358D0
		private Transform GetTargetNamed(string tName, Transform[] array); // 0x0000000181435720-0x00000001814357E0
	}
}
