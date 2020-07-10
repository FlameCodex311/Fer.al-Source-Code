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
	public class JSONObject : JSONNode // TypeDefIndex: 15397
	{
		// Fields
		private Dictionary<string, JSONNode> m_Dict; // 0x10
		private bool inline; // 0x18
	
		// Properties
		public override bool Inline { get; set; } // 0x000000018041BAC0-0x000000018041BAD0 0x000000018048F590-0x000000018048F5A0
		public override JSONNodeType Tag { get; } // 0x0000000180362180-0x0000000180362190 
		public override bool IsObject { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		public override JSONNode this[string aKey] { get => default; set {} } // 0x00000001813561B0-0x0000000181356260 0x0000000181356260-0x0000000181356370
		public override JSONNode this[int aIndex] { get => default; set {} } // 0x0000000181356120-0x00000001813561B0 0x0000000181356370-0x0000000181356470
		public override int Count { get; } // 0x00000001813560D0-0x0000000181356120 
		public override IEnumerable<JSONNode> Children { [IteratorStateMachine] /* 0x00000001800D4020-0x00000001800D4070 */ get; } // 0x0000000181356060-0x00000001813560D0 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass21_0 // TypeDefIndex: 15398
		{
			// Fields
			public JSONNode aNode; // 0x10
	
			// Constructors
			public <>c__DisplayClass21_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <Remove>b__0(KeyValuePair<string, JSONNode> k); // 0x0000000181360460-0x00000001813604D0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <get_Children>d__26 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 15399
		{
			// Fields
			private int <>1__state; // 0x10
			private JSONNode <>2__current; // 0x18
			private int <>l__initialThreadId; // 0x20
			public JSONObject <>4__this; // 0x28
			private Dictionary<string, JSONNode> <>7__wrap1; // 0x30
	
			// Properties
			JSONNode IEnumerator<SimpleJSON.JSONNode>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <get_Children>d__26(int <>1__state); // 0x000000018094DE20-0x000000018094DE50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x0000000181360E90-0x0000000181360F40
			private bool MoveNext(); // 0x0000000181360C40-0x0000000181360DA0
			private void <>m__Finally1(); // 0x0000000181360F40-0x0000000181360F80
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181360E40-0x0000000181360E90
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator(); // 0x0000000181360DA0-0x0000000181360E40
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000181360DA0-0x0000000181360E40
		}
	
		// Constructors
		public JSONObject(); // 0x0000000181355FE0-0x0000000181356060
	
		// Methods
		public override Enumerator GetEnumerator(); // 0x00000001813558D0-0x0000000181355970
		public override void Add(string aKey, JSONNode aItem); // 0x0000000181355540-0x00000001813556C0
		public override JSONNode Remove(string aKey); // 0x0000000181355A50-0x0000000181355B10
		public override JSONNode Remove(int aIndex); // 0x0000000181355B10-0x0000000181355BC0
		public override JSONNode Remove(JSONNode aNode); // 0x0000000181355BC0-0x0000000181355CD0
		public override JSONNode Clone(); // 0x00000001813556C0-0x00000001813558D0
		public override bool HasKey(string aKey); // 0x00000001813559F0-0x0000000181355A50
		public override JSONNode GetValueOrDefault(string aKey, JSONNode aDefault); // 0x0000000181355970-0x00000001813559F0
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode); // 0x0000000181355CD0-0x0000000181355FE0
	}
}
