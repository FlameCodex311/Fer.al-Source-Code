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
	[Category] // 0x000000018023FCD0-0x000000018023FD30
	[Description] // 0x000000018023FCD0-0x000000018023FD30
	public class CheckEvent<T> : ConditionTask<GraphOwner> // TypeDefIndex: 15271
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<string> eventName;
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<T> saveEventValue;
	
		// Properties
		protected override string info { get; }
	
		// Constructors
		public CheckEvent();
	
		// Methods
		protected override void OnEnable();
		protected override void OnDisable();
		protected override bool OnCheck();
		private void OnCustomEvent(string eventName, IEventData data);
	}
}
