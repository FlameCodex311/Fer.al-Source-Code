/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework
{
	[SpoofAOT] // 0x00000001801CDDD0-0x00000001801CDE00
	public static class IBlackboardExtensions // TypeDefIndex: 15745
	{
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <GetAllParents>d__1 : IEnumerable<IBlackboard>, IEnumerator<IBlackboard> // TypeDefIndex: 15746
		{
			// Fields
			private int <>1__state; // 0x10
			private IBlackboard <>2__current; // 0x18
			private int <>l__initialThreadId; // 0x20
			private IBlackboard blackboard; // 0x28
			public IBlackboard <>3__blackboard; // 0x30
			private bool includeSelf; // 0x38
			public bool <>3__includeSelf; // 0x39
			private IBlackboard <current>5__2; // 0x40
	
			// Properties
			IBlackboard IEnumerator<NodeCanvas.Framework.IBlackboard>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <GetAllParents>d__1(int <>1__state); // 0x00000001806301B0-0x00000001806301E0
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180CD1190-0x0000000180CD1260
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180CD1300-0x0000000180CD1350
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<IBlackboard> IEnumerable<IBlackboard>.GetEnumerator(); // 0x0000000180CD1260-0x0000000180CD1300
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180CD1260-0x0000000180CD1300
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <GetVariables>d__14 : IEnumerable<Variable>, IEnumerator<Variable> // TypeDefIndex: 15747
		{
			// Fields
			private int <>1__state; // 0x10
			private Variable <>2__current; // 0x18
			private int <>l__initialThreadId; // 0x20
			private IBlackboard blackboard; // 0x28
			public IBlackboard <>3__blackboard; // 0x30
			private Type ofType; // 0x38
			public Type <>3__ofType; // 0x40
			private IEnumerator<Variable> <>7__wrap1; // 0x48
			private Dictionary<string, Variable> <>7__wrap2; // 0x50
	
			// Properties
			Variable IEnumerator<NodeCanvas.Framework.Variable>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <GetVariables>d__14(int <>1__state); // 0x00000001806301B0-0x00000001806301E0
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x0000000180CD1840-0x0000000180CD1970
			private bool MoveNext(); // 0x0000000180CD1350-0x0000000180CD1750
			private void <>m__Finally1(); // 0x0000000180CD1970-0x0000000180CD19C0
			private void <>m__Finally2(); // 0x0000000180CD19C0-0x0000000180CD1BE0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180CD17F0-0x0000000180CD1840
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<Variable> IEnumerable<Variable>.GetEnumerator(); // 0x0000000180CD1750-0x0000000180CD17F0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180CD1750-0x0000000180CD17F0
		}
	
		// Extension methods
		public static IBlackboard GetRoot(this IBlackboard blackboard); // 0x0000000180CC8C40-0x0000000180CC8CC0
		[IteratorStateMachine] // 0x0000000180223A90-0x0000000180223B00
		public static IEnumerable<IBlackboard> GetAllParents(this IBlackboard blackboard, bool includeSelf); // 0x0000000180CC8BC0-0x0000000180CC8C40
		public static bool IsPartOf(this IBlackboard blackboard, IBlackboard target); // 0x0000000180CC9330-0x0000000180CC93C0
		public static Variable<T> AddVariable<T>(this IBlackboard blackboard, string varName, T value);
		public static Variable<T> AddVariable<T>(this IBlackboard blackboard, string varName);
		public static Variable AddVariable(this IBlackboard blackboard, string varName, object value); // 0x0000000180CC8890-0x0000000180CC8910
		public static Variable AddVariable(this IBlackboard blackboard, string varName, Type type); // 0x0000000180CC8910-0x0000000180CC8BC0
		public static Variable RemoveVariable(this IBlackboard blackboard, string varName); // 0x0000000180CC98C0-0x0000000180CC99C0
		public static T GetVariableValue<T>(this IBlackboard blackboard, string varName);
		public static Variable SetVariableValue(this IBlackboard blackboard, string varName, object value); // 0x0000000180CC99C0-0x0000000180CC9B00
		public static void InitializePropertiesBinding(this IBlackboard blackboard, Component target, bool callSetter); // 0x0000000180CC9140-0x0000000180CC9330
		public static Variable<T> GetVariable<T>(this IBlackboard blackboard, string varName);
		public static Variable GetVariable(this IBlackboard blackboard, string varName, Type ofType = null); // 0x0000000180CC8F00-0x0000000180CC90C0
		public static Variable GetVariableByID(this IBlackboard blackboard, string ID); // 0x0000000180CC8CC0-0x0000000180CC8F00
		[IteratorStateMachine] // 0x0000000180226430-0x00000001802264A0
		public static IEnumerable<Variable> GetVariables(this IBlackboard blackboard, Type ofType = null); // 0x0000000180CC90C0-0x0000000180CC9140
		public static void OverwriteFrom(this IBlackboard blackboard, IBlackboard sourceBlackboard, bool removeMissingVariables = true /* Metadata: 0x007BB4CC */); // 0x0000000180CC93C0-0x0000000180CC98C0
	}
}
