/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018011E710-0x000000018011E770
	[Description] // 0x000000018011E710-0x000000018011E770
	public class QuestGiveLoot : NetworkActionTask // TypeDefIndex: 14426
	{
		// Fields
		public string lootName; // 0x68
		public string lootDefID; // 0x70
		public bool closeWindowToContinue; // 0x78
		private bool _itemPopupWindowOpen; // 0x79
	
		// Properties
		protected override string info { get; } // 0x00000001815598B0-0x0000000181559910 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <AutoClose>d__7 : IEnumerator<object> // TypeDefIndex: 14427
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public QuestGiveLoot <>4__this; // 0x20
			private float <t>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <AutoClose>d__7(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181559DE0-0x0000000181559FF0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181559FF0-0x000000018155A040
		}
	
		// Constructors
		public QuestGiveLoot(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x0000000181559560-0x0000000181559730
		[IteratorStateMachine] // 0x000000018011EA20-0x000000018011EA70
		private IEnumerator AutoClose(); // 0x0000000181559500-0x0000000181559560
		private void OnWindowOpened(WindowOpenedMessage inMessage); // 0x00000001815598A0-0x00000001815598B0
		private void OnWindowClosed(WindowClosedMessage inMessage); // 0x0000000181559730-0x00000001815598A0
	}
}
