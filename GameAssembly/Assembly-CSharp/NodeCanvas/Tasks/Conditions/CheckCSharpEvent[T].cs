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
	[Category] // 0x0000000180232F30-0x0000000180232FE0
	[Description] // 0x0000000180232F30-0x0000000180232FE0
	[fsMigrateVersions] // 0x0000000180232F30-0x0000000180232FE0
	public class CheckCSharpEvent<T> : ConditionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Conditions.CheckCSharpEvent_0<T>>, IMigratable<NodeCanvas.Tasks.Conditions.CheckStaticCSharpEvent<T>> // TypeDefIndex: 15242
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private SerializedEventInfo eventInfo;
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private BBParameter<T> saveAs;
		private Delegate handler;
	
		// Properties
		private EventInfo targetEvent { get; }
		public override Type agentType { get; }
		protected override string info { get; }
	
		// Constructors
		public CheckCSharpEvent();
	
		// Methods
		void IMigratable<CheckCSharpEvent_0<T>>.Migrate(CheckCSharpEvent_0<T> model);
		void IMigratable<CheckStaticCSharpEvent<T>>.Migrate(CheckStaticCSharpEvent<T> model);
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo();
		protected override string OnInit();
		protected override void OnEnable();
		protected override void OnDisable();
		public void Raised(T eventValue);
		protected override bool OnCheck();
		private void SetTargetEvent(EventInfo info);
	}
}
