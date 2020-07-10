/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001800DBD60-0x00000001800DBE10
	[Description] // 0x00000001800DBD60-0x00000001800DBE10
	[EventReceiver] // 0x00000001800DBD60-0x00000001800DBE10
	public class CheckEvent<T> : ConditionTask<GraphOwner> // TypeDefIndex: 14169
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<string> eventName;
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<T> saveEventValue;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public CheckEvent();
	
		// Methods
		protected override bool OnCheck();
		public void OnCustomEvent(EventData receivedEvent);
	}
}
