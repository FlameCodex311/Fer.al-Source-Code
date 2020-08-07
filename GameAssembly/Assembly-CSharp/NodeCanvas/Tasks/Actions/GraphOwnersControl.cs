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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180274690-0x0000000180274710
	[Description] // 0x0000000180274690-0x0000000180274710
	[Name] // 0x0000000180274690-0x0000000180274710
	public class GraphOwnersControl : ActionTask // TypeDefIndex: 15438
	{
		// Fields
		public Control control; // 0x68
		public BBParameter<GraphOwner[]> GraphOwners; // 0x70
		public bool waitActionFinish; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000180BB1BB0-0x0000000180BB1C40 
	
		// Nested types
		public enum Control // TypeDefIndex: 15439
		{
			StartBehaviour = 0,
			StopBehaviour = 1,
			PauseBehaviour = 2
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <YieldDo>d__7 : IEnumerator<object> // TypeDefIndex: 15440
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public GraphOwnersControl <>4__this; // 0x20
			public GraphOwner inGO; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <YieldDo>d__7(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180BC11A0-0x0000000180BC1260
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180BC1260-0x0000000180BC12B0
		}
	
		// Constructors
		public GraphOwnersControl(); // 0x0000000180BB1BA0-0x0000000180BB1BB0
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BB1700-0x0000000180BB1B30
		[IteratorStateMachine] // 0x0000000180274A20-0x0000000180274A70
		private IEnumerator YieldDo(GraphOwner inGO); // 0x0000000180BB1B30-0x0000000180BB1BA0
		private void Do(GraphOwner inGO); // 0x0000000180BB1690-0x0000000180BB1700
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <OnExecute>b__6_0(bool s); // 0x0000000180BB1530-0x0000000180BB1540
	}
}
