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
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180106690-0x00000001801066F0
	[Description] // 0x0000000180106690-0x00000001801066F0
	public class ExecuteFunction : ActionTask, ISubParametersContainer, IReflectedWrapper // TypeDefIndex: 14320
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected ReflectedWrapper functionWrapper; // 0x68
		private bool routineRunning; // 0x70
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x0000000181252400-0x0000000181252420 
		public override Type agentType { get; } // 0x0000000181542F20-0x0000000181543030 
		protected override string info { get; } // 0x0000000181543030-0x0000000181543690 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <InternalCoroutine>d__14 : IEnumerator<object> // TypeDefIndex: 14321
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ExecuteFunction <>4__this; // 0x20
			public IEnumerator routine; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <InternalCoroutine>d__14(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018155A170-0x000000018155A260
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018155A260-0x000000018155A2B0
		}
	
		// Constructors
		public ExecuteFunction(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		MemberInfo IReflectedWrapper.GetMemberInfo(); // 0x0000000181252400-0x0000000181252420
		new BBParameter[] ISubParametersContainer.GetSubParameters(); // 0x0000000181251910-0x0000000181251930
		public override void OnValidate(ITaskSystem ownerSystem); // 0x0000000181542DF0-0x0000000181542EE0
		protected override string OnInit(); // 0x0000000181542CA0-0x0000000181542DE0
		protected override void OnExecute(); // 0x00000001815427B0-0x0000000181542CA0
		protected override void OnStop(); // 0x0000000181542DE0-0x0000000181542DF0
		[IteratorStateMachine] // 0x0000000180106B90-0x0000000180106BE0
		private IEnumerator InternalCoroutine(IEnumerator routine); // 0x0000000181541600-0x0000000181541670
		private void SetMethod(MethodInfo method); // 0x0000000181542EE0-0x0000000181542F20
	}
}
