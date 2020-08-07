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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace SimpleJSON
{
	public class JSONArray : JSONNode // TypeDefIndex: 16050
	{
		// Fields
		private List<JSONNode> m_List; // 0x10
		private bool inline; // 0x18
	
		// Properties
		public override bool Inline { get; set; } // 0x00000001803F6D30-0x00000001803F6D40 0x00000001803F6D40-0x00000001803F6D50
		public override JSONNodeType Tag { get; } // 0x000000018058C710-0x000000018058C720 
		public override bool IsArray { get; } // 0x0000000180380B60-0x0000000180380B70 
		public override JSONNode this[int aIndex] { get => default; set {} } // 0x0000000180765420-0x0000000180765520 0x00000001807655D0-0x00000001807656D0
		public override JSONNode this[string aKey] { get => default; set {} } // 0x0000000180765380-0x0000000180765420 0x0000000180765520-0x00000001807655D0
		public override int Count { get; } // 0x0000000180765340-0x0000000180765380 
		public override IEnumerable<JSONNode> Children { [IteratorStateMachine] /* 0x0000000180288AC0-0x0000000180288B10 */ get; } // 0x00000001807652D0-0x0000000180765340 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <get_Children>d__23 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 16051
		{
			// Fields
			private int <>1__state; // 0x10
			private JSONNode <>2__current; // 0x18
			private int <>l__initialThreadId; // 0x20
			public JSONArray <>4__this; // 0x28
			private List<JSONNode> <>7__wrap1; // 0x30
	
			// Properties
			JSONNode IEnumerator<SimpleJSON.JSONNode>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <get_Children>d__23(int <>1__state); // 0x00000001806301B0-0x00000001806301E0
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x0000000180778060-0x0000000180778100
			private bool MoveNext(); // 0x0000000180777E30-0x0000000180777F70
			private void <>m__Finally1(); // 0x0000000180778100-0x0000000180778140
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180778010-0x0000000180778060
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator(); // 0x0000000180777F70-0x0000000180778010
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180777F70-0x0000000180778010
		}
	
		// Constructors
		public JSONArray(); // 0x0000000180765250-0x00000001807652D0
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x0000000180764F40-0x0000000180764FD0
		public override void Add(string aKey, JSONNode aItem); // 0x0000000180764C60-0x0000000180764D10
		public override JSONNode Remove(int aIndex); // 0x0000000180765030-0x00000001807650E0
		public override JSONNode Remove(JSONNode aNode); // 0x0000000180764FD0-0x0000000180765030
		public override JSONNode Clone(); // 0x0000000180764D10-0x0000000180764F40
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x00000001807650E0-0x0000000180765250
	}
}
