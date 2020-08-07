/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class JsonPropertyCollection : KeyedCollection<string, Newtonsoft.Json.Serialization.JsonProperty> // TypeDefIndex: 8096
	{
		// Fields
		private readonly Type _type; // 0x38
		private readonly List<JsonProperty> _list; // 0x40
	
		// Constructors
		public JsonPropertyCollection(Type type); // 0x0000000180E90520-0x0000000180E90650
	
		// Methods
		protected override string GetKeyForItem(JsonProperty item); // 0x0000000180C34BD0-0x0000000180C34BF0
		public void AddProperty(JsonProperty property); // 0x0000000180E90030-0x0000000180E90260
		public JsonProperty GetClosestMatchProperty(string propertyName); // 0x0000000180E90260-0x0000000180E902A0
		private bool TryGetValue(string key, out JsonProperty item); // 0x0000000180E90440-0x0000000180E90520
		public JsonProperty GetProperty(string propertyName, StringComparison comparisonType); // 0x0000000180E902A0-0x0000000180E90440
	}
}
