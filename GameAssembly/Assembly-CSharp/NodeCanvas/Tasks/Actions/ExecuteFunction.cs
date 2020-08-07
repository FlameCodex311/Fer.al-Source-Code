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
	[Category] // 0x000000018026CEE0-0x000000018026CF60
	[Description] // 0x000000018026CEE0-0x000000018026CF60
	[Name] // 0x000000018026CEE0-0x000000018026CF60
	public class ExecuteFunction : ActionTask, IReflectedWrapper // TypeDefIndex: 15423
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected ReflectedWrapper functionWrapper; // 0x68
		private bool routineRunning; // 0x70
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x000000018079D0D0-0x000000018079D0F0 
		public override Type agentType { get; } // 0x0000000180BA8CC0-0x0000000180BA8DD0 
		protected override string info { get; } // 0x0000000180BA8DD0-0x0000000180BA9420 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <InternalCoroutine>d__13 : IEnumerator<object> // TypeDefIndex: 15424
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ExecuteFunction <>4__this; // 0x20
			public IEnumerator routine; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <InternalCoroutine>d__13(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180BBEBB0-0x0000000180BBECA0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180BBECA0-0x0000000180BBECF0
		}
	
		// Constructors
		public ExecuteFunction(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x00000001807A6AE0-0x00000001807A6AF0
		public override void OnValidate(ITaskSystem ownerSystem); // 0x0000000180BA8BF0-0x0000000180BA8C70
		protected override string OnInit(); // 0x0000000180BA8AA0-0x0000000180BA8BE0
		protected override void OnExecute(); // 0x0000000180BA8650-0x0000000180BA8AA0
		protected override void OnStop(); // 0x0000000180BA8BE0-0x0000000180BA8BF0
		[IteratorStateMachine] // 0x000000018026E630-0x000000018026E680
		private IEnumerator InternalCoroutine(IEnumerator routine); // 0x0000000180BA7620-0x0000000180BA7690
		private void SetMethod(MethodInfo method); // 0x0000000180BA8C70-0x0000000180BA8CC0
	}
}
