/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FIMSpace.Basics
{
	public class FBasic_TimedExecutor : UnityEngine.MonoBehaviour // TypeDefIndex: 10353
	{
		// Fields
		[Header] // 0x00000001801E7700-0x00000001801E7730
		public Vector2 RandomTimerRange; // 0x18
		public UnityEvent ToExecute; // 0x20
		private float timer; // 0x28
	
		// Constructors
		public FBasic_TimedExecutor(); // 0x00000001817299C0-0x0000000181729A10
	
		// Methods
		private void Start(); // 0x0000000180745930-0x0000000180745960
		private void Update(); // 0x0000000181729960-0x00000001817299C0
		private void ResetTimer(); // 0x0000000180745930-0x0000000180745960
	}
}
