/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FIMSpace.FTail
{
	public class FTail_CollisionHelper : UnityEngine.MonoBehaviour // TypeDefIndex: 9866
	{
		// Fields
		public FTail_AnimatorBase ParentTail; // 0x18
		public int index; // 0x20
		private Transform previousCollision; // 0x28
	
		// Constructors
		public FTail_CollisionHelper(); // 0x0000000180407560-0x0000000180407570
	
		// Methods
		internal FTail_CollisionHelper Init(bool addRigidbody = true /* Metadata: 0x00745FEA */); // 0x0000000181B70950-0x0000000181B70A30
		private void OnCollisionEnter(Collision collision); // 0x0000000181B70A30-0x0000000181B70CB0
		private void OnCollisionExit(Collision collision); // 0x0000000181B70CB0-0x0000000181B70DA0
	}
}
