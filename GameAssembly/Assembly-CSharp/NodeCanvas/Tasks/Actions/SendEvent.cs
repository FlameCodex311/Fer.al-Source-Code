/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180277050-0x00000001802770B0
	[Description] // 0x0000000180277050-0x00000001802770B0
	public class SendEvent : ActionTask<GraphOwner> // TypeDefIndex: 15442
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<string> eventName; // 0x68
		public BBParameter<float> delay; // 0x70
		public bool sendGlobal; // 0x78
	
		// Properties
		protected override string info { get; } // 0x00000001807A2A90-0x00000001807A2CF0 
	
		// Constructors
		public SendEvent(); // 0x00000001807A2A50-0x00000001807A2A90
	
		// Methods
		protected override void OnUpdate(); // 0x00000001807A2940-0x00000001807A2A50
	}
}
