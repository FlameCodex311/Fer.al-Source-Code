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
	[Category] // 0x00000001800DC630-0x00000001800DC6E0
	[Description] // 0x00000001800DC630-0x00000001800DC6E0
	[EventReceiver] // 0x00000001800DC630-0x00000001800DC6E0
	public class CheckEventValue<T> : ConditionTask<GraphOwner> // TypeDefIndex: 14170
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<string> eventName;
		[Name] // 0x00000001800DCDA0-0x00000001800DCDD0
		public BBParameter<T> value;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public CheckEventValue();
	
		// Methods
		protected override bool OnCheck();
		public void OnCustomEvent(EventData receivedEvent);
	}
}
