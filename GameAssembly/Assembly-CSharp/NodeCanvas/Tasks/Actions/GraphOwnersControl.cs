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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018010B0B0-0x000000018010B130
	[Description] // 0x000000018010B0B0-0x000000018010B130
	[Name] // 0x000000018010B0B0-0x000000018010B130
	public class GraphOwnersControl : ActionTask // TypeDefIndex: 14335
	{
		// Fields
		public Control control; // 0x68
		public BBParameter<GraphOwner[]> GraphOwners; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018154BBF0-0x000000018154BC90 
	
		// Nested types
		public enum Control // TypeDefIndex: 14336
		{
			StartBehaviour = 0,
			StopBehaviour = 1,
			PauseBehaviour = 2
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <YieldDo>d__6 : IEnumerator<object> // TypeDefIndex: 14337
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public GraphOwnersControl <>4__this; // 0x20
			public GraphOwner inGO; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <YieldDo>d__6(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018155C8C0-0x000000018155C980
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018155C980-0x000000018155C9D0
		}
	
		// Constructors
		public GraphOwnersControl(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x000000018154B7C0-0x000000018154BB80
		[IteratorStateMachine] // 0x000000018010B300-0x000000018010B350
		private IEnumerator YieldDo(GraphOwner inGO); // 0x000000018154BB80-0x000000018154BBF0
		private void Do(GraphOwner inGO); // 0x000000018154B750-0x000000018154B7C0
	}
}
