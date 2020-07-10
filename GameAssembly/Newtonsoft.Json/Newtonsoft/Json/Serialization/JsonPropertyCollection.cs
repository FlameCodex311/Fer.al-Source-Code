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

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	public class JsonPropertyCollection : KeyedCollection<string, Newtonsoft.Json.Serialization.JsonProperty> // TypeDefIndex: 7930
	{
		// Fields
		private readonly Type _type; // 0x38
		private readonly List<JsonProperty> _list; // 0x40
	
		// Constructors
		public JsonPropertyCollection(Type type); // 0x00000001804EADE0-0x00000001804EAF10
	
		// Methods
		protected override string GetKeyForItem(JsonProperty item); // 0x00000001804EAB40-0x00000001804EAB60
		public void AddProperty(JsonProperty property); // 0x00000001804EA8D0-0x00000001804EAB00
		public JsonProperty GetClosestMatchProperty(string propertyName); // 0x00000001804EAB00-0x00000001804EAB40
		private bool TryGetValue(string key, out JsonProperty item); // 0x00000001804EAD00-0x00000001804EADE0
		public JsonProperty GetProperty(string propertyName, StringComparison comparisonType); // 0x00000001804EAB60-0x00000001804EAD00
	}
}
