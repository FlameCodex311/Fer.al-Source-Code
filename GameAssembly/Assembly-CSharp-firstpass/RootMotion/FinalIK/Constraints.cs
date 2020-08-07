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
	[Serializable]
	public class Constraints // TypeDefIndex: 9869
	{
		// Fields
		public Transform transform; // 0x10
		public Transform target; // 0x18
		public Vector3 positionOffset; // 0x20
		public Vector3 position; // 0x2C
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float positionWeight; // 0x38
		public Vector3 rotationOffset; // 0x3C
		public Vector3 rotation; // 0x48
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float rotationWeight; // 0x54
	
		// Constructors
		public Constraints(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public bool IsValid(); // 0x0000000181426980-0x00000001814269E0
		public void Initiate(Transform transform); // 0x0000000181426910-0x0000000181426980
		public void Update(); // 0x00000001814269E0-0x0000000181426E60
	}
}
