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
	public class Turret : UnityEngine.MonoBehaviour // TypeDefIndex: 9553
	{
		// Fields
		public Transform target; // 0x18
		public Part[] parts; // 0x20
	
		// Nested types
		[Serializable]
		public class Part // TypeDefIndex: 9554
		{
			// Fields
			public Transform transform; // 0x10
			private RotationLimit rotationLimit; // 0x18
	
			// Constructors
			public Part(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			public void AimAt(Transform target); // 0x00000001818379D0-0x0000000181837B30
		}
	
		// Constructors
		public Turret(); // 0x0000000180407560-0x0000000180407570
	
		// Methods
		private void Update(); // 0x000000018183DD10-0x000000018183DF00
	}
}
