/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework
{
	[SpoofAOT] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class Blackboard : ManagedBehaviour, ISerializationCallbackReceiver, IBlackboard // TypeDefIndex: 15740
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _serializedBlackboard; // 0x50
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private List<UnityEngine.Object> _objectReferences; // 0x58
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private SerializationPair[] _serializedVariables; // 0x60
		[NonSerialized]
		private BlackboardSource _blackboard; // 0x68
		[NonSerialized]
		private bool haltForUndo; // 0x70
		[NonSerialized]
		private string _identifier; // 0x78
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action<Variable> onVariableAdded; // 0x80
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action<Variable> onVariableRemoved; // 0x88
	
		// Properties
		string IBlackboard.identifier { get; } // 0x0000000180418A40-0x0000000180418A50 
		Dictionary<string, Variable> IBlackboard.variables { get; set; } // 0x00000001808A0CA0-0x00000001808A0CC0 0x00000001808A0CC0-0x00000001808A0CE0
		Component IBlackboard.propertiesBindTarget { get; } // 0x0000000180411160-0x0000000180411170 
		UnityEngine.Object IBlackboard.unityContextObject { get; } // 0x0000000180411160-0x0000000180411170 
		IBlackboard IBlackboard.parent { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		string IBlackboard.independantVariablesFieldName { get; } // 0x00000001808A0C70-0x00000001808A0CA0 
	
		// Events
		public event Action<Variable> onVariableAdded {
			add; // 0x00000001808A1600-0x00000001808A16A0
			remove; // 0x00000001808A1740-0x00000001808A17E0
		}
		public event Action<Variable> onVariableRemoved {
			add; // 0x00000001808A16A0-0x00000001808A1740
			remove; // 0x00000001808A17E0-0x00000001808A1880
		}
	
		// Constructors
		public Blackboard(); // 0x00000001808A1580-0x00000001808A1600
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x00000001808A1570-0x00000001808A1580
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001808A1560-0x00000001808A1570
		public void SelfSerialize(); // 0x00000001808A10E0-0x00000001808A1420
		public void SelfDeserialize(); // 0x00000001808A0EC0-0x00000001808A10E0
		public string Serialize(List<UnityEngine.Object> references, bool pretyJson = false /* Metadata: 0x007BB4CA */); // 0x00000001808A1420-0x00000001808A14E0
		public bool Deserialize(string json, List<UnityEngine.Object> references, bool removeMissingVariables = true /* Metadata: 0x007BB4CB */); // 0x00000001808A07D0-0x00000001808A0890
		void IBlackboard.TryInvokeOnVariableAdded(Variable variable); // 0x00000001808A0BB0-0x00000001808A0C10
		void IBlackboard.TryInvokeOnVariableRemoved(Variable variable); // 0x00000001808A0C10-0x00000001808A0C70
		public override void MAwake(); // 0x00000001808A0B30-0x00000001808A0BB0
		public Variable AddVariable(string name, Type type); // 0x00000001808A07B0-0x00000001808A07C0
		public Variable AddVariable(string name, object value); // 0x00000001808A07C0-0x00000001808A07D0
		public Variable RemoveVariable(string name); // 0x00000001808A0D10-0x00000001808A0D20
		public Variable GetVariable(string name, Type ofType = null); // 0x00000001808A08A0-0x00000001808A08B0
		public Variable GetVariableByID(string ID); // 0x00000001808A0890-0x00000001808A08A0
		public Variable<T> GetVariable<T>(string name);
		public T GetVariableValue<T>(string name);
		public Variable SetVariableValue(string name, object value); // 0x00000001808A14E0-0x00000001808A14F0
		[Obsolete] // 0x0000000180222600-0x0000000180222630
		public T GetValue<T>(string name);
		[Obsolete] // 0x00000001802227B0-0x00000001802227E0
		public Variable SetValue(string name, object value); // 0x00000001808A14E0-0x00000001808A14F0
		[ContextMenu] // 0x000000018021F430-0x000000018021F460
		private void ShowJson(); // 0x00000001808A14F0-0x00000001808A1560
		public string Save(); // 0x00000001808A0D20-0x00000001808A0DF0
		public string Save(string saveKey); // 0x00000001808A0DF0-0x00000001808A0EC0
		public bool Load(); // 0x00000001808A08B0-0x00000001808A09F0
		public bool Load(string saveKey); // 0x00000001808A09F0-0x00000001808A0B30
		protected virtual void OnValidate(); // 0x00000001808A0CE0-0x00000001808A0D10
		public override string ToString(); // 0x0000000180418A40-0x0000000180418A50
	}
}
