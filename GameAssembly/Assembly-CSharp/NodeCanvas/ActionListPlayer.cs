/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas
{
	[AddComponentMenu] // 0x00000001801EAA80-0x00000001801EAAB0
	public class ActionListPlayer : ManagedBehaviour, ITaskSystem, ISerializationCallbackReceiver // TypeDefIndex: 15068
	{
		// Fields
		public bool playOnAwake; // 0x50
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _serializedList; // 0x58
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private List<UnityEngine.Object> _objectReferences; // 0x60
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Blackboard _blackboard; // 0x68
		[NonSerialized]
		private ActionList _actionList; // 0x70
		private float timeStarted; // 0x78
	
		// Properties
		public ActionList actionList { get; } // 0x0000000180418980-0x0000000180418990 
		public float elapsedTime { get; } // 0x00000001807C4080-0x00000001807C40A0 
		UnityEngine.Object ITaskSystem.contextObject { get; } // 0x0000000180411160-0x0000000180411170 
		Component ITaskSystem.agent { get; } // 0x0000000180411160-0x0000000180411170 
		public IBlackboard blackboard { get; set; } // 0x00000001803765E0-0x00000001803765F0 0x00000001807C40A0-0x00000001807C4140
	
		// Constructors
		public ActionListPlayer(); // 0x00000001807C4020-0x00000001807C4080
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x00000001807C3D40-0x00000001807C3EA0
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001807C3C20-0x00000001807C3D40
		public static ActionListPlayer Create(); // 0x00000001807C3980-0x00000001807C39F0
		public override void MAwake(); // 0x00000001807C3A50-0x00000001807C3AD0
		public void UpdateTasksOwner(); // 0x00000001807C3EA0-0x00000001807C4020
		void ITaskSystem.SendEvent(string name, object value, object sender); // 0x00000001803774A0-0x00000001803774B0
		void ITaskSystem.SendEvent<T>(string name, T value, object sender);
		[ContextMenu] // 0x00000001801EB090-0x00000001801EB0C0
		public void Play(); // 0x00000001807C3B50-0x00000001807C3BB0
		public void Play(Action<Status> OnFinish); // 0x00000001807C3BB0-0x00000001807C3C20
		public void Play(Component agent, IBlackboard blackboard, Action<Status> OnFinish); // 0x00000001807C3AD0-0x00000001807C3B50
		public Status Execute(); // 0x00000001807C39F0-0x00000001807C3A20
		public Status Execute(Component agent); // 0x00000001807C3A20-0x00000001807C3A50
	}
}
