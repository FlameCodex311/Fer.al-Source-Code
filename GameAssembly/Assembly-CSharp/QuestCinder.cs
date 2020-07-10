/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class QuestCinder : ManagedBehaviour // TypeDefIndex: 11687
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
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Init>d__9 : IEnumerator<object> // TypeDefIndex: 11688
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QuestCinder <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Init>d__9(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001810160C0-0x00000001810164C0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001810164C0-0x0000000181016510
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <PlayElectricHandFX>d__13 : IEnumerator<object> // TypeDefIndex: 11689
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public QuestCinder <>4__this; // 0x20
		public bool inPlay; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <PlayElectricHandFX>d__13(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181017170-0x00000001810173C0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001810173C0-0x0000000181018810
	}

	// Constructors
	public QuestCinder(); // 0x0000000181005320-0x00000001810053A0

	// Methods
	public override void MAwake(); // 0x00000001810051E0-0x00000001810052B0
	[IteratorStateMachine] // 0x00000001800FECB0-0x00000001800FED00
	private IEnumerator Init(); // 0x0000000181005180-0x00000001810051E0
	[IteratorStateMachine] // 0x00000001800FEF10-0x00000001800FEF60
	internal IEnumerator PlayElectricHandFX(bool inPlay); // 0x00000001810052B0-0x0000000181005320
}

