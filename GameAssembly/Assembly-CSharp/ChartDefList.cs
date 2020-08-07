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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class ChartDefList : IEnumerable<BaseDef> // TypeDefIndex: 13170
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<string> _defIDs; // 0x10
	[NonSerialized]
	private List<BaseDef> _defs; // 0x18

	// Properties
	public List<string> DefIDs { get; set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
	public List<BaseDef> Defs { get; } // 0x000000018049FB50-0x000000018049FBD0 
	public int Count { get; } // 0x000000018049FB00-0x000000018049FB50 
	public BaseDef this[int inIndex] { get => default; } // 0x000000018049FBD0-0x000000018049FC40 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <GetEnumerator>d__8 : IEnumerator<BaseDef> // TypeDefIndex: 13171
	{
		// Fields
		private int <>1__state; // 0x10
		private BaseDef <>2__current; // 0x18
		public ChartDefList <>4__this; // 0x20
		private List<BaseDef> <>7__wrap1; // 0x28

		// Properties
		BaseDef IEnumerator<BaseDef>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <GetEnumerator>d__8(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001804A7A50-0x00000001804A7AF0
		private bool MoveNext(); // 0x00000001804A78B0-0x00000001804A7A00
		private void <>m__Finally1(); // 0x00000001804A7AF0-0x00000001804A7B30
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001804A7A00-0x00000001804A7A50
	}

	// Constructors
	public ChartDefList(); // 0x000000018049FA30-0x000000018049FA90
	public ChartDefList(List<string> inDefIds); // 0x000000018049FA90-0x000000018049FB00

	// Methods
	public List<T> DefComponents<T>()
		where T : DefComponent;
	[IteratorStateMachine] // 0x00000001802925A0-0x00000001802925F0
	public IEnumerator<BaseDef> GetEnumerator(); // 0x000000018049F9D0-0x000000018049FA30
	IEnumerator IEnumerable.GetEnumerator(); // 0x000000018049F9D0-0x000000018049FA30
}

