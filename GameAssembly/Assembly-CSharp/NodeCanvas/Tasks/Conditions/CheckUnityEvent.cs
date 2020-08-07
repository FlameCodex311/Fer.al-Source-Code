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
using UnityEngine.Events;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x0000000180237640-0x00000001802376F0
	[Description] // 0x0000000180237640-0x00000001802376F0
	[fsMigrateVersions] // 0x0000000180237640-0x00000001802376F0
	public class CheckUnityEvent : ConditionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Conditions.CheckUnityEvent_0> // TypeDefIndex: 15251
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private SerializedUnityEventInfo _eventInfo; // 0x68
		private UnityEvent unityEvent; // 0x70
	
		// Properties
		private MemberInfo targetMember { get; } // 0x00000001807F76A0-0x00000001807F76B0 
		private bool isStatic { get; } // 0x00000001807F7660-0x00000001807F7680 
		private Type eventType { get; } // 0x00000001807F7560-0x00000001807F7580 
		private FieldInfo targetEventField { get; } // 0x00000001807F7680-0x00000001807F7690 
		private PropertyInfo targetEventProp { get; } // 0x00000001807F7690-0x00000001807F76A0 
		public override Type agentType { get; } // 0x00000001807F7470-0x00000001807F7560 
		protected override string info { get; } // 0x00000001807F7580-0x00000001807F7660 
	
		// Constructors
		public CheckUnityEvent(); // 0x0000000180792480-0x0000000180792490
	
		// Methods
		void IMigratable<CheckUnityEvent_0>.Migrate(CheckUnityEvent_0 model); // 0x00000001807F7330-0x00000001807F73F0
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x00000001803765E0-0x00000001803765F0
		protected override string OnInit(); // 0x00000001807F7130-0x00000001807F7330
		protected override void OnEnable(); // 0x00000001807F70A0-0x00000001807F7130
		protected override void OnDisable(); // 0x00000001807F7010-0x00000001807F70A0
		public void Raised(); // 0x0000000180792470-0x0000000180792480
		protected override bool OnCheck(); // 0x0000000180380950-0x0000000180380960
		private void SetTargetEvent(MemberInfo newMember); // 0x00000001807F73F0-0x00000001807F7470
	}
}
