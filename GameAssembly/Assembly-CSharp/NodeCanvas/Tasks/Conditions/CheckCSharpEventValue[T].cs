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
	[Category] // 0x0000000180233CD0-0x0000000180233D80
	[Description] // 0x0000000180233CD0-0x0000000180233D80
	[fsMigrateVersions] // 0x0000000180233CD0-0x0000000180233D80
	public class CheckCSharpEventValue<T> : ConditionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Conditions.CheckCSharpEventValue_0<T>> // TypeDefIndex: 15243
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private SerializedEventInfo eventInfo;
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private BBParameter<T> checkValue;
		private Delegate handler;
	
		// Properties
		private EventInfo targetEvent { get; }
		public override Type agentType { get; }
		protected override string info { get; }
	
		// Constructors
		public CheckCSharpEventValue();
	
		// Methods
		void IMigratable<CheckCSharpEventValue_0<T>>.Migrate(CheckCSharpEventValue_0<T> model);
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo();
		protected override string OnInit();
		protected override void OnEnable();
		protected override void OnDisable();
		public void Raised(T eventValue);
		protected override bool OnCheck();
		private void SetTargetEvent(EventInfo info);
	}
}
