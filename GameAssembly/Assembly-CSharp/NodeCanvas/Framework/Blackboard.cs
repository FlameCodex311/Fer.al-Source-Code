/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Framework
{
	[SpoofAOT] // 0x00000001800FC9A0-0x00000001800FC9F0
	public class Blackboard : MonoBehaviour, ISerializationCallbackReceiver, IBlackboard // TypeDefIndex: 14604
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Action<Variable> onVariableAdded; // 0x20
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Action<Variable> onVariableRemoved; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string _serializedBlackboard; // 0x30
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private List<UnityEngine.Object> _objectReferences; // 0x38
		[NonSerialized]
		private BlackboardSource _blackboard; // 0x40
		[NonSerialized]
		private bool hasDeserialized; // 0x48
	
		// Properties
		public new string name { get; set; } // 0x0000000181561C40-0x0000000181561CE0 0x0000000181561E50-0x0000000181561EE0
		public object this[string varName] { get => default; set {} } // 0x0000000181561C20-0x0000000181561C40 0x0000000181561940-0x0000000181561960
		public Dictionary<string, Variable> variables { get; set; } // 0x0000000181561CF0-0x0000000181561D10 0x0000000181561EE0-0x0000000181561F00
		public GameObject propertiesBindTarget { get; } // 0x0000000181561CE0-0x0000000181561CF0 
	
		// Events
		public event Action<Variable> onVariableAdded {
			add; // 0x0000000181561AE0-0x0000000181561B80
			remove; // 0x0000000181561D10-0x0000000181561DB0
		}
		public event Action<Variable> onVariableRemoved {
			add; // 0x0000000181561B80-0x0000000181561C20
			remove; // 0x0000000181561DB0-0x0000000181561E50
		}
	
		// Constructors
		public Blackboard(); // 0x0000000181561A80-0x0000000181561AE0
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x00000001803581E0-0x00000001803581F0
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x0000000181561960-0x0000000181561A80
		protected virtual void Awake(); // 0x0000000181560EF0-0x0000000181560F30
		public Variable AddVariable(string name, Type type); // 0x0000000181560DF0-0x0000000181560E70
		public Variable AddVariable(string name, object value); // 0x0000000181560E70-0x0000000181560EF0
		public Variable RemoveVariable(string name); // 0x00000001815615C0-0x0000000181561630
		public Variable GetVariable(string name, Type ofType = null); // 0x0000000181561400-0x0000000181561420
		public Variable GetVariableByID(string ID); // 0x00000001815613A0-0x00000001815613C0
		public Variable<T> GetVariable<T>(string name);
		public T GetValue<T>(string name);
		public Variable SetValue(string name, object value); // 0x0000000181561940-0x0000000181561960
		public string[] GetVariableNames(); // 0x00000001815613C0-0x00000001815613E0
		public string[] GetVariableNames(Type ofType); // 0x00000001815613E0-0x0000000181561400
		public string Save(); // 0x0000000181561630-0x0000000181561710
		public string Save(string saveKey); // 0x0000000181561710-0x00000001815617E0
		public bool Load(); // 0x0000000181561420-0x00000001815614F0
		public bool Load(string saveKey); // 0x00000001815614F0-0x00000001815615C0
		public string Serialize(); // 0x00000001815617E0-0x0000000181561890
		public string Serialize(List<UnityEngine.Object> storedObjectReferences); // 0x0000000181561890-0x0000000181561940
		public bool Deserialize(string json); // 0x0000000181560F30-0x0000000181560F50
		public bool Deserialize(string json, List<UnityEngine.Object> storedObjectReferences, bool removeMissing = true /* Metadata: 0x00784641 */); // 0x0000000181560F50-0x00000001815613A0
	}
}
