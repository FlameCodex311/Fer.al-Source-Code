/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace SQLite4Unity3d
{
	public class SQLiteCommand // TypeDefIndex: 15467
	{
		// Fields
		private SQLiteConnection _conn; // 0x10
		private List<Binding> _bindings; // 0x18
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private string <CommandText>k__BackingField; // 0x20
		internal static IntPtr NegativePointer; // 0x00
	
		// Properties
		public string CommandText { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
	
		// Nested types
		private class Binding // TypeDefIndex: 15468
		{
			// Fields
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private string <Name>k__BackingField; // 0x10
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private object <Value>k__BackingField; // 0x18
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private int <Index>k__BackingField; // 0x20
	
			// Properties
			public string Name { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
			public object Value { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
			public int Index { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001803C2700-0x00000001803C2710 0x00000001804886F0-0x0000000180488700
	
			// Constructors
			public Binding(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ExecuteDeferredQuery>d__12<T> : IEnumerable<T>, IEnumerator<T> // TypeDefIndex: 15469
		{
			// Fields
			private int <>1__state;
			private T <>2__current;
			private int <>l__initialThreadId;
			public SQLiteCommand <>4__this;
			private TableMapping map;
			public TableMapping <>3__map;
			private object <>7__wrap1;
			private bool <>7__wrap2;
			private IntPtr <stmt>5__4;
			private TableMapping.Column[] <cols>5__5;
	
			// Properties
			T IEnumerator<T>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ExecuteDeferredQuery>d__12(int <>1__state);
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose();
			private bool MoveNext();
			private void <>m__Finally1();
			private void <>m__Finally2();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<T> IEnumerable<T>.GetEnumerator();
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		// Constructors
		internal SQLiteCommand(SQLiteConnection conn); // 0x0000000180E17B40-0x0000000180E17BC0
		static SQLiteCommand(); // 0x0000000180E17AE0-0x0000000180E17B40
	
		// Methods
		public int ExecuteNonQuery(); // 0x0000000180E16A80-0x0000000180E16DD0
		public IEnumerable<T> ExecuteDeferredQuery<T>();
		public List<T> ExecuteQuery<T>();
		public List<T> ExecuteQuery<T>(TableMapping map);
		protected virtual void OnInstanceCreated(object obj); // 0x00000001803581E0-0x00000001803581F0
		[IteratorStateMachine] // 0x00000001800E5310-0x00000001800E5360
		public IEnumerable<T> ExecuteDeferredQuery<T>(TableMapping map);
		public T ExecuteScalar<T>();
		public void Bind(string name, object val); // 0x0000000180E169E0-0x0000000180E16A80
		public void Bind(object val); // 0x0000000180E16940-0x0000000180E169E0
		public override string ToString(); // 0x0000000180E17860-0x0000000180E17AE0
		private IntPtr Prepare(); // 0x0000000180E16DE0-0x0000000180E16E30
		private void Finalize(IntPtr stmt); // 0x0000000180E16DD0-0x0000000180E16DE0
		private void BindAll(IntPtr stmt); // 0x0000000180E15F10-0x0000000180E16100
		internal static void BindParameter(IntPtr stmt, int index, object value, bool storeDateTimeAsTicks); // 0x0000000180E16100-0x0000000180E16940
		private object ReadCol(IntPtr stmt, int index, SQLite3.ColType type, Type clrType); // 0x0000000180E16E30-0x0000000180E17860
	}
}
