/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Framework
{
	[SpoofAOT] // 0x00000001800B36B0-0x00000001800B36C0
	public interface IBlackboard // TypeDefIndex: 14607
	{
		// Properties
		string name { get; set; }
		Dictionary<string, Variable> variables { get; set; }
		GameObject propertiesBindTarget { get; }
	
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
		Variable AddVariable(string varName, Type type);
		Variable AddVariable(string varName, object value);
		Variable RemoveVariable(string varName);
		Variable GetVariable(string varName, Type ofType = null);
		Variable GetVariableByID(string ID);
		Variable<T> GetVariable<T>(string varName);
		T GetValue<T>(string varName);
		Variable SetValue(string varName, object value);
		string[] GetVariableNames();
		string[] GetVariableNames(Type ofType);
	}
}
