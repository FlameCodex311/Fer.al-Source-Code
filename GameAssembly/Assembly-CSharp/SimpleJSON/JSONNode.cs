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
	public abstract class JSONNode // TypeDefIndex: 16042
	{
		// Fields
		public static bool forceASCII; // 0x00
		public static bool longAsString; // 0x01
		public static bool allowLineComments; // 0x02
		[ThreadStatic] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static StringBuilder m_EscapeBuilder; // 0x80000000
	
		// Properties
		public abstract JSONNodeType Tag { get; }
		public virtual JSONNode this[int aIndex] { get => default; set {} } // 0x000000018037DDC0-0x000000018037DDD0 0x00000001803774A0-0x00000001803774B0
		public virtual JSONNode this[string aKey] { get => default; set {} } // 0x000000018037DDC0-0x000000018037DDD0 0x00000001803774A0-0x00000001803774B0
		public virtual string Value { get; set; } // 0x0000000180767FE0-0x0000000180768010 0x00000001803774A0-0x00000001803774B0
		public virtual int Count { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		public virtual bool IsNumber { get; } // 0x0000000180380950-0x0000000180380960 
		public virtual bool IsString { get; } // 0x0000000180380950-0x0000000180380960 
		public virtual bool IsBoolean { get; } // 0x0000000180380950-0x0000000180380960 
		public virtual bool IsNull { get; } // 0x0000000180380950-0x0000000180380960 
		public virtual bool IsArray { get; } // 0x0000000180380950-0x0000000180380960 
		public virtual bool IsObject { get; } // 0x0000000180380950-0x0000000180380960 
		public virtual bool Inline { get; set; } // 0x0000000180380950-0x0000000180380960 0x00000001803774A0-0x00000001803774B0
		public virtual IEnumerable<JSONNode> Children { [IteratorStateMachine] /* 0x0000000180284A40-0x0000000180284A90 */ get; } // 0x0000000180767D80-0x0000000180767DE0 
		public IEnumerable<JSONNode> DeepChildren { [IteratorStateMachine] /* 0x0000000180284CF0-0x0000000180284D40 */ get; } // 0x0000000180767DE0-0x0000000180767E50 
		public IEnumerable<KeyValuePair<string, JSONNode>> Linq { get; } // 0x0000000180767F80-0x0000000180767FE0 
		public KeyEnumerator Keys { get; } // 0x0000000180767F30-0x0000000180767F80 
		public ValueEnumerator Values { get; } // 0x0000000180767F30-0x0000000180767F80 
		public virtual double AsDouble { get; set; } // 0x0000000180767BA0-0x0000000180767C80 0x0000000180768A10-0x0000000180768A90
		public virtual int AsInt { get; set; } // 0x0000000180767CA0-0x0000000180767CC0 0x0000000180768AB0-0x0000000180768AD0
		public virtual float AsFloat { get; set; } // 0x0000000180767C80-0x0000000180767CA0 0x0000000180768A90-0x0000000180768AB0
		public virtual bool AsBool { get; set; } // 0x0000000180767AE0-0x0000000180767BA0 0x00000001807689A0-0x0000000180768A10
		public virtual long AsLong { get; set; } // 0x0000000180767CC0-0x0000000180767D10 0x0000000180768AD0-0x0000000180768B10
		public virtual JSONArray AsArray { get; } // 0x0000000180767A70-0x0000000180767AE0 
		public virtual JSONObject AsObject { get; } // 0x0000000180767D10-0x0000000180767D80 
		internal static StringBuilder EscapeBuilder { get; } // 0x0000000180767E50-0x0000000180767F30 
	
		// Nested types
		public struct Enumerator // TypeDefIndex: 16043
		{
			// Fields
			private Type type; // 0x00
			private Dictionary<string, JSONNode> m_Object; // 0x08
			private List<JSONNode> m_Array; // 0x30
	
			// Properties
			public bool IsValid { get; } // 0x000000018001AE60-0x000000018001AE90 
			public KeyValuePair<string, JSONNode> Current { get; } // 0x000000018001AE40-0x000000018001AE60 
	
			// Nested types
			private enum Type // TypeDefIndex: 16044
			{
				None = 0,
				Array = 1,
				Object = 2
			}
	
			// Constructors
			public Enumerator(List<JSONNode> aArrayEnum); // 0x000000018001ADE0-0x000000018001AE10
			public Enumerator(Dictionary<string, JSONNode> aDictEnum); // 0x000000018001AE10-0x000000018001AE40
	
			// Methods
			public bool MoveNext(); // 0x000000018001AD70-0x000000018001ADE0
		}
	
		public struct ValueEnumerator // TypeDefIndex: 16045
		{
			// Fields
			private Enumerator m_Enumerator; // 0x00
	
			// Properties
			public JSONNode Current { get; } // 0x000000018001B410-0x000000018001B550 
	
			// Constructors
			public ValueEnumerator(List<JSONNode> aArrayEnum); // 0x000000018001AF30-0x000000018001AF90
			public ValueEnumerator(Dictionary<string, JSONNode> aDictEnum); // 0x000000018001AEC0-0x000000018001AF30
			public ValueEnumerator(Enumerator aEnumerator); // 0x000000018001AF90-0x000000018001AFC0
	
			// Methods
			public bool MoveNext(); // 0x000000018001AD70-0x000000018001ADE0
			public ValueEnumerator GetEnumerator(); // 0x000000018001AE90-0x000000018001AEC0
		}
	
		public struct KeyEnumerator // TypeDefIndex: 16046
		{
			// Fields
			private Enumerator m_Enumerator; // 0x00
	
			// Properties
			public string Current { get; } // 0x000000018001AFC0-0x000000018001B080 
	
			// Constructors
			public KeyEnumerator(List<JSONNode> aArrayEnum); // 0x000000018001AF30-0x000000018001AF90
			public KeyEnumerator(Dictionary<string, JSONNode> aDictEnum); // 0x000000018001AEC0-0x000000018001AF30
			public KeyEnumerator(Enumerator aEnumerator); // 0x000000018001AF90-0x000000018001AFC0
	
			// Methods
			public bool MoveNext(); // 0x000000018001AD70-0x000000018001ADE0
			public KeyEnumerator GetEnumerator(); // 0x000000018001AE90-0x000000018001AEC0
		}
	
		public class LinqEnumerator : IEnumerator<KeyValuePair<string, JSONNode>>, IEnumerable<KeyValuePair<string, JSONNode>> // TypeDefIndex: 16047
		{
			// Fields
			private JSONNode m_Node; // 0x10
			private Enumerator m_Enumerator; // 0x18
	
			// Properties
			public KeyValuePair<string, JSONNode> Current { get; } // 0x000000018076AB20-0x000000018076ABC0 
			object IEnumerator.Current { get; } // 0x000000018076A960-0x000000018076AA10 
	
			// Constructors
			internal LinqEnumerator(JSONNode aNode); // 0x000000018076AA10-0x000000018076AB20
	
			// Methods
			public bool MoveNext(); // 0x000000018076A790-0x000000018076A800
			public void Dispose(); // 0x000000018076A700-0x000000018076A730
			public IEnumerator<KeyValuePair<string, JSONNode>> GetEnumerator(); // 0x000000018076A730-0x000000018076A790
			public void Reset(); // 0x000000018076A800-0x000000018076A900
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018076A900-0x000000018076A960
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <get_Children>d__42 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 16048
		{
			// Fields
			private int <>1__state; // 0x10
			private JSONNode <>2__current; // 0x18
			private int <>l__initialThreadId; // 0x20
	
			// Properties
			JSONNode IEnumerator<SimpleJSON.JSONNode>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <get_Children>d__42(int <>1__state); // 0x00000001806301B0-0x00000001806301E0
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001803C5AF0-0x00000001803C5B00
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001807784F0-0x0000000180778540
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator(); // 0x0000000180778460-0x00000001807784F0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180778460-0x00000001807784F0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <get_DeepChildren>d__44 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 16049
		{
			// Fields
			private int <>1__state; // 0x10
			private JSONNode <>2__current; // 0x18
			private int <>l__initialThreadId; // 0x20
			public JSONNode <>4__this; // 0x28
			private IEnumerator<JSONNode> <>7__wrap1; // 0x30
			private IEnumerator<JSONNode> <>7__wrap2; // 0x38
	
			// Properties
			JSONNode IEnumerator<SimpleJSON.JSONNode>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <get_DeepChildren>d__44(int <>1__state); // 0x00000001806301B0-0x00000001806301E0
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001807788B0-0x00000001807789B0
			private bool MoveNext(); // 0x0000000180778540-0x00000001807787C0
			private void <>m__Finally1(); // 0x00000001807789B0-0x0000000180778A00
			private void <>m__Finally2(); // 0x0000000180778A00-0x0000000180778A50
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180778860-0x00000001807788B0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator(); // 0x00000001807787C0-0x0000000180778860
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001807787C0-0x0000000180778860
		}
	
		// Constructors
		protected JSONNode(); // 0x0000000180373240-0x0000000180373250
		static JSONNode(); // 0x0000000180767A10-0x0000000180767A70
	
		// Methods
		public virtual void Add(string aKey, JSONNode aItem); // 0x00000001803774A0-0x00000001803774B0
		public virtual void Add(JSONNode aItem); // 0x00000001807667F0-0x0000000180766850
		public virtual JSONNode Remove(string aKey); // 0x000000018037DDC0-0x000000018037DDD0
		public virtual JSONNode Remove(int aIndex); // 0x000000018037DDC0-0x000000018037DDD0
		public virtual JSONNode Remove(JSONNode aNode); // 0x00000001804EC160-0x00000001804EC170
		public virtual JSONNode Clone(); // 0x000000018037DDC0-0x000000018037DDD0
		public virtual bool HasKey(string aKey); // 0x0000000180380950-0x0000000180380960
		public virtual JSONNode GetValueOrDefault(string aKey, JSONNode aDefault); // 0x0000000180766BD0-0x0000000180766BE0
		public override string ToString(); // 0x00000001807678D0-0x0000000180767970
		public virtual string ToString(int aIndent); // 0x0000000180767970-0x0000000180767A10
		internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);
		public abstract Enumerator GetEnumerator();
		public static implicit operator JSONNode(string s); // 0x00000001807685B0-0x0000000180768640
		public static implicit operator string(JSONNode d); // 0x00000001807686C0-0x0000000180768740
		public static implicit operator JSONNode(double n); // 0x0000000180768300-0x0000000180768390
		public static implicit operator double(JSONNode d); // 0x0000000180768640-0x00000001807686C0
		public static implicit operator JSONNode(float n); // 0x00000001807687D0-0x0000000180768870
		public static implicit operator float(JSONNode d); // 0x00000001807684B0-0x0000000180768530
		public static implicit operator JSONNode(int n); // 0x0000000180768390-0x0000000180768430
		public static implicit operator int(JSONNode d); // 0x0000000180768870-0x00000001807688F0
		public static implicit operator JSONNode(long n); // 0x00000001807681B0-0x0000000180768300
		public static implicit operator long(JSONNode d); // 0x0000000180768530-0x00000001807685B0
		public static implicit operator JSONNode(bool b); // 0x0000000180768740-0x00000001807687D0
		public static implicit operator bool(JSONNode d); // 0x0000000180768430-0x00000001807684B0
		public static implicit operator JSONNode(KeyValuePair<string, JSONNode> aKeyValue); // 0x00000001807688F0-0x0000000180768930
		public static bool operator ==(JSONNode a, object b); // 0x0000000180768010-0x00000001807681B0
		public static bool operator !=(JSONNode a, object b); // 0x0000000180768930-0x00000001807689A0
		public override bool Equals(object obj); // 0x0000000180766850-0x0000000180766860
		public override int GetHashCode(); // 0x0000000180766BC0-0x0000000180766BD0
		internal static string Escape(string aText); // 0x0000000180766860-0x0000000180766BC0
		private static JSONNode ParseElement(string token, bool quoted); // 0x0000000180766BE0-0x0000000180766EC0
		public static JSONNode Parse(string aJSON); // 0x0000000180766EC0-0x00000001807678D0
	}
}
