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
	public class Turret : UnityEngine.MonoBehaviour // TypeDefIndex: 9840
	{
		// Fields
		public Transform target; // 0x18
		public Part[] parts; // 0x20
	
		// Nested types
		[Serializable]
		public class Part // TypeDefIndex: 9841
		{
			// Fields
			public Transform transform; // 0x10
			private RotationLimit rotationLimit; // 0x18
	
			// Constructors
			public Part(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			public void AimAt(Transform target); // 0x000000018143E2C0-0x000000018143E420
		}
	
		// Constructors
		public Turret(); // 0x0000000180568C50-0x0000000180569020
	
		// Methods
		private void Update(); // 0x000000018143F560-0x000000018143F740
	}
}
