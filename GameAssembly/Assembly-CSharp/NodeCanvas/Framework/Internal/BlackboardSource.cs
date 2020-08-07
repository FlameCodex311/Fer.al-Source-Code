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

namespace NodeCanvas.Framework.Internal
{
	[Serializable]
	public class BlackboardSource : IBlackboard // TypeDefIndex: 15785
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Dictionary<string, Variable> _variables; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action<Variable> onVariableAdded; // 0x18
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action<Variable> onVariableRemoved; // 0x20
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IBlackboard <parent>k__BackingField; // 0x28
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private UnityEngine.Object <unityContextObject>k__BackingField; // 0x30
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Component <propertiesBindTarget>k__BackingField; // 0x38
	
		// Properties
		public string identifier { get; } // 0x0000000180CBF410-0x0000000180CBF440 
		public Dictionary<string, Variable> variables { get; set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
		public IBlackboard parent { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001803FA0C0-0x00000001803FA0D0
		public UnityEngine.Object unityContextObject { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803745C0-0x00000001803745D0 0x00000001803FA0A0-0x00000001803FA0B0
		public Component propertiesBindTarget { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803743D0-0x00000001803743E0 0x00000001803FEB60-0x00000001803FEB70
		string IBlackboard.independantVariablesFieldName { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	
		// Events
		public event Action<Variable> onVariableAdded {
			add; // 0x0000000180CBF530-0x0000000180CBF5D0
			remove; // 0x0000000180CBF670-0x0000000180CBF710
		}
		public event Action<Variable> onVariableRemoved {
			add; // 0x0000000180CBF5D0-0x0000000180CBF670
			remove; // 0x0000000180CBF710-0x0000000180CBF7B0
		}
	
		// Constructors
		public BlackboardSource(); // 0x0000000180CBF440-0x0000000180CBF530
	
		// Methods
		void IBlackboard.TryInvokeOnVariableAdded(Variable variable); // 0x0000000180CBF370-0x0000000180CBF3C0
		void IBlackboard.TryInvokeOnVariableRemoved(Variable variable); // 0x0000000180CBF3C0-0x0000000180CBF410
		public override string ToString(); // 0x0000000180CBF410-0x0000000180CBF440
	}
}
