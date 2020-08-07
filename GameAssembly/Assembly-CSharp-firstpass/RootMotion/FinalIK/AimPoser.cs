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
	public class AimPoser : UnityEngine.MonoBehaviour // TypeDefIndex: 9987
	{
		// Fields
		public float angleBuffer; // 0x18
		public Pose[] poses; // 0x20
	
		// Nested types
		[Serializable]
		public class Pose // TypeDefIndex: 9988
		{
			// Fields
			public bool visualize; // 0x10
			public string name; // 0x18
			public Vector3 direction; // 0x20
			public float yaw; // 0x2C
			public float pitch; // 0x30
			private float angleBuffer; // 0x34
	
			// Constructors
			public Pose(); // 0x000000018143E780-0x000000018143E7A0
	
			// Methods
			public bool IsInDirection(Vector3 d); // 0x000000018143E420-0x000000018143E770
			public void SetAngleBuffer(float value); // 0x000000018143E770-0x000000018143E780
		}
	
		// Constructors
		public AimPoser(); // 0x0000000181422EB0-0x0000000181422F00
	
		// Methods
		public Pose GetPose(Vector3 localDirection); // 0x0000000181422CA0-0x0000000181422E00
		public void SetPoseActive(Pose pose); // 0x0000000181422E00-0x0000000181422EB0
	}
}
