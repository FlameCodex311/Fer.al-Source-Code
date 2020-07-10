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
	public class FBasic_TriggerEvents : UnityEngine.MonoBehaviour // TypeDefIndex: 9916
	{
		// Fields
		public string EnteringTag; // 0x18
		public UnityEvent OnAwakeEvent; // 0x20
		public UnityEvent OnStartEvent; // 0x28
		public UnityEvent OnTriggerEnterEvents; // 0x30
		public UnityEvent OnTriggerExitEvents; // 0x38
	
		// Constructors
		public FBasic_TriggerEvents(); // 0x00000001815DA7B0-0x00000001815DA7F0
	
		// Methods
		private void Awake(); // 0x00000001815DA690-0x00000001815DA6B0
		private void Start(); // 0x00000001815DA790-0x00000001815DA7B0
		private void OnTriggerEnter(Collider other); // 0x00000001815DA6B0-0x00000001815DA720
		private void OnTriggerExit(Collider other); // 0x00000001815DA720-0x00000001815DA790
	}
}
