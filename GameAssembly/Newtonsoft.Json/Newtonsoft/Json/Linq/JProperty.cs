/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Linq
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class JProperty : JContainer // TypeDefIndex: 8153
	{
		// Fields
		private readonly JPropertyList _content; // 0x50
		private readonly string _name; // 0x58
	
		// Properties
		protected override IList<JToken> ChildrenTokens { get; } // 0x0000000180378320-0x0000000180378330 
		public string Name { [DebuggerStepThrough] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001803A1580-0x00000001803A1590 
		public JToken Value { [DebuggerStepThrough] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; set; } // 0x0000000180919830-0x0000000180919850 0x000000018183C8F0-0x000000018183C970
		public override JTokenType Type { [DebuggerStepThrough] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001806C4390-0x00000001806C43A0 
	
		// Nested types
		private class JPropertyList : IList<JToken> // TypeDefIndex: 8154
		{
			// Fields
			internal JToken _token; // 0x10
	
			// Properties
			public int Count { get; } // 0x000000018183B900-0x000000018183B910 
			public bool IsReadOnly { get; } // 0x0000000180380950-0x0000000180380960 
			public JToken this[int index] { get => default; set {} } // 0x000000018183B910-0x000000018183B920 0x000000018183B8C0-0x000000018183B8D0
	
			// Nested types
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class <GetEnumerator>d__1 : IEnumerator<JToken> // TypeDefIndex: 8155
			{
				// Fields
				private int <>1__state; // 0x10
				private JToken <>2__current; // 0x18
				public JPropertyList <>4__this; // 0x20
	
				// Properties
				JToken IEnumerator<Newtonsoft.Json.Linq.JToken>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
				object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public <GetEnumerator>d__1(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
				private bool MoveNext(); // 0x00000001818510E0-0x0000000181851140
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset(); // 0x0000000181851140-0x0000000181851190
			}
	
			// Constructors
			public JPropertyList(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			public IEnumerator<JToken> GetEnumerator(); // 0x000000018183B850-0x000000018183B8B0
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018183B850-0x000000018183B8B0
			public void Add(JToken item); // 0x0000000180379F20-0x0000000180379F30
			public void Clear(); // 0x000000018122D020-0x000000018122D030
			public bool Contains(JToken item); // 0x000000018157C170-0x000000018157C180
			public void CopyTo(JToken[] array, int arrayIndex); // 0x000000018183B7D0-0x000000018183B850
			public bool Remove(JToken item); // 0x000000018183B8E0-0x000000018183B900
			public int IndexOf(JToken item); // 0x000000018183B8B0-0x000000018183B8C0
			public void Insert(int index, JToken item); // 0x000000018183B8C0-0x000000018183B8D0
			public void RemoveAt(int index); // 0x000000018183B8D0-0x000000018183B8E0
		}
	
		// Constructors
		public JProperty(JProperty other); // 0x000000018183C5C0-0x000000018183C640
		internal JProperty(string name); // 0x000000018183C830-0x000000018183C8F0
		public JProperty(string name, object content); // 0x000000018183C640-0x000000018183C830
	
		// Methods
		internal override JToken GetItem(int index); // 0x000000018183BD20-0x000000018183BDA0
		internal override void SetItem(int index, JToken item); // 0x000000018183C290-0x000000018183C520
		internal override bool RemoveItem(JToken item); // 0x000000018183C1C0-0x000000018183C290
		internal override void RemoveItemAt(int index); // 0x000000018183C0F0-0x000000018183C1C0
		internal override int IndexOfItem(JToken item); // 0x000000018183BDA0-0x000000018183BDD0
		internal override void InsertItem(int index, JToken item, bool skipParentCheck); // 0x000000018183BDD0-0x000000018183BEF0
		internal override bool ContainsItem(JToken item); // 0x000000018183BAA0-0x000000018183BAC0
		internal override void ClearItems(); // 0x000000018183B920-0x000000018183B9F0
		internal override bool DeepEquals(JToken node); // 0x000000018183BAC0-0x000000018183BC90
		internal override JToken CloneToken(); // 0x000000018183B9F0-0x000000018183BAA0
		public override void WriteTo(JsonWriter writer, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ JsonConverter[] converters); // 0x000000018183C520-0x000000018183C5C0
		internal override int GetDeepHashCode(); // 0x000000018183BC90-0x000000018183BD20
		public static JProperty Load(JsonReader reader, JsonLoadSettings settings); // 0x000000018183BEF0-0x000000018183C0F0
	}
}
