/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180281120-0x0000000180281180
	[Description] // 0x0000000180281120-0x0000000180281180
	public class MoveLocalPlayer : ActionTask<Transform> // TypeDefIndex: 15479
	{
		// Properties
		protected override string info { get; } // 0x0000000180BB7710-0x0000000180BB7760 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Move>d__3 : IEnumerator<object> // TypeDefIndex: 15480
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public MoveLocalPlayer <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Move>d__3(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180BC02C0-0x0000000180BC0570
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180BC0570-0x0000000180BC05C0
		}
	
		// Constructors
		public MoveLocalPlayer(); // 0x0000000180BB76D0-0x0000000180BB7710
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BB72C0-0x0000000180BB7330
		[IteratorStateMachine] // 0x0000000180281370-0x00000001802813C0
		private IEnumerator Move(); // 0x0000000180BB7260-0x0000000180BB72C0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <Move>b__3_0(); // 0x0000000180BB7330-0x0000000180BB76D0
	}
}
