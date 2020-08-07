/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.Demos
{
	public class UserControlAI : UserControlThirdPerson // TypeDefIndex: 9855
	{
		// Fields
		public Transform moveTarget; // 0x48
		public float stoppingDistance; // 0x50
		public float stoppingThreshold; // 0x54
		public Navigator navigator; // 0x58
	
		// Constructors
		public UserControlAI(); // 0x0000000181440700-0x0000000181440720
	
		// Methods
		protected override void Start(); // 0x0000000181440330-0x0000000181440390
		protected override void Update(); // 0x0000000181440390-0x0000000181440700
		private void OnDrawGizmos(); // 0x00000001814402F0-0x0000000181440330
	}
}
