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
	[Category] // 0x0000000180240290-0x00000001802402F0
	[Description] // 0x0000000180240290-0x00000001802402F0
	public class CheckEventValue<T> : ConditionTask<GraphOwner> // TypeDefIndex: 15272
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<string> eventName;
		[Name] // 0x0000000180240720-0x0000000180240750
		public BBParameter<T> value;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public CheckEventValue();
	
		// Methods
		protected override void OnEnable();
		protected override void OnDisable();
		protected override bool OnCheck();
		private void OnCustomEvent(string eventName, IEventData msg);
	}
}
