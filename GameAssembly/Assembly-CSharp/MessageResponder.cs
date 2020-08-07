/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ManagedBehaviourManager] // 0x00000001801F41E0-0x00000001801F4210
public class MessageResponder : ManagedBehaviour // TypeDefIndex: 11216
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<MessageTrigger> _triggers; // 0x50
	private bool _triggersSetup; // 0x58

	// Nested types
	[Serializable]
	public class MessageTriggerEvent : UnityEvent<Message> // TypeDefIndex: 11217
	{
		// Constructors
		public MessageTriggerEvent(); // 0x0000000180BFE520-0x0000000180BFE560
	}

	[Serializable]
	public class MessageTrigger // TypeDefIndex: 11218
	{
		// Fields
		public string eventID; // 0x10
		public string tag; // 0x18
		public MessageTriggerEvent callback; // 0x20
		public Action<Message> invokeAction; // 0x28

		// Constructors
		public MessageTrigger(); // 0x0000000180BFE560-0x0000000180BFE5F0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 11219
	{
		// Fields
		public MessageTrigger messageTrigger; // 0x10

		// Constructors
		public <>c__DisplayClass6_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <SetupTriggers>b__0(Message inMessage); // 0x0000000180C17470-0x0000000180C174E0
	}

	// Constructors
	public MessageResponder(); // 0x0000000180BFE4A0-0x0000000180BFE520

	// Methods
	public override void MStart(); // 0x0000000180BFE270-0x0000000180BFE290
	public override void MOnDestroy(); // 0x0000000180BFE250-0x0000000180BFE270
	public void SetupTriggers(); // 0x0000000180BFE290-0x0000000180BFE4A0
	private void DeRegisterTriggers(); // 0x0000000180BFE0E0-0x0000000180BFE250
}

