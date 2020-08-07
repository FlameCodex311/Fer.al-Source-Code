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
	[Category] // 0x0000000180238070-0x0000000180238120
	[Description] // 0x0000000180238070-0x0000000180238120
	[fsMigrateVersions] // 0x0000000180238070-0x0000000180238120
	public class CheckUnityEvent<T> : ConditionTask, IReflectedWrapper, IMigratable<NodeCanvas.Tasks.Conditions.CheckUnityEvent_0<T>> // TypeDefIndex: 15252
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private SerializedUnityEventInfo _eventInfo;
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private BBParameter<T> saveAs;
		private UnityEvent<T> unityEvent;
	
		// Properties
		private MemberInfo targetMember { get; }
		private bool isStatic { get; }
		private Type eventType { get; }
		private FieldInfo targetEventField { get; }
		private PropertyInfo targetEventProp { get; }
		public override Type agentType { get; }
		protected override string info { get; }
	
		// Constructors
		public CheckUnityEvent();
	
		// Methods
		void IMigratable<CheckUnityEvent_0<T>>.Migrate(CheckUnityEvent_0<T> model);
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo();
		protected override string OnInit();
		protected override void OnEnable();
		protected override void OnDisable();
		public void Raised(T eventValue);
		protected override bool OnCheck();
		private void SetTargetEvent(MemberInfo newMember);
	}
}
