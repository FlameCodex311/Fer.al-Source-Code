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
	public class FBasic_TriggerEvents : UnityEngine.MonoBehaviour // TypeDefIndex: 10370
	{
		// Fields
		public string EnteringTag; // 0x18
		public UnityEvent OnAwakeEvent; // 0x20
		public UnityEvent OnStartEvent; // 0x28
		public UnityEvent OnTriggerEnterEvents; // 0x30
		public UnityEvent OnTriggerExitEvents; // 0x38
	
		// Constructors
		public FBasic_TriggerEvents(); // 0x0000000181729D60-0x0000000181729DA0
	
		// Methods
		private void Awake(); // 0x0000000181729C40-0x0000000181729C60
		private void Start(); // 0x0000000181729D40-0x0000000181729D60
		private void OnTriggerEnter(Collider other); // 0x0000000181729C60-0x0000000181729CD0
		private void OnTriggerExit(Collider other); // 0x0000000181729CD0-0x0000000181729D40
	}
}
