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
	public class AimPoser : UnityEngine.MonoBehaviour // TypeDefIndex: 9453
	{
		// Fields
		public float angleBuffer; // 0x18
		public Pose[] poses; // 0x20
	
		// Nested types
		[Serializable]
		public class Pose // TypeDefIndex: 9454
		{
			// Fields
			public bool visualize; // 0x10
			public string name; // 0x18
			public Vector3 direction; // 0x20
			public float yaw; // 0x2C
			public float pitch; // 0x30
			private float angleBuffer; // 0x34
	
			// Constructors
			public Pose(); // 0x000000018183B5B0-0x000000018183B5D0
	
			// Methods
			public bool IsInDirection(Vector3 d); // 0x000000018183B250-0x000000018183B5A0
			public void SetAngleBuffer(float value); // 0x000000018183B5A0-0x000000018183B5B0
		}
	
		// Constructors
		public AimPoser(); // 0x000000018181D6E0-0x000000018181D730
	
		// Methods
		public Pose GetPose(Vector3 localDirection); // 0x000000018181D4B0-0x000000018181D620
		public void SetPoseActive(Pose pose); // 0x000000018181D620-0x000000018181D6E0
	}
}
