/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FIMSpace.FTail
{
	public class FTail_CollisionHelper : UnityEngine.MonoBehaviour // TypeDefIndex: 10320
	{
		// Fields
		public FTail_AnimatorBase ParentTail; // 0x18
		public int index; // 0x20
		private Transform previousCollision; // 0x28
	
		// Constructors
		public FTail_CollisionHelper(); // 0x0000000180568C50-0x0000000180569020
	
		// Methods
		internal FTail_CollisionHelper Init(bool addRigidbody = true /* Metadata: 0x0077BA9C */); // 0x0000000181744800-0x00000001817448E0
		private void OnCollisionEnter(Collision collision); // 0x00000001817448E0-0x0000000181744B50
		private void OnCollisionExit(Collision collision); // 0x0000000181744B50-0x0000000181744C40
	}
}
