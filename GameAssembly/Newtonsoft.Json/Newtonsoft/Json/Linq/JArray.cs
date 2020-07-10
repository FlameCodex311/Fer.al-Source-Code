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
	[Preserve] // 0x00000001800FC9A0-0x00000001800FC9F0
	public class JArray : JContainer, IList<JToken> // TypeDefIndex: 7977
	{
		// Fields
		private readonly List<JToken> _values; // 0x50
	
		// Properties
		protected override IList<JToken> ChildrenTokens { get; } // 0x00000001803A27A0-0x00000001803A27B0 
		public override JTokenType Type { get; } // 0x0000000180362180-0x0000000180362190 
		public JToken this[int index] { get => default; set {} } // 0x000000018094E8D0-0x000000018094E8F0 0x000000018094E8F0-0x000000018094E910
		public bool IsReadOnly { get; } // 0x00000001803C28F0-0x00000001803C2900 
	
		// Constructors
		public JArray(); // 0x000000018094E700-0x000000018094E7A0
		public JArray(JArray other); // 0x000000018094E860-0x000000018094E8D0
		public JArray(object content); // 0x000000018094E7A0-0x000000018094E860
	
		// Methods
		internal override bool DeepEquals(JToken node); // 0x000000018094E120-0x000000018094E2F0
		internal override JToken CloneToken(); // 0x000000018094E060-0x000000018094E100
		public static JArray Load(JsonReader reader, JsonLoadSettings settings); // 0x000000018094E400-0x000000018094E5B0
		public override void WriteTo(JsonWriter writer, params /* 0x00000001800B36B0-0x00000001800B36C0 */ JsonConverter[] converters); // 0x000000018094E5F0-0x000000018094E700
		internal override int IndexOfItem(JToken item); // 0x000000018094E360-0x000000018094E3B0
		public int IndexOf(JToken item); // 0x000000018094E3B0-0x000000018094E3D0
		public void Insert(int index, JToken item); // 0x000000018094E3D0-0x000000018094E400
		public void RemoveAt(int index); // 0x000000018094E5B0-0x000000018094E5D0
		public IEnumerator<JToken> GetEnumerator(); // 0x000000018094E300-0x000000018094E360
		public void Add(JToken item); // 0x000000018094E020-0x000000018094E040
		public void Clear(); // 0x000000018094E040-0x000000018094E060
		public bool Contains(JToken item); // 0x00000001805B7260-0x00000001805B7280
		public void CopyTo(JToken[] array, int arrayIndex); // 0x000000018094E100-0x000000018094E120
		public bool Remove(JToken item); // 0x000000018094E5D0-0x000000018094E5F0
		internal override int GetDeepHashCode(); // 0x000000018094E2F0-0x000000018094E300
	}
}
