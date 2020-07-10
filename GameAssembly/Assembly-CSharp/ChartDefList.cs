/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class ChartDefList : IEnumerable<BaseDef> // TypeDefIndex: 11645
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<string> _defIDs; // 0x10
	[NonSerialized]
	private List<BaseDef> _defs; // 0x18

	// Properties
	public List<string> DefIDs { get; set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
	public List<BaseDef> Defs { get; } // 0x00000001810271E0-0x0000000181027260 
	public int Count { get; } // 0x0000000181027190-0x00000001810271E0 
	public BaseDef this[int inIndex] { get => default; } // 0x0000000181027260-0x00000001810272D0 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <GetEnumerator>d__8 : IEnumerator<BaseDef> // TypeDefIndex: 11646
	{
		// Fields
		private int <>1__state; // 0x10
		private BaseDef <>2__current; // 0x18
		public ChartDefList <>4__this; // 0x20
		private List<BaseDef> <>7__wrap1; // 0x28

		// Properties
		BaseDef IEnumerator<BaseDef>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <GetEnumerator>d__8(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x0000000181031660-0x0000000181031710
		private bool MoveNext(); // 0x00000001810314C0-0x0000000181031610
		private void <>m__Finally1(); // 0x0000000181031710-0x0000000181033D70
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181031610-0x0000000181031660
	}

	// Constructors
	public ChartDefList(); // 0x00000001810270C0-0x0000000181027120
	public ChartDefList(List<string> inDefIds); // 0x0000000181027120-0x0000000181027190

	// Methods
	public List<T> DefComponents<T>()
		where T : DefComponent;
	[IteratorStateMachine] // 0x00000001800F15A0-0x00000001800F15F0
	public IEnumerator<BaseDef> GetEnumerator(); // 0x0000000181027060-0x00000001810270C0
	IEnumerator IEnumerable.GetEnumerator(); // 0x0000000181027060-0x00000001810270C0
}

