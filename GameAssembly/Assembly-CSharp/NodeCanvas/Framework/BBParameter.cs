/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework
{
	[Serializable]
	[fsAutoInstance] // 0x000000018021F650-0x000000018021F690
	[fsUninitialized] // 0x000000018021F650-0x000000018021F690
	[SpoofAOT] // 0x000000018021F650-0x000000018021F690
	public abstract class BBParameter : ISerializationCollectable, ISerializationCallbackReceiver // TypeDefIndex: 15734
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _name; // 0x10
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _targetVariableID; // 0x18
		private IBlackboard _bb; // 0x20
		private Variable _varRef; // 0x28
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action<Variable> onVariableReferenceChanged; // 0x30
	
		// Properties
		public string targetVariableID { get; protected set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
		public Variable varRef { get; protected set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001808A0740-0x00000001808A07B0
		public string name { get; set; } // 0x0000000180372440-0x0000000180372450 0x00000001808A0580-0x00000001808A0620
		public IBlackboard bb { get; set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001808A04F0-0x00000001808A0580
		public bool useBlackboard { get; set; } // 0x00000001808A0420-0x00000001808A0430 0x00000001808A0620-0x00000001808A0720
		public bool isPresumedDynamic { get; } // 0x00000001808A03B0-0x00000001808A0400 
		public bool isNone { get; } // 0x00000001808A0330-0x00000001808A0380 
		public bool isNull { get; } // 0x00000001808A0380-0x00000001808A03B0 
		public bool isNoneOrNull { get; } // 0x00000001808A02B0-0x00000001808A0330 
		public bool isDefined { get; } // 0x00000001808A0290-0x00000001808A02B0 
		public Type refType { get; } // 0x00000001808A0400-0x00000001808A0420 
		public object value { get; set; } // 0x00000001808A0430-0x00000001808A0450 0x00000001808A0720-0x00000001808A0740
		public abstract Type varType { get; }
	
		// Events
		public event Action<Variable> onVariableReferenceChanged {
			add; // 0x00000001808A01F0-0x00000001808A0290
			remove; // 0x00000001808A0450-0x00000001808A04F0
		}
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass11_0 // TypeDefIndex: 15735
		{
			// Fields
			public IBlackboard bb; // 0x10
	
			// Constructors
			public <>c__DisplayClass11_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <SetBBFields>b__0(object o, fsData d); // 0x00000001808B7520-0x00000001808B76A0
		}
	
		// Constructors
		public BBParameter(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		void ISerializationCallbackReceiver.OnBeforeSerialize(); // 0x00000001808A01D0-0x00000001808A01F0
		void ISerializationCallbackReceiver.OnAfterDeserialize(); // 0x00000001803774A0-0x00000001803774B0
		public static BBParameter CreateInstance(Type t, IBlackboard bb); // 0x000000018089F7E0-0x000000018089FA30
		public static void SetBBFields(object target, IBlackboard bb); // 0x000000018089FE30-0x000000018089FF10
		protected abstract void SetDefaultValue();
		protected abstract void Bind(Variable data);
		public abstract object GetValueBoxed();
		public abstract void SetValueBoxed(object value);
		internal void SetTargetVariable(IBlackboard targetBB, Variable targetVariable); // 0x000000018089FF10-0x00000001808A0020
		private Variable ResolveReference(IBlackboard targetBlackboard, bool useID); // 0x000000018089FC50-0x000000018089FE30
		public Variable PromoteToVariable(IBlackboard targetBB); // 0x000000018089FA30-0x000000018089FC50
		public sealed override string ToString(); // 0x00000001808A0020-0x00000001808A01D0
	}
}
