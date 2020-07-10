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
	public abstract class JSONNode // TypeDefIndex: 15387
	{
		// Fields
		public static bool forceASCII; // 0x00
		public static bool longAsString; // 0x01
		public static bool allowLineComments; // 0x02
		[ThreadStatic] // 0x00000001800B36B0-0x00000001800B36C0
		private static StringBuilder m_EscapeBuilder; // 0x80000000
	
		// Properties
		public abstract JSONNodeType Tag { get; }
		public virtual JSONNode this[int aIndex] { get => default; set {} } // 0x000000018035FCC0-0x000000018035FCD0 0x00000001803581E0-0x00000001803581F0
		public virtual JSONNode this[string aKey] { get => default; set {} } // 0x000000018035FCC0-0x000000018035FCD0 0x00000001803581E0-0x00000001803581F0
		public virtual string Value { get; set; } // 0x0000000180EB8C20-0x0000000180EB8C50 0x00000001803581E0-0x00000001803581F0
		public virtual int Count { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		public virtual bool IsNumber { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public virtual bool IsString { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public virtual bool IsBoolean { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public virtual bool IsNull { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public virtual bool IsArray { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public virtual bool IsObject { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public virtual bool Inline { get; set; } // 0x00000001803C28F0-0x00000001803C2900 0x00000001803581E0-0x00000001803581F0
		public virtual IEnumerable<JSONNode> Children { [IteratorStateMachine] /* 0x00000001800CFAC0-0x00000001800CFB10 */ get; } // 0x0000000180EB89D0-0x0000000180EB8A20 
		public IEnumerable<JSONNode> DeepChildren { [IteratorStateMachine] /* 0x00000001800D0040-0x00000001800D0090 */ get; } // 0x0000000180EB8A20-0x0000000180EB8A90 
		public IEnumerable<KeyValuePair<string, JSONNode>> Linq { get; } // 0x0000000180EB8BC0-0x0000000180EB8C20 
		public KeyEnumerator Keys { get; } // 0x0000000180EB8B70-0x0000000180EB8BC0 
		public ValueEnumerator Values { get; } // 0x0000000180EB8B70-0x0000000180EB8BC0 
		public virtual double AsDouble { get; set; } // 0x0000000180EB87F0-0x0000000180EB88D0 0x0000000180EB9570-0x0000000180EB95F0
		public virtual int AsInt { get; set; } // 0x0000000180EB88F0-0x0000000180EB8910 0x0000000180EB9610-0x0000000180EB9630
		public virtual float AsFloat { get; set; } // 0x0000000180EB88D0-0x0000000180EB88F0 0x0000000180EB95F0-0x0000000180EB9610
		public virtual bool AsBool { get; set; } // 0x0000000180EB8730-0x0000000180EB87F0 0x0000000180EB9500-0x0000000180EB9570
		public virtual long AsLong { get; set; } // 0x0000000180EB8910-0x0000000180EB8960 0x0000000180EB9630-0x0000000180EB9670
		public virtual JSONArray AsArray { get; } // 0x0000000180EB86C0-0x0000000180EB8730 
		public virtual JSONObject AsObject { get; } // 0x0000000180EB8960-0x0000000180EB89D0 
		internal static StringBuilder EscapeBuilder { get; } // 0x0000000180EB8A90-0x0000000180EB8B70 
	
		// Nested types
		public struct Enumerator // TypeDefIndex: 15388
		{
			// Fields
			private Type type; // 0x00
			private Dictionary<string, JSONNode> m_Object; // 0x08
			private List<JSONNode> m_Array; // 0x30
	
			// Properties
			public bool IsValid { get; } // 0x000000018000CB40-0x000000018000CB50 
			public KeyValuePair<string, JSONNode> Current { get; } // 0x00000001802131D0-0x0000000180213210 
	
			// Nested types
			private enum Type // TypeDefIndex: 15389
			{
				None = 0,
				Array = 1,
				Object = 2
			}
	
			// Constructors
			public Enumerator(List<JSONNode> aArrayEnum); // 0x0000000180213170-0x00000001802131A0
			public Enumerator(Dictionary<string, JSONNode> aDictEnum); // 0x00000001802131A0-0x00000001802131D0
	
			// Methods
			public bool MoveNext(); // 0x0000000180213100-0x0000000180213170
		}
	
		public struct ValueEnumerator // TypeDefIndex: 15390
		{
			// Fields
			private Enumerator m_Enumerator; // 0x00
	
			// Properties
			public JSONNode Current { get; } // 0x0000000180213460-0x0000000180213520 
	
			// Constructors
			public ValueEnumerator(List<JSONNode> aArrayEnum); // 0x00000001802132B0-0x0000000180213310
			public ValueEnumerator(Dictionary<string, JSONNode> aDictEnum); // 0x0000000180213240-0x00000001802132B0
			public ValueEnumerator(Enumerator aEnumerator); // 0x000000018002C310-0x000000018002C3A0
	
			// Methods
			public bool MoveNext(); // 0x0000000180213100-0x0000000180213170
			public ValueEnumerator GetEnumerator(); // 0x0000000180213210-0x0000000180213240
		}
	
		public struct KeyEnumerator // TypeDefIndex: 15391
		{
			// Fields
			private Enumerator m_Enumerator; // 0x00
	
			// Properties
			public string Current { get; } // 0x0000000180213310-0x00000001802133F0 
	
			// Constructors
			public KeyEnumerator(List<JSONNode> aArrayEnum); // 0x00000001802132B0-0x0000000180213310
			public KeyEnumerator(Dictionary<string, JSONNode> aDictEnum); // 0x0000000180213240-0x00000001802132B0
			public KeyEnumerator(Enumerator aEnumerator); // 0x000000018002C310-0x000000018002C3A0
	
			// Methods
			public bool MoveNext(); // 0x0000000180213100-0x0000000180213170
			public KeyEnumerator GetEnumerator(); // 0x0000000180213210-0x0000000180213240
		}
	
		public class LinqEnumerator : IEnumerator<KeyValuePair<string, JSONNode>>, IEnumerable<KeyValuePair<string, JSONNode>> // TypeDefIndex: 15392
		{
			// Fields
			private JSONNode m_Node; // 0x10
			private Enumerator m_Enumerator; // 0x18
	
			// Properties
			public KeyValuePair<string, JSONNode> Current { get; } // 0x0000000181356AF0-0x0000000181356B90 
			object IEnumerator.Current { get; } // 0x0000000181356970-0x0000000181356A20 
	
			// Constructors
			internal LinqEnumerator(JSONNode aNode); // 0x0000000181356A20-0x0000000181356AF0
	
			// Methods
			public bool MoveNext(); // 0x00000001813567E0-0x0000000181356850
			public void Dispose(); // 0x0000000181356750-0x0000000181356780
			public IEnumerator<KeyValuePair<string, JSONNode>> GetEnumerator(); // 0x0000000181356780-0x00000001813567E0
			public void Reset(); // 0x0000000181356850-0x0000000181356910
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000181356910-0x0000000181356970
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <get_Children>d__42 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 15393
		{
			// Fields
			private int <>1__state; // 0x10
			private JSONNode <>2__current; // 0x18
			private int <>l__initialThreadId; // 0x20
	
			// Properties
			JSONNode IEnumerator<SimpleJSON.JSONNode>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <get_Children>d__42(int <>1__state); // 0x000000018094DE20-0x000000018094DE50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000180EE0630-0x0000000180EE0640
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181361010-0x0000000181361060
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator(); // 0x0000000181360F80-0x0000000181361010
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x0000000181360F80-0x0000000181361010
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <get_DeepChildren>d__44 : IEnumerable<JSONNode>, IEnumerator<JSONNode> // TypeDefIndex: 15394
		{
			// Fields
			private int <>1__state; // 0x10
			private JSONNode <>2__current; // 0x18
			private int <>l__initialThreadId; // 0x20
			public JSONNode <>4__this; // 0x28
			private IEnumerator<JSONNode> <>7__wrap1; // 0x30
			private IEnumerator<JSONNode> <>7__wrap2; // 0x38
	
			// Properties
			JSONNode IEnumerator<SimpleJSON.JSONNode>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <get_DeepChildren>d__44(int <>1__state); // 0x000000018094DE20-0x000000018094DE50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001813613A0-0x00000001813614B0
			private bool MoveNext(); // 0x0000000181361060-0x00000001813612B0
			private void <>m__Finally1(); // 0x00000001813614B0-0x0000000181361500
			private void <>m__Finally2(); // 0x0000000181361500-0x0000000181361550
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181361350-0x00000001813613A0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<JSONNode> IEnumerable<JSONNode>.GetEnumerator(); // 0x00000001813612B0-0x0000000181361350
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001813612B0-0x0000000181361350
		}
	
		// Constructors
		protected JSONNode(); // 0x000000018036B6C0-0x000000018036B6D0
		static JSONNode(); // 0x0000000180EB8660-0x0000000180EB86C0
	
		// Methods
		public virtual void Add(string aKey, JSONNode aItem); // 0x00000001803581E0-0x00000001803581F0
		public virtual void Add(JSONNode aItem); // 0x0000000180EB7400-0x0000000180EB7460
		public virtual JSONNode Remove(string aKey); // 0x000000018035FCC0-0x000000018035FCD0
		public virtual JSONNode Remove(int aIndex); // 0x000000018035FCC0-0x000000018035FCD0
		public virtual JSONNode Remove(JSONNode aNode); // 0x00000001804DE840-0x00000001804DE850
		public virtual JSONNode Clone(); // 0x000000018035FCC0-0x000000018035FCD0
		public virtual bool HasKey(string aKey); // 0x00000001803C28F0-0x00000001803C2900
		public virtual JSONNode GetValueOrDefault(string aKey, JSONNode aDefault); // 0x0000000180BCE250-0x0000000180BCE260
		public override string ToString(); // 0x0000000180EB8510-0x0000000180EB85B0
		public virtual string ToString(int aIndent); // 0x0000000180EB85B0-0x0000000180EB8660
		internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);
		public abstract Enumerator GetEnumerator();
		public static implicit operator JSONNode(string s); // 0x0000000180EB9150-0x0000000180EB91B0
		public static implicit operator string(JSONNode d); // 0x0000000180EB9240-0x0000000180EB92D0
		public static implicit operator JSONNode(double n); // 0x0000000180EB8EE0-0x0000000180EB8F40
		public static implicit operator double(JSONNode d); // 0x0000000180EB91B0-0x0000000180EB9240
		public static implicit operator JSONNode(float n); // 0x0000000180EB9360-0x0000000180EB93C0
		public static implicit operator float(JSONNode d); // 0x0000000180EB9030-0x0000000180EB90C0
		public static implicit operator JSONNode(int n); // 0x0000000180EB8F40-0x0000000180EB8FA0
		public static implicit operator int(JSONNode d); // 0x0000000180EB93C0-0x0000000180EB9450
		public static implicit operator JSONNode(long n); // 0x0000000180EB8E00-0x0000000180EB8EE0
		public static implicit operator long(JSONNode d); // 0x0000000180EB90C0-0x0000000180EB9150
		public static implicit operator JSONNode(bool b); // 0x0000000180EB92D0-0x0000000180EB9360
		public static implicit operator bool(JSONNode d); // 0x0000000180EB8FA0-0x0000000180EB9030
		public static implicit operator JSONNode(KeyValuePair<string, JSONNode> aKeyValue); // 0x0000000180EB9450-0x0000000180EB9490
		public static bool operator ==(JSONNode a, object b); // 0x0000000180EB8C50-0x0000000180EB8E00
		public static bool operator !=(JSONNode a, object b); // 0x0000000180EB9490-0x0000000180EB9500
		public override bool Equals(object obj); // 0x0000000180570120-0x0000000180570130
		public override int GetHashCode(); // 0x00000001806D2810-0x00000001806D2820
		internal static string Escape(string aText); // 0x0000000180EB7460-0x0000000180EB77C0
		private static JSONNode ParseElement(string token, bool quoted); // 0x0000000180EB77C0-0x0000000180EB7AC0
		public static JSONNode Parse(string aJSON); // 0x0000000180EB7AC0-0x0000000180EB8510
	}
}
