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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001801048F0-0x0000000180104970
	[Description] // 0x00000001801048F0-0x0000000180104970
	[Name] // 0x00000001801048F0-0x0000000180104970
	public class ExecuteFunction_Multiplatform : ActionTask // TypeDefIndex: 14313
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected SerializedMethodInfo method; // 0x68
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected List<BBObjectParameter> parameters; // 0x70
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected List<bool> parameterIsByRef; // 0x78
		[BlackboardOnly] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		protected BBObjectParameter returnValue; // 0x80
		private object[] args; // 0x88
		private bool routineRunning; // 0x90
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x0000000181251900-0x0000000181251910 
		public override Type agentType { get; } // 0x00000001815421D0-0x00000001815422D0 
		protected override string info { get; } // 0x00000001815422D0-0x00000001815427B0 
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 14314
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<BBObjectParameter, bool> <>9__13_0; // 0x08
	
			// Constructors
			static <>c(); // 0x000000018155C7B0-0x000000018155C810
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <OnInit>b__13_0(BBObjectParameter p); // 0x00000001803C28F0-0x00000001803C2900
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <InternalCoroutine>d__16 : IEnumerator<object> // TypeDefIndex: 14315
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ExecuteFunction_Multiplatform <>4__this; // 0x20
			public IEnumerator routine; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <InternalCoroutine>d__16(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018155A2B0-0x000000018155A3C0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018155A3C0-0x000000018155A410
		}
	
		// Constructors
		public ExecuteFunction_Multiplatform(); // 0x0000000181542150-0x00000001815421D0
	
		// Methods
		public override void OnValidate(ITaskSystem ownerSystem); // 0x0000000181541CE0-0x0000000181541DB0
		protected override string OnInit(); // 0x0000000181541AF0-0x0000000181541CD0
		protected override void OnExecute(); // 0x00000001815416E0-0x0000000181541AF0
		protected override void OnStop(); // 0x0000000181541CD0-0x0000000181541CE0
		[IteratorStateMachine] // 0x0000000180104F40-0x0000000180104F90
		private IEnumerator InternalCoroutine(IEnumerator routine); // 0x0000000181541670-0x00000001815416E0
		private void SetMethod(MethodInfo method); // 0x0000000181541DB0-0x0000000181542150
	}
}
