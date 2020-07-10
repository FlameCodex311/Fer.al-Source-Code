/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace LitJson
{
	public class JsonData : IJsonWrapper, IEquatable<LitJson.JsonData> // TypeDefIndex: 15408
	{
		// Fields
		private IList<JsonData> inst_array; // 0x10
		private bool inst_boolean; // 0x18
		private double inst_double; // 0x20
		private int inst_int; // 0x28
		private long inst_long; // 0x30
		private IDictionary<string, JsonData> inst_object; // 0x38
		private string inst_string; // 0x40
		private string json; // 0x48
		private JsonType type; // 0x50
		private IList<KeyValuePair<string, JsonData>> object_list; // 0x58
	
		// Properties
		public int Count { get; } // 0x00000001812C1570-0x00000001812C15D0 
		public bool IsArray { get; } // 0x00000001812C1290-0x00000001812C12A0 
		public bool IsBoolean { get; } // 0x00000001812C12A0-0x00000001812C12B0 
		public bool IsDouble { get; } // 0x00000001812C12B0-0x00000001812C12C0 
		public bool IsInt { get; } // 0x00000001812C12C0-0x00000001812C12D0 
		public bool IsLong { get; } // 0x00000001812C12D0-0x00000001812C12E0 
		public bool IsObject { get; } // 0x00000001812C12E0-0x00000001812C12F0 
		public bool IsString { get; } // 0x00000001812C12F0-0x00000001812C1300 
		public ICollection<string> Keys { get; } // 0x00000001812C3B60-0x00000001812C3BC0 
		int ICollection.Count { get; } // 0x00000001812C1570-0x00000001812C15D0 
		bool ICollection.IsSynchronized { get; } // 0x00000001812C15D0-0x00000001812C1630 
		object ICollection.SyncRoot { get; } // 0x00000001812C1630-0x00000001812C1690 
		bool IDictionary.IsFixedSize { get; } // 0x00000001812C1B20-0x00000001812C1B80 
		bool IDictionary.IsReadOnly { get; } // 0x00000001812C1B80-0x00000001812C1BE0 
		ICollection IDictionary.Keys { get; } // 0x00000001812C1C40-0x00000001812C1ED0 
		ICollection IDictionary.Values { get; } // 0x00000001812C1ED0-0x00000001812C2160 
		bool IJsonWrapper.IsArray { get; } // 0x00000001812C1290-0x00000001812C12A0 
		bool IJsonWrapper.IsBoolean { get; } // 0x00000001812C12A0-0x00000001812C12B0 
		bool IJsonWrapper.IsDouble { get; } // 0x00000001812C12B0-0x00000001812C12C0 
		bool IJsonWrapper.IsInt { get; } // 0x00000001812C12C0-0x00000001812C12D0 
		bool IJsonWrapper.IsLong { get; } // 0x00000001812C12D0-0x00000001812C12E0 
		bool IJsonWrapper.IsObject { get; } // 0x00000001812C12E0-0x00000001812C12F0 
		bool IJsonWrapper.IsString { get; } // 0x00000001812C12F0-0x00000001812C1300 
		bool IList.IsFixedSize { get; } // 0x00000001812C25C0-0x00000001812C2620 
		bool IList.IsReadOnly { get; } // 0x00000001812C2620-0x00000001812C2680 
		object IDictionary.this[object key] { get => default; set {} } // 0x00000001812C1BE0-0x00000001812C1C40 0x00000001812C2160-0x00000001812C2240
		object IOrderedDictionary.this[int idx] { get => default; set {} } // 0x00000001812C2A50-0x00000001812C2B20 0x00000001812C2B20-0x00000001812C2D30
		object IList.this[int index] { get => default; set {} } // 0x00000001812C2680-0x00000001812C26E0 0x00000001812C26E0-0x00000001812C2730
		public JsonData this[string prop_name] { get => default; set {} } // 0x00000001812C3AA0-0x00000001812C3B60 0x00000001812C4300-0x00000001812C45D0
		public JsonData this[int index] { get => default; set {} } // 0x00000001812C3940-0x00000001812C3AA0 0x00000001812C4060-0x00000001812C4300
	
		// Constructors
		public JsonData(); // 0x000000018036B6C0-0x000000018036B6D0
		public JsonData(bool boolean); // 0x00000001812C3700-0x00000001812C3730
		public JsonData(double number); // 0x00000001812C3670-0x00000001812C36A0
		public JsonData(int number); // 0x00000001812C36A0-0x00000001812C36D0
		public JsonData(long number); // 0x00000001812C36D0-0x00000001812C3700
		public JsonData(object obj); // 0x00000001812C3730-0x00000001812C3940
		public JsonData(string str); // 0x00000001812C3640-0x00000001812C3670
	
		// Methods
		public static implicit operator JsonData(bool data); // 0x00000001812C3EE0-0x00000001812C3F40
		public static implicit operator JsonData(double data); // 0x00000001812C3FA0-0x00000001812C4000
		public static implicit operator JsonData(int data); // 0x00000001812C3F40-0x00000001812C3FA0
		public static implicit operator JsonData(long data); // 0x00000001812C4000-0x00000001812C4060
		public static implicit operator JsonData(string data); // 0x00000001812C3E80-0x00000001812C3EE0
		public static explicit operator bool(JsonData data); // 0x00000001812C3CD0-0x00000001812C3D50
		public static explicit operator double(JsonData data); // 0x00000001812C3BC0-0x00000001812C3C40
		public static explicit operator int(JsonData data); // 0x00000001812C3D50-0x00000001812C3DD0
		public static explicit operator long(JsonData data); // 0x00000001812C3C40-0x00000001812C3CD0
		public static explicit operator string(JsonData data); // 0x00000001812C3DD0-0x00000001812C3E80
		void ICollection.CopyTo(Array array, int index); // 0x00000001812C1490-0x00000001812C1570
		void IDictionary.Add(object key, object value); // 0x00000001812C1690-0x00000001812C1820
		void IDictionary.Clear(); // 0x00000001812C1820-0x00000001812C18A0
		bool IDictionary.Contains(object key); // 0x00000001812C18A0-0x00000001812C1910
		IDictionaryEnumerator IDictionary.GetEnumerator(); // 0x00000001812C1910-0x00000001812C1950
		void IDictionary.Remove(object key); // 0x00000001812C1950-0x00000001812C1B20
		IEnumerator IEnumerable.GetEnumerator(); // 0x00000001812C2240-0x00000001812C22A0
		bool IJsonWrapper.GetBoolean(); // 0x00000001812C0F70-0x00000001812C0FE0
		double IJsonWrapper.GetDouble(); // 0x00000001812C0FE0-0x00000001812C1050
		int IJsonWrapper.GetInt(); // 0x00000001812C1050-0x00000001812C10C0
		long IJsonWrapper.GetLong(); // 0x00000001812C10C0-0x00000001812C1130
		string IJsonWrapper.GetString(); // 0x00000001812C1130-0x00000001812C11A0
		void IJsonWrapper.SetBoolean(bool val); // 0x00000001812C11A0-0x00000001812C11C0
		void IJsonWrapper.SetDouble(double val); // 0x00000001812C11C0-0x00000001812C11E0
		void IJsonWrapper.SetInt(int val); // 0x00000001812C11E0-0x00000001812C1200
		void IJsonWrapper.SetLong(long val); // 0x00000001812C1200-0x00000001812C1220
		void IJsonWrapper.SetString(string val); // 0x00000001812C1220-0x00000001812C1240
		string IJsonWrapper.ToJson(); // 0x00000001812C1240-0x00000001812C1250
		void IJsonWrapper.ToJson(JsonWriter writer); // 0x00000001812C1250-0x00000001812C1290
		int IList.Add(object value); // 0x00000001812C09D0-0x00000001812C0A50
		void IList.Clear(); // 0x00000001812C22A0-0x00000001812C2300
		bool IList.Contains(object value); // 0x00000001812C2300-0x00000001812C2370
		int IList.IndexOf(object value); // 0x00000001812C2370-0x00000001812C23E0
		void IList.Insert(int index, object value); // 0x00000001812C23E0-0x00000001812C24E0
		void IList.Remove(object value); // 0x00000001812C2550-0x00000001812C25C0
		void IList.RemoveAt(int index); // 0x00000001812C24E0-0x00000001812C2550
		IDictionaryEnumerator IOrderedDictionary.GetEnumerator(); // 0x00000001812C2730-0x00000001812C27B0
		void IOrderedDictionary.Insert(int idx, object key, object value); // 0x00000001812C27B0-0x00000001812C2920
		void IOrderedDictionary.RemoveAt(int idx); // 0x00000001812C2920-0x00000001812C2A50
		private ICollection EnsureCollection(); // 0x00000001812C0B40-0x00000001812C0C10
		private IDictionary EnsureDictionary(); // 0x00000001812C0C10-0x00000001812C0D40
		private IList EnsureList(); // 0x00000001812C0D40-0x00000001812C0E40
		private JsonData ToJsonData(object obj); // 0x00000001812C2D30-0x00000001812C2E20
		private static void WriteJson(IJsonWrapper obj, JsonWriter writer); // 0x00000001812C2FB0-0x00000001812C3640
		public int Add(object value); // 0x00000001812C09D0-0x00000001812C0A50
		public bool Contains(object value); // 0x00000001812C0AC0-0x00000001812C0B40
		public void Clear(); // 0x00000001812C0A50-0x00000001812C0AC0
		public bool Equals(JsonData x); // 0x00000001812C0E40-0x00000001812C0F70
		public JsonType GetJsonType(); // 0x0000000180369BA0-0x0000000180369BB0
		public void SetJsonType(JsonType type); // 0x00000001812C1300-0x00000001812C1490
		public string ToJson(); // 0x00000001812C2E20-0x00000001812C2EE0
		public void ToJson(JsonWriter writer); // 0x00000001812C1250-0x00000001812C1290
		public override string ToString(); // 0x00000001812C2EE0-0x00000001812C2FB0
	}
}
