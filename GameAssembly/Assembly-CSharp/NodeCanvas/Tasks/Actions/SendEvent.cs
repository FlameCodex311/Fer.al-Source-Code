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
	[Category] // 0x000000018010BD10-0x000000018010BD70
	[Description] // 0x000000018010BD10-0x000000018010BD70
	public class SendEvent : ActionTask<GraphOwner> // TypeDefIndex: 14339
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<string> eventName; // 0x68
		public BBParameter<float> delay; // 0x70
		public bool sendGlobal; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018125DF50-0x000000018125E1D0 
	
		// Constructors
		public SendEvent(); // 0x000000018125DF10-0x000000018125DF50
	
		// Methods
		protected override void OnUpdate(); // 0x000000018125DDE0-0x000000018125DF10
	}
}
