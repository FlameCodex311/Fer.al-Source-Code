/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Framework.Internal
{
	[Serializable]
	public sealed class BlackboardSource : IBlackboard // TypeDefIndex: 14659
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Action<Variable> onVariableAdded; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Action<Variable> onVariableRemoved; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string _name; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Dictionary<string, Variable> _variables; // 0x28
	
		// Properties
		public string name { get; set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
		public Dictionary<string, Variable> variables { get; set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
		public GameObject propertiesBindTarget { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		public object this[string varName] { get => default; set {} } // 0x000000018174A700-0x000000018174A790 0x000000018174A8D0-0x000000018174A8E0
	
		// Events
		public event Action<Variable> onVariableAdded {
			add; // 0x000000018174A5C0-0x000000018174A660
			remove; // 0x000000018174A790-0x000000018174A830
		}
		public event Action<Variable> onVariableRemoved {
			add; // 0x000000018174A660-0x000000018174A700
			remove; // 0x000000018174A830-0x000000018174A8D0
		}
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass30_0 // TypeDefIndex: 14660
		{
			// Fields
			public Type ofType; // 0x10
	
			// Constructors
			public <>c__DisplayClass30_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <GetVariableNames>b__0(Variable v); // 0x0000000181760F40-0x0000000181760F70
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 14661
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<Variable, string> <>9__30_1; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000181761460-0x00000001817614C0
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal string <GetVariableNames>b__30_1(Variable v); // 0x000000018059C9F0-0x000000018059CA10
		}
	
		// Constructors
		public BlackboardSource(); // 0x000000018174A4D0-0x000000018174A5C0
	
		// Methods
		public void InitializePropertiesBinding(GameObject targetGO, bool callSetter); // 0x0000000181749FE0-0x000000018174A160
		public Variable AddVariable(string varName, object value); // 0x0000000181749660-0x0000000181749730
		public Variable AddVariable(string varName, Type type); // 0x0000000181749730-0x0000000181749AC0
		public Variable RemoveVariable(string varName); // 0x000000018174A160-0x000000018174A210
		public T GetValue<T>(string varName);
		public Variable SetValue(string varName, object value); // 0x000000018174A210-0x000000018174A4D0
		public Variable<T> GetVariable<T>(string varName);
		public Variable GetVariable(string varName, Type ofType = null); // 0x0000000181749F00-0x0000000181749FE0
		public Variable GetVariableByID(string ID); // 0x0000000181749AC0-0x0000000181749D10
		public string[] GetVariableNames(); // 0x0000000181749EA0-0x0000000181749F00
		public string[] GetVariableNames(Type ofType); // 0x0000000181749D10-0x0000000181749EA0
		public Variable<T> AddVariable<T>(string varName, T value);
		public Variable<T> AddVariable<T>(string varName);
	}
}
