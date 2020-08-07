/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FIMSpace.Basics
{
	public class FBasic_HoldPosition : UnityEngine.MonoBehaviour // TypeDefIndex: 10343
	{
		// Fields
		[Tooltip] // 0x00000001801E3690-0x00000001801E36C0
		public float HoldPower; // 0x18
		public bool ResetRigidbodyVelocity; // 0x1C
		protected Vector3 initialPosition; // 0x20
		protected Rigidbody rigidbodyToHold; // 0x30
	
		// Constructors
		public FBasic_HoldPosition(); // 0x000000018107EC80-0x000000018107EC90
	
		// Methods
		protected virtual void Start(); // 0x000000018107EC90-0x000000018107ED10
		protected virtual void Update(); // 0x000000018107ED10-0x000000018107EF80
	}
}
