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
	[Category] // 0x0000000180108F30-0x0000000180108FB0
	[Description] // 0x0000000180108F30-0x0000000180108FB0
	[Name] // 0x0000000180108F30-0x0000000180108FB0
	public class GraphOwnerControl : ActionTask<GraphOwner> // TypeDefIndex: 14332
	{
		// Fields
		public Control control; // 0x68
		public bool waitActionFinish; // 0x6C
	
		// Properties
		protected override string info { get; } // 0x000000018154B6A0-0x000000018154B750 
	
		// Nested types
		public enum Control // TypeDefIndex: 14333
		{
			StartBehaviour = 0,
			StopBehaviour = 1,
			PauseBehaviour = 2
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <YieldDo>d__6 : IEnumerator<object> // TypeDefIndex: 14334
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public GraphOwnerControl <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <YieldDo>d__6(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018155C870-0x000000018155C8C0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018155C9D0-0x000000018155CA20
		}
	
		// Constructors
		public GraphOwnerControl(); // 0x000000018154B660-0x000000018154B6A0
	
		// Methods
		protected override void OnExecute(); // 0x000000018154B3E0-0x000000018154B580
		[IteratorStateMachine] // 0x000000018010A4F0-0x000000018010A540
		private IEnumerator YieldDo(); // 0x000000018154B600-0x000000018154B660
		private void Do(); // 0x000000018154B340-0x000000018154B3E0
		protected override void OnStop(); // 0x000000018154B580-0x000000018154B5F0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <OnExecute>b__5_0(bool s); // 0x000000018154B5F0-0x000000018154B600
	}
}
