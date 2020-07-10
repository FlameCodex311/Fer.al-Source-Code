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
	[Serializable]
	public class Constraints // TypeDefIndex: 9335
	{
		// Fields
		public Transform transform; // 0x10
		public Transform target; // 0x18
		public Vector3 positionOffset; // 0x20
		public Vector3 position; // 0x2C
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float positionWeight; // 0x38
		public Vector3 rotationOffset; // 0x3C
		public Vector3 rotation; // 0x48
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float rotationWeight; // 0x54
	
		// Constructors
		public Constraints(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public bool IsValid(); // 0x0000000181820A50-0x0000000181820AB0
		public void Initiate(Transform transform); // 0x00000001818209E0-0x0000000181820A50
		public void Update(); // 0x0000000181820AB0-0x0000000181820F40
	}
}
