/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace SQLite4Unity3d
{
	public class SQLiteCommand // TypeDefIndex: 16306
	{
		// Fields
		private SQLiteConnection _conn; // 0x10
		private List<Binding> _bindings; // 0x18
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string <CommandText>k__BackingField; // 0x20
		internal static IntPtr NegativePointer; // 0x00
	
		// Properties
		public string CommandText { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
	
		// Nested types
		private class Binding // TypeDefIndex: 16307
		{
			// Fields
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private string <Name>k__BackingField; // 0x10
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private object <Value>k__BackingField; // 0x18
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private int <Index>k__BackingField; // 0x20
	
			// Properties
			public string Name { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
			public object Value { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
			public int Index { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803FB670-0x00000001803FB680 0x00000001804556D0-0x00000001804556E0
	
			// Constructors
			public Binding(); // 0x0000000180373240-0x0000000180373250
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ExecuteDeferredQuery>d__12<T> : IEnumerable<T>, IEnumerator<T> // TypeDefIndex: 16308
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
			T IEnumerator<T>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ExecuteDeferredQuery>d__12(int <>1__state);
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose();
			private bool MoveNext();
			private void <>m__Finally1();
			private void <>m__Finally2();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<T> IEnumerable<T>.GetEnumerator();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		// Constructors
		internal SQLiteCommand(SQLiteConnection conn); // 0x00000001807492A0-0x0000000180749320
		static SQLiteCommand(); // 0x0000000180749240-0x00000001807492A0
	
		// Methods
		public int ExecuteNonQuery(); // 0x00000001807482C0-0x0000000180748590
		public IEnumerable<T> ExecuteDeferredQuery<T>();
		public List<T> ExecuteQuery<T>();
		public List<T> ExecuteQuery<T>(TableMapping map);
		protected virtual void OnInstanceCreated(object obj); // 0x00000001803774A0-0x00000001803774B0
		[IteratorStateMachine] // 0x00000001801EB840-0x00000001801EB890
		public IEnumerable<T> ExecuteDeferredQuery<T>(TableMapping map);
		public T ExecuteScalar<T>();
		public void Bind(string name, object val); // 0x0000000180748220-0x00000001807482C0
		public void Bind(object val); // 0x0000000180748190-0x0000000180748220
		public override string ToString(); // 0x0000000180748FD0-0x0000000180749240
		private IntPtr Prepare(); // 0x00000001807485A0-0x00000001807485F0
		private void Finalize(IntPtr stmt); // 0x0000000180748590-0x00000001807485A0
		private void BindAll(IntPtr stmt); // 0x00000001807477D0-0x00000001807479B0
		internal static void BindParameter(IntPtr stmt, int index, object value, bool storeDateTimeAsTicks); // 0x00000001807479B0-0x0000000180748190
		private object ReadCol(IntPtr stmt, int index, SQLite3.ColType type, Type clrType); // 0x00000001807485F0-0x0000000180748FD0
	}
}
