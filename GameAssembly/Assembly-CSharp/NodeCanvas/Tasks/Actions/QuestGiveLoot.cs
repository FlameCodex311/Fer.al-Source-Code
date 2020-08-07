/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018028C6E0-0x000000018028C740
	[Description] // 0x000000018028C6E0-0x000000018028C740
	public class QuestGiveLoot : NetworkActionTask // TypeDefIndex: 15531
	{
		// Fields
		public string lootName; // 0x68
		public string lootDefID; // 0x70
		public bool closeWindowToContinue; // 0x78
		private bool _itemPopupWindowOpen; // 0x79
	
		// Properties
		protected override string info { get; } // 0x000000018079EB40-0x000000018079EBA0 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <AutoClose>d__7 : IEnumerator<object> // TypeDefIndex: 15532
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public QuestGiveLoot <>4__this; // 0x20
			private float <t>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <AutoClose>d__7(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001807AACE0-0x00000001807AAEF0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001807AAEF0-0x00000001807AAF40
		}
	
		// Constructors
		public QuestGiveLoot(); // 0x000000018079E720-0x000000018079E730
	
		// Methods
		protected override void OnExecute(); // 0x000000018079E810-0x000000018079E9D0
		[IteratorStateMachine] // 0x000000018028C850-0x000000018028C8A0
		private IEnumerator AutoClose(); // 0x000000018079E7B0-0x000000018079E810
		private void OnWindowOpened(WindowOpenedMessage inMessage); // 0x000000018079EB30-0x000000018079EB40
		private void OnWindowClosed(WindowClosedMessage inMessage); // 0x000000018079E9D0-0x000000018079EB30
	}
}
