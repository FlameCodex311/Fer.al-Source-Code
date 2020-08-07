/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x000000018023F820-0x000000018023F880
	[Description] // 0x000000018023F820-0x000000018023F880
	public class CheckEvent : ConditionTask<GraphOwner> // TypeDefIndex: 15270
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<string> eventName; // 0x68
	
		// Properties
		protected override string info { get; } // 0x000000018079ABF0-0x000000018079AC60 
	
		// Constructors
		public CheckEvent(); // 0x000000018079ABB0-0x000000018079ABF0
	
		// Methods
		protected override void OnEnable(); // 0x000000018079AB20-0x000000018079ABB0
		protected override void OnDisable(); // 0x000000018079AA90-0x000000018079AB20
		protected override bool OnCheck(); // 0x0000000180380950-0x0000000180380960
		private void OnCustomEvent(string eventName, IEventData data); // 0x000000018079AA10-0x000000018079AA90
	}
}
