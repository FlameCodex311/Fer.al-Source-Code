/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework.Internal;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework
{
	[CreateAssetMenu] // 0x000000018021E0F0-0x000000018021E120
	public class AssetBlackboard : ScriptableObject, ISerializationCallbackReceiver, IGlobalBlackboard // TypeDefIndex: 15733
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action<Variable> onVariableAdded; // 0x18
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action<Variable> onVariableRemoved; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _serializedBlackboard; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private List<UnityEngine.Object> _objectReferences; // 0x30
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _UID; // 0x38
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _identifier; // 0x40
		[NonSerialized]
		private BlackboardSource _blackboard; // 0x48
	
		// Properties
		Dictionary<string, Variable> IBlackboard.variables { get; set; } // 0x000000018089F280-0x000000018089F2A0 0x000000018089F2A0-0x000000018089F2C0
		UnityEngine.Object IBlackboard.unityContextObject { get; } // 0x0000000180411160-0x0000000180411170 
		IBlackboard IBlackboard.parent { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		Component IBlackboard.propertiesBindTarget { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		string IBlackboard.independantVariablesFieldName { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		public string identifier { get; } // 0x00000001803C7290-0x00000001803C72A0 
		public string UID { get; } // 0x00000001803743D0-0x00000001803743E0 
		public new string name { get; } // 0x00000001803C7290-0x00000001803C72A0 
	
		// Events
		public event Action<Variable> onVariableAdded {
			add; // 0x000000018089F560-0x000000018089F600
			remove; // 0x000000018089F6A0-0x000000018089F740
		}
		public event Action<Variable> onVariableRemoved {
			add; // 0x000000018089F600-0x000000018089F6A0
			remove; // 0x000000018089F740-0x000000018089F7E0
		}
	
		// Constructors
		public AssetBlackboard(); // 0x000000018089F4B0-0x000000018089F560
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x000000018089F360-0x000000018089F440
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x000000018089F2C0-0x000000018089F360
		private void SelfSerialize(); // 0x000000018089F360-0x000000018089F440
		private void SelfDeserialize(); // 0x000000018089F2C0-0x000000018089F360
		void IBlackboard.TryInvokeOnVariableAdded(Variable variable); // 0x000000018089F1E0-0x000000018089F230
		void IBlackboard.TryInvokeOnVariableRemoved(Variable variable); // 0x000000018089F230-0x000000018089F280
		[ContextMenu] // 0x000000018021F430-0x000000018021F460
		private void ShowJson(); // 0x000000018089F440-0x000000018089F4B0
		public override string ToString(); // 0x00000001803C7290-0x00000001803C72A0
	}
}
