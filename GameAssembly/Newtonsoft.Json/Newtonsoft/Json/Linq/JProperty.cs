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

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Linq
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	public class JProperty : JContainer // TypeDefIndex: 7987
	{
		// Fields
		private readonly JPropertyList _content; // 0x50
		private readonly string _name; // 0x58
	
		// Properties
		protected override IList<JToken> ChildrenTokens { get; } // 0x00000001803A27A0-0x00000001803A27B0 
		public string Name { [DebuggerStepThrough] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180357120-0x0000000180357130 
		public JToken Value { [DebuggerStepThrough] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; set; } // 0x00000001809563B0-0x00000001809563D0 0x00000001809563D0-0x0000000180956450
		public override JTokenType Type { [DebuggerStepThrough] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018043D4B0-0x000000018043D4C0 
	
		// Nested types
		private class JPropertyList : IList<JToken> // TypeDefIndex: 7988
		{
			// Fields
			internal JToken _token; // 0x10
	
			// Properties
			public int Count { get; } // 0x0000000180955390-0x00000001809553A0 
			public bool IsReadOnly { get; } // 0x00000001803C28F0-0x00000001803C2900 
			public JToken this[int index] { get => default; set {} } // 0x00000001809553A0-0x00000001809553B0 0x0000000180955350-0x0000000180955360
	
			// Nested types
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class <GetEnumerator>d__1 : IEnumerator<JToken> // TypeDefIndex: 7989
			{
				// Fields
				private int <>1__state; // 0x10
				private JToken <>2__current; // 0x18
				public JPropertyList <>4__this; // 0x20
	
				// Properties
				JToken IEnumerator<Newtonsoft.Json.Linq.JToken>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
				object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
				// Constructors
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				public <GetEnumerator>d__1(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
				// Methods
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
				private bool MoveNext(); // 0x000000018096D9B0-0x000000018096DA10
				[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
				void IEnumerator.Reset(); // 0x000000018096DA10-0x000000018096DA60
			}
	
			// Constructors
			public JPropertyList(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			public IEnumerator<JToken> GetEnumerator(); // 0x00000001809552E0-0x0000000180955340
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001809552E0-0x0000000180955340
			public void Add(JToken item); // 0x000000018036B1E0-0x000000018036B1F0
			public void Clear(); // 0x00000001808A3D40-0x00000001808A3D50
			public bool Contains(JToken item); // 0x0000000180955250-0x0000000180955260
			public void CopyTo(JToken[] array, int arrayIndex); // 0x0000000180955260-0x00000001809552E0
			public bool Remove(JToken item); // 0x0000000180955370-0x0000000180955390
			public int IndexOf(JToken item); // 0x0000000180955340-0x0000000180955350
			public void Insert(int index, JToken item); // 0x0000000180955350-0x0000000180955360
			public void RemoveAt(int index); // 0x0000000180955360-0x0000000180955370
		}
	
		// Constructors
		public JProperty(JProperty other); // 0x0000000180956080-0x0000000180956100
		internal JProperty(string name); // 0x00000001809562F0-0x00000001809563B0
		public JProperty(string name, object content); // 0x0000000180956100-0x00000001809562F0
	
		// Methods
		internal override JToken GetItem(int index); // 0x00000001809557D0-0x0000000180955850
		internal override void SetItem(int index, JToken item); // 0x0000000180955D50-0x0000000180955FE0
		internal override bool RemoveItem(JToken item); // 0x0000000180955C80-0x0000000180955D50
		internal override void RemoveItemAt(int index); // 0x0000000180955BB0-0x0000000180955C80
		internal override int IndexOfItem(JToken item); // 0x0000000180955850-0x0000000180955880
		internal override void InsertItem(int index, JToken item, bool skipParentCheck); // 0x0000000180955880-0x00000001809559B0
		internal override bool ContainsItem(JToken item); // 0x0000000180955530-0x0000000180955560
		internal override void ClearItems(); // 0x00000001809553B0-0x0000000180955480
		internal override bool DeepEquals(JToken node); // 0x0000000180955560-0x0000000180955740
		internal override JToken CloneToken(); // 0x0000000180955480-0x0000000180955530
		public override void WriteTo(JsonWriter writer, params /* 0x00000001800B36B0-0x00000001800B36C0 */ JsonConverter[] converters); // 0x0000000180955FE0-0x0000000180956080
		internal override int GetDeepHashCode(); // 0x0000000180955740-0x00000001809557D0
		public static JProperty Load(JsonReader reader, JsonLoadSettings settings); // 0x00000001809559B0-0x0000000180955BB0
	}
}
