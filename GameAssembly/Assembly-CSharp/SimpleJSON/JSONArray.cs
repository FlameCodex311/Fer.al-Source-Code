/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace SimpleJSON
{
	public class JSONArray : JSONNode // TypeDefIndex: 15395
	{
		// Fields
		private List<JSONNode> m_List; // 0x10
		private bool inline; // 0x18
	
		// Properties
		public override bool Inline { get; set; } // 0x000000018041BAC0-0x000000018041BAD0 0x000000018048F590-0x000000018048F5A0
		public override JSONNodeType Tag { get; } // 0x000000018042E670-0x000000018042E680 
		public override bool IsArray { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		public override JSONNode this[int aIndex] { get => default; set {} } // 0x0000000180EB6290-0x0000000180EB6390 0x0000000180EB6440-0x0000000180EB6540
		public override JSONNode this[string aKey] { get => default; set {} } // 0x0000000180EB61F0-0x0000000180EB6290 0x0000000180EB6390-0x0000000180EB6440
		public override int Count { get; } // 0x0000000180EB61B0-0x0000000180EB61F0 
		public override IEnumerable<JSONNode> Children { [IteratorStateMachine] /* 0x00000001800D28C0-0x00000001800D2910 */ get; } // 0x0000000180EB6140-0x0000000180EB61B0 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <get_Children>d__23 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 15396
		{
			// Fields
			private int <>1__state; // 0x10
			private JSONNode <>2__current; // 0x18
			private int <>l__initialThreadId; // 0x20
			public JSONArray <>4__this; // 0x28
			private List<JSONNode> <>7__wrap1; // 0x30
	
			// Properties
			JSONNode IEnumerator<SimpleJSON.JSONNode>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <get_Children>d__23(int <>1__state); // 0x000000018094DE20-0x000000018094DE50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x0000000180EC95C0-0x0000000180EC9670
			private bool MoveNext(); // 0x0000000180EC9380-0x0000000180EC94D0
			private void <>m__Finally1(); // 0x0000000180EC9670-0x0000000180EC99D0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000180EC9570-0x0000000180EC95C0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator(); // 0x0000000180EC94D0-0x0000000180EC9570
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180EC94D0-0x0000000180EC9570
		}
	
		// Constructors
		public JSONArray(); // 0x0000000180EB60C0-0x0000000180EB6140
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x0000000180EB5DA0-0x0000000180EB5E40
		public override void Add(string aKey, JSONNode aItem); // 0x0000000180EB5AB0-0x0000000180EB5B60
		public override JSONNode Remove(int aIndex); // 0x0000000180EB5EA0-0x0000000180EB5F50
		public override JSONNode Remove(JSONNode aNode); // 0x0000000180EB5E40-0x0000000180EB5EA0
		public override JSONNode Clone(); // 0x0000000180EB5B60-0x0000000180EB5DA0
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x0000000180EB5F50-0x0000000180EB60C0
	}
}
