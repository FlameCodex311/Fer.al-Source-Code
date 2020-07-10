/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FIMSpace.Basics
{
	public class FBasic_TimedExecutor : UnityEngine.MonoBehaviour // TypeDefIndex: 9899
	{
		// Fields
		[Header] // 0x00000001801065F0-0x0000000180106620
		public Vector2 RandomTimerRange; // 0x18
		public UnityEvent ToExecute; // 0x20
		private float timer; // 0x28
	
		// Constructors
		public FBasic_TimedExecutor(); // 0x00000001815DA410-0x00000001815DA460
	
		// Methods
		private void Start(); // 0x0000000180E13AF0-0x0000000180E13B20
		private void Update(); // 0x00000001815DA3B0-0x00000001815DA410
		private void ResetTimer(); // 0x0000000180E13AF0-0x0000000180E13B20
	}
}
