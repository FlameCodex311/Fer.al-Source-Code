/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180268190-0x0000000180268210
	[Description] // 0x0000000180268190-0x0000000180268210
	[Name] // 0x0000000180268190-0x0000000180268210
	public class ExecuteFunction_Multiplatform : ActionTask, IReflectedWrapper // TypeDefIndex: 15411
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected SerializedMethodInfo method; // 0x68
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected List<BBObjectParameter> parameters; // 0x70
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		protected BBObjectParameter returnValue; // 0x78
		private object[] args; // 0x80
		private bool routineRunning; // 0x88
		private bool[] parameterIsByRef; // 0x90
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x000000018079C630-0x000000018079C640 
		public override Type agentType { get; } // 0x0000000180BA80B0-0x0000000180BA8190 
		protected override string info { get; } // 0x0000000180BA8190-0x0000000180BA8650 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <InternalCoroutine>d__17 : IEnumerator<object> // TypeDefIndex: 15412
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ExecuteFunction_Multiplatform <>4__this; // 0x20
			public IEnumerator routine; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <InternalCoroutine>d__17(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180BBECF0-0x0000000180BBEDF0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180BBEDF0-0x0000000180BBEE40
		}
	
		// Constructors
		public ExecuteFunction_Multiplatform(); // 0x0000000180BA8050-0x0000000180BA80B0
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x00000001803765E0-0x00000001803765F0
		public override void OnValidate(ITaskSystem ownerSystem); // 0x0000000180BA7CC0-0x0000000180BA7D00
		protected override string OnInit(); // 0x0000000180BA7AE0-0x0000000180BA7CB0
		protected override void OnExecute(); // 0x0000000180BA7700-0x0000000180BA7AE0
		protected override void OnStop(); // 0x0000000180BA7CB0-0x0000000180BA7CC0
		[IteratorStateMachine] // 0x0000000180268750-0x00000001802687A0
		private IEnumerator InternalCoroutine(IEnumerator routine); // 0x0000000180BA7690-0x0000000180BA7700
		private void SetMethod(MethodInfo method); // 0x0000000180BA7D00-0x0000000180BA8050
	}
}
