/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework
{
	public interface IBlackboard // TypeDefIndex: 15743
	{
		// Properties
		string identifier { get; }
		IBlackboard parent { get; }
		Dictionary<string, Variable> variables { get; set; }
		Component propertiesBindTarget { get; }
		UnityEngine.Object unityContextObject { get; }
		string independantVariablesFieldName { get; }
	
		// Events
		event Action<Variable> onVariableAdded {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
		event Action<Variable> onVariableRemoved {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
	
		// Methods
		void TryInvokeOnVariableAdded(Variable variable);
		void TryInvokeOnVariableRemoved(Variable variable);
	}
}
