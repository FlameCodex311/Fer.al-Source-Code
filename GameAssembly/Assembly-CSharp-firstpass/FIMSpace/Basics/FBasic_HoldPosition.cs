/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FIMSpace.Basics
{
	public class FBasic_HoldPosition : UnityEngine.MonoBehaviour // TypeDefIndex: 9889
	{
		// Fields
		[Tooltip] // 0x0000000180104380-0x00000001801043B0
		public float HoldPower; // 0x18
		public bool ResetRigidbodyVelocity; // 0x1C
		protected Vector3 initialPosition; // 0x20
		protected Rigidbody rigidbodyToHold; // 0x30
	
		// Constructors
		public FBasic_HoldPosition(); // 0x00000001815D5000-0x00000001815D5010
	
		// Methods
		protected virtual void Start(); // 0x00000001815D5010-0x00000001815D5090
		protected virtual void Update(); // 0x00000001815D5090-0x00000001815D5310
	}
}
