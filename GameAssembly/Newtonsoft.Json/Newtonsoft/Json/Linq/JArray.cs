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
	[Preserve] // 0x0000000180248D70-0x0000000180248DC0
	public class JArray : JContainer, IList<JToken> // TypeDefIndex: 8143
	{
		// Fields
		private readonly List<JToken> _values; // 0x50
	
		// Properties
		protected override IList<JToken> ChildrenTokens { get; } // 0x0000000180378320-0x0000000180378330 
		public override JTokenType Type { get; } // 0x0000000180411150-0x0000000180411160 
		public JToken this[int index] { get => default; set {} } // 0x0000000181834F90-0x0000000181834FB0 0x0000000181834FB0-0x0000000181834FD0
		public bool IsReadOnly { get; } // 0x0000000180380950-0x0000000180380960 
	
		// Constructors
		public JArray(); // 0x0000000181834DC0-0x0000000181834E60
		public JArray(JArray other); // 0x0000000181834F20-0x0000000181834F90
		public JArray(object content); // 0x0000000181834E60-0x0000000181834F20
	
		// Methods
		internal override bool DeepEquals(JToken node); // 0x00000001818347F0-0x00000001818349B0
		internal override JToken CloneToken(); // 0x0000000181834730-0x00000001818347D0
		public static JArray Load(JsonReader reader, JsonLoadSettings settings); // 0x0000000181834AC0-0x0000000181834C70
		public override void WriteTo(JsonWriter writer, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ JsonConverter[] converters); // 0x0000000181834CB0-0x0000000181834DC0
		internal override int IndexOfItem(JToken item); // 0x0000000181834A20-0x0000000181834A70
		public int IndexOf(JToken item); // 0x0000000181834A70-0x0000000181834A90
		public void Insert(int index, JToken item); // 0x0000000181834A90-0x0000000181834AC0
		public void RemoveAt(int index); // 0x0000000181834C70-0x0000000181834C90
		public IEnumerator<JToken> GetEnumerator(); // 0x00000001818349C0-0x0000000181834A20
		public void Add(JToken item); // 0x00000001818346F0-0x0000000181834710
		public void Clear(); // 0x0000000181834710-0x0000000181834730
		public bool Contains(JToken item); // 0x0000000180CA1430-0x0000000180CA1450
		public void CopyTo(JToken[] array, int arrayIndex); // 0x00000001818347D0-0x00000001818347F0
		public bool Remove(JToken item); // 0x0000000181834C90-0x0000000181834CB0
		internal override int GetDeepHashCode(); // 0x00000001818349B0-0x00000001818349C0
	}
}
