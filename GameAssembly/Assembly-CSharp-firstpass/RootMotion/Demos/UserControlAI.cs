/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.Demos
{
	public class UserControlAI : UserControlThirdPerson // TypeDefIndex: 9568
	{
		// Fields
		public Transform moveTarget; // 0x48
		public float stoppingDistance; // 0x50
		public float stoppingThreshold; // 0x54
		public Navigator navigator; // 0x58
	
		// Constructors
		public UserControlAI(); // 0x000000018183F9D0-0x000000018183F9F0
	
		// Methods
		protected override void Start(); // 0x000000018183F550-0x000000018183F650
		protected override void Update(); // 0x000000018183F650-0x000000018183F9D0
		private void OnDrawGizmos(); // 0x000000018183F510-0x000000018183F550
	}
}
