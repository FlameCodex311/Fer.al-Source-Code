/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class CraftableItemChartData : ChartDataObject<BaseDef, CraftableItemChartData> // TypeDefIndex: 10116
{
	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <GetDefsWithComponent>d__1<T> : IEnumerable<T>, IEnumerator<T> // TypeDefIndex: 10117
		where T : DefComponent
	{
		// Fields
		private int <>1__state;
		private T <>2__current;
		private int <>l__initialThreadId;
		private List<BaseDef> <>7__wrap1;

		// Properties
		T IEnumerator<T>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <GetDefsWithComponent>d__1(int <>1__state);

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose();
		private bool MoveNext();
		private void <>m__Finally1();
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset();
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		IEnumerator IEnumerable.GetEnumerator();
	}

	// Constructors
	public CraftableItemChartData(); // 0x0000000180F3DF10-0x0000000180F3DF70

	// Methods
	protected override BaseDef CreateDef(Dictionary<string, string> inHeaderNameToDataDict); // 0x0000000180F3DEC0-0x0000000180F3DF10
	[IteratorStateMachine] // 0x000000018014D0D0-0x000000018014D120
	public static IEnumerable<T> GetDefsWithComponent<T>()
		where T : DefComponent;
}

