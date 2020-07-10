/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ManagedBehaviourManager] // 0x00000001800C2900-0x00000001800C2930
public class MessageResponder : ManagedBehaviour // TypeDefIndex: 13545
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<MessageTrigger> _triggers; // 0x50
	private bool _triggersSetup; // 0x58

	// Nested types
	[Serializable]
	public class MessageTriggerEvent : UnityEvent<Message> // TypeDefIndex: 13546
	{
		// Constructors
		public MessageTriggerEvent(); // 0x00000001810AF170-0x00000001810AF1B0
	}

	[Serializable]
	public class MessageTrigger // TypeDefIndex: 13547
	{
		// Fields
		public string eventID; // 0x10
		public string tag; // 0x18
		public MessageTriggerEvent callback; // 0x20
		public Action<Message> invokeAction; // 0x28

		// Constructors
		public MessageTrigger(); // 0x00000001810AF1B0-0x00000001810AF240
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 13548
	{
		// Fields
		public MessageTrigger messageTrigger; // 0x10

		// Constructors
		public <>c__DisplayClass6_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <SetupTriggers>b__0(Message inMessage); // 0x00000001810BD820-0x00000001810BD890
	}

	// Constructors
	public MessageResponder(); // 0x00000001810AF0F0-0x00000001810AF170

	// Methods
	public override void MStart(); // 0x00000001810AEEB0-0x00000001810AEED0
	public override void MOnDestroy(); // 0x00000001810AEE90-0x00000001810AEEB0
	public void SetupTriggers(); // 0x00000001810AEED0-0x00000001810AF0F0
	private void DeRegisterTriggers(); // 0x00000001810AED10-0x00000001810AEE90
}

