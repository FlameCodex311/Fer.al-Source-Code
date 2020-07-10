/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018010C0B0-0x000000018010C110
	[Description] // 0x000000018010C0B0-0x000000018010C110
	public class SendEvent<T> : ActionTask<GraphOwner> // TypeDefIndex: 14340
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<string> eventName;
		public BBParameter<T> eventValue;
		public BBParameter<float> delay;
		public bool sendGlobal;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public SendEvent();
	
		// Methods
		protected override void OnUpdate();
	}
}
