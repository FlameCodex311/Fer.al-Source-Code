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
	public class JSONObject : JSONNode // TypeDefIndex: 16052
	{
		// Fields
		private Dictionary<string, JSONNode> m_Dict; // 0x10
		private bool inline; // 0x18
	
		// Properties
		public override bool Inline { get; set; } // 0x00000001803F6D30-0x00000001803F6D40 0x00000001803F6D40-0x00000001803F6D50
		public override JSONNodeType Tag { get; } // 0x0000000180411150-0x0000000180411160 
		public override bool IsObject { get; } // 0x0000000180380B60-0x0000000180380B70 
		public override JSONNode this[string aKey] { get => default; set {} } // 0x000000018076A0E0-0x000000018076A190 0x000000018076A190-0x000000018076A2A0
		public override JSONNode this[int aIndex] { get => default; set {} } // 0x000000018076A050-0x000000018076A0E0 0x000000018076A2A0-0x000000018076A3A0
		public override int Count { get; } // 0x000000018076A000-0x000000018076A050 
		public override IEnumerable<JSONNode> Children { [IteratorStateMachine] /* 0x0000000180289890-0x00000001802898E0 */ get; } // 0x0000000180769F90-0x000000018076A000 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass21_0 // TypeDefIndex: 16053
		{
			// Fields
			public JSONNode aNode; // 0x10
	
			// Constructors
			public <>c__DisplayClass21_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <Remove>b__0(KeyValuePair<string, JSONNode> k); // 0x0000000180777510-0x0000000180777580
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <get_Children>d__26 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 16054
		{
			// Fields
			private int <>1__state; // 0x10
			private JSONNode <>2__current; // 0x18
			private int <>l__initialThreadId; // 0x20
			public JSONObject <>4__this; // 0x28
			private Dictionary<string, JSONNode> <>7__wrap1; // 0x30
	
			// Properties
			JSONNode IEnumerator<SimpleJSON.JSONNode>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <get_Children>d__26(int <>1__state); // 0x00000001806301B0-0x00000001806301E0
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x0000000180778380-0x0000000180778420
			private bool MoveNext(); // 0x0000000180778140-0x0000000180778290
			private void <>m__Finally1(); // 0x0000000180778420-0x0000000180778460
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180778330-0x0000000180778380
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator(); // 0x0000000180778290-0x0000000180778330
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180778290-0x0000000180778330
		}
	
		// Constructors
		public JSONObject(); // 0x0000000180769F10-0x0000000180769F90
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x0000000180769810-0x00000001807698B0
		public override void Add(string aKey, JSONNode aItem); // 0x00000001807694D0-0x0000000180769650
		public override JSONNode Remove(string aKey); // 0x0000000180769990-0x0000000180769A50
		public override JSONNode Remove(int aIndex); // 0x0000000180769A50-0x0000000180769B00
		public override JSONNode Remove(JSONNode aNode); // 0x0000000180769B00-0x0000000180769C10
		public override JSONNode Clone(); // 0x0000000180769650-0x0000000180769810
		public override bool HasKey(string aKey); // 0x0000000180769930-0x0000000180769990
		public override JSONNode GetValueOrDefault(string aKey, JSONNode aDefault); // 0x00000001807698B0-0x0000000180769930
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x0000000180769C10-0x0000000180769F10
	}
}
