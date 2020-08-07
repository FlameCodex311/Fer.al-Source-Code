/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework
{
	[CreateAssetMenu] // 0x00000001801FFD00-0x00000001801FFD30
	public class SignalDefinition : ScriptableObject // TypeDefIndex: 15667
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private InvokeArguments onInvoke; // 0x18
		[HideInInspector] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		private List<DynamicParameterDefinition> _parameters; // 0x20
	
		// Properties
		public List<DynamicParameterDefinition> parameters { get; private set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
	
		// Events
		public event InvokeArguments onInvoke {
			add; // 0x0000000180CCEAD0-0x0000000180CCEB70
			remove; // 0x0000000180CCEB70-0x0000000180CCEC10
		}
	
		// Nested types
		public delegate void InvokeArguments(Transform sender, Transform receiver, bool isGlobal, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ object[] args); // TypeDefIndex: 15668; 0x0000000180CCAF80-0x0000000180CCB4D0
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass10_0 // TypeDefIndex: 15669
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public <>c__DisplayClass10_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <RemoveParameter>b__0(DynamicParameterDefinition p); // 0x0000000180387C90-0x0000000180387CC0
		}
	
		// Constructors
		public SignalDefinition(); // 0x0000000180CCEA70-0x0000000180CCEAD0
	
		// Methods
		public void Invoke(Transform sender, Transform receiver, bool isGlobal, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ object[] args); // 0x0000000180CCE970-0x0000000180CCE990
		public void AddParameter(string name, Type type); // 0x0000000180CCE8E0-0x0000000180CCE970
		public void RemoveParameter(string name); // 0x0000000180CCE990-0x0000000180CCEA70
	}
}
