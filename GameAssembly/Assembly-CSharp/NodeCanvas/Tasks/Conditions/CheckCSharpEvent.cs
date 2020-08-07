/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x0000000180232950-0x0000000180232A00
	[Description] // 0x0000000180232950-0x0000000180232A00
	[fsMigrateVersions] // 0x0000000180232950-0x0000000180232A00
	public class CheckCSharpEvent : ConditionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Conditions.CheckCSharpEvent_0>, IMigratable<NodeCanvas.Tasks.Conditions.CheckStaticCSharpEvent> // TypeDefIndex: 15241
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private SerializedEventInfo eventInfo; // 0x68
		private Delegate handler; // 0x70
	
		// Properties
		private EventInfo targetEvent { get; } // 0x0000000180796EB0-0x0000000180796EC0 
		public override Type agentType { get; } // 0x0000000180796CD0-0x0000000180796DD0 
		protected override string info { get; } // 0x0000000180796DD0-0x0000000180796EB0 
	
		// Constructors
		public CheckCSharpEvent(); // 0x0000000180792480-0x0000000180792490
	
		// Methods
		void IMigratable<CheckCSharpEvent_0>.Migrate(CheckCSharpEvent_0 model); // 0x0000000180796B10-0x0000000180796BB0
		void IMigratable<CheckStaticCSharpEvent>.Migrate(CheckStaticCSharpEvent model); // 0x0000000180796BB0-0x0000000180796C50
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x00000001803765E0-0x00000001803765F0
		protected override string OnInit(); // 0x00000001807969D0-0x0000000180796B10
		protected override void OnEnable(); // 0x0000000180796900-0x00000001807969D0
		protected override void OnDisable(); // 0x0000000180796830-0x0000000180796900
		public void Raised(); // 0x0000000180792470-0x0000000180792480
		protected override bool OnCheck(); // 0x0000000180380950-0x0000000180380960
		private void SetTargetEvent(EventInfo info); // 0x0000000180796C50-0x0000000180796CD0
	}
}
