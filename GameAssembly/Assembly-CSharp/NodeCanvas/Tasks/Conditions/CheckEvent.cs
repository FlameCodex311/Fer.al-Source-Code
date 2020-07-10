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
	[Category] // 0x00000001800DB670-0x00000001800DB720
	[Description] // 0x00000001800DB670-0x00000001800DB720
	[EventReceiver] // 0x00000001800DB670-0x00000001800DB720
	public class CheckEvent : ConditionTask<GraphOwner> // TypeDefIndex: 14168
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<string> eventName; // 0x68
	
		// Properties
		protected override string info { get; } // 0x0000000181250420-0x0000000181250490 
	
		// Constructors
		public CheckEvent(); // 0x00000001812503E0-0x0000000181250420
	
		// Methods
		protected override bool OnCheck(); // 0x00000001803C28F0-0x00000001803C2900
		public void OnCustomEvent(EventData receivedEvent); // 0x0000000181250320-0x00000001812503E0
	}
}
