/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class QuestCinder : ManagedBehaviour // TypeDefIndex: 13214
{
	// Fields
	public Animator animator; // 0x50
	public ActorBase actorBase; // 0x58
	public Electric electricLeft; // 0x60
	public Electric electricRight; // 0x68
	public string attachPointLeft; // 0x70
	public string attachPointRight; // 0x78
	private Electric _electricLeft; // 0x80
	private Electric _electricRight; // 0x88
	private bool _electricHandsSetup; // 0x90
	public float electricHandsStartDelay; // 0x94
	public float electricHandsBetweenDelay; // 0x98

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Init>d__9 : IEnumerator<object> // TypeDefIndex: 13215
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QuestCinder <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Init>d__9(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180659670-0x0000000180659A60
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180659A60-0x0000000180659AB0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <PlayElectricHandFX>d__13 : IEnumerator<object> // TypeDefIndex: 13216
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QuestCinder <>4__this; // 0x20
		public bool inPlay; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <PlayElectricHandFX>d__13(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018065AA80-0x000000018065ACC0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018065ACC0-0x000000018065B350
	}

	// Constructors
	public QuestCinder(); // 0x0000000180648FA0-0x0000000180649020

	// Methods
	public override void MAwake(); // 0x0000000180648E60-0x0000000180648F30
	[IteratorStateMachine] // 0x00000001801D8970-0x00000001801D89C0
	private IEnumerator Init(); // 0x0000000180648E00-0x0000000180648E60
	[IteratorStateMachine] // 0x00000001801D8BC0-0x00000001801D8C10
	internal IEnumerator PlayElectricHandFX(bool inPlay); // 0x0000000180648F30-0x0000000180648FA0
}

