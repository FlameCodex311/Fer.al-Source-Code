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
	[Category] // 0x00000001802721D0-0x0000000180272250
	[Description] // 0x00000001802721D0-0x0000000180272250
	[Name] // 0x00000001802721D0-0x0000000180272250
	public class GraphOwnerControl : ActionTask<GraphOwner> // TypeDefIndex: 15435
	{
		// Fields
		public Control control; // 0x68
		public bool waitActionFinish; // 0x6C
	
		// Properties
		protected override string info { get; } // 0x0000000180BB15E0-0x0000000180BB1690 
	
		// Nested types
		public enum Control // TypeDefIndex: 15436
		{
			StartBehaviour = 0,
			StopBehaviour = 1,
			PauseBehaviour = 2
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <YieldDo>d__6 : IEnumerator<object> // TypeDefIndex: 15437
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public GraphOwnerControl <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <YieldDo>d__6(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180BC1100-0x0000000180BC1150
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180BC1150-0x0000000180BC11A0
		}
	
		// Constructors
		public GraphOwnerControl(); // 0x0000000180BB15A0-0x0000000180BB15E0
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BB1330-0x0000000180BB14C0
		[IteratorStateMachine] // 0x00000001802727D0-0x0000000180272820
		private IEnumerator YieldDo(); // 0x0000000180BB1540-0x0000000180BB15A0
		private void Do(); // 0x0000000180BB1280-0x0000000180BB1330
		protected override void OnStop(); // 0x0000000180BB14C0-0x0000000180BB1530
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <OnExecute>b__5_0(bool s); // 0x0000000180BB1530-0x0000000180BB1540
	}
}
