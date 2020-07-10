/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas
{
	[AddComponentMenu] // 0x000000018015A040-0x000000018015A070
	public class ActionListPlayer : MonoBehaviour, ITaskSystem, ISerializationCallbackReceiver // TypeDefIndex: 14002
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string _serializedList; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private List<UnityEngine.Object> _objectReferences; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Blackboard _blackboard; // 0x30
		[NonSerialized]
		private ActionList _actionList; // 0x38
	
		// Properties
		public ActionList actionList { get; } // 0x0000000180369BB0-0x0000000180369BC0 
		Component ITaskSystem.agent { get; } // 0x0000000180362190-0x00000001803621A0 
		public IBlackboard blackboard { get; set; } // 0x0000000180397720-0x0000000180397730 0x000000018155CF60-0x000000018155D000
		public float elapsedTime { get; } // 0x000000018155CF10-0x000000018155CF60 
		UnityEngine.Object ITaskSystem.contextObject { get; } // 0x0000000180362190-0x00000001803621A0 
	
		// Constructors
		public ActionListPlayer(); // 0x0000000180E095D0-0x0000000180E095E0
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x00000001803581E0-0x00000001803581F0
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x000000018155CDF0-0x000000018155CF10
		public static ActionListPlayer Create(); // 0x000000018155CA30-0x000000018155CAA0
		public void SendTaskOwnerDefaults(); // 0x000000018155CC90-0x000000018155CDF0
		void ITaskSystem.SendEvent(EventData eventData, object sender); // 0x000000018155CB00-0x000000018155CB50
		void ITaskSystem.RecordUndo(string name); // 0x00000001803581E0-0x00000001803581F0
		private void Awake(); // 0x000000018155CA20-0x000000018155CA30
		[ContextMenu] // 0x000000018015A7C0-0x000000018015A7F0
		public void Play(); // 0x000000018155CC60-0x000000018155CC90
		public void Play(Action<bool> OnFinish); // 0x000000018155CC30-0x000000018155CC60
		public void Play(Component agent, IBlackboard blackboard, Action<bool> OnFinish); // 0x000000018155CB50-0x000000018155CC30
		public Status ExecuteAction(); // 0x000000018155CAD0-0x000000018155CB00
		public Status ExecuteAction(Component agent); // 0x000000018155CAA0-0x000000018155CAD0
	}
}
