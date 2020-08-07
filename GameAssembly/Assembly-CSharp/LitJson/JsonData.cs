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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace LitJson
{
	public class JsonData : IJsonWrapper, IEquatable<LitJson.JsonData> // TypeDefIndex: 16063
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
		public int Count { get; } // 0x0000000180C46000-0x0000000180C46060 
		public bool IsArray { get; } // 0x0000000180C45D30-0x0000000180C45D40 
		public bool IsBoolean { get; } // 0x0000000180C45D40-0x0000000180C45D50 
		public bool IsDouble { get; } // 0x0000000180C45D50-0x0000000180C45D60 
		public bool IsInt { get; } // 0x0000000180C45D60-0x0000000180C45D70 
		public bool IsLong { get; } // 0x0000000180C45D70-0x0000000180C45D80 
		public bool IsObject { get; } // 0x0000000180C45D80-0x0000000180C45D90 
		public bool IsString { get; } // 0x0000000180C45D90-0x0000000180C45DA0 
		public ICollection<string> Keys { get; } // 0x0000000180C48580-0x0000000180C485E0 
		int ICollection.Count { get; } // 0x0000000180C46000-0x0000000180C46060 
		bool ICollection.IsSynchronized { get; } // 0x0000000180C46060-0x0000000180C460C0 
		object ICollection.SyncRoot { get; } // 0x0000000180C460C0-0x0000000180C46120 
		bool IDictionary.IsFixedSize { get; } // 0x0000000180C465A0-0x0000000180C46600 
		bool IDictionary.IsReadOnly { get; } // 0x0000000180C46600-0x0000000180C46660 
		ICollection IDictionary.Keys { get; } // 0x0000000180C466C0-0x0000000180C46950 
		ICollection IDictionary.Values { get; } // 0x0000000180C46950-0x0000000180C46BE0 
		bool IJsonWrapper.IsArray { get; } // 0x0000000180C45D30-0x0000000180C45D40 
		bool IJsonWrapper.IsBoolean { get; } // 0x0000000180C45D40-0x0000000180C45D50 
		bool IJsonWrapper.IsDouble { get; } // 0x0000000180C45D50-0x0000000180C45D60 
		bool IJsonWrapper.IsInt { get; } // 0x0000000180C45D60-0x0000000180C45D70 
		bool IJsonWrapper.IsLong { get; } // 0x0000000180C45D70-0x0000000180C45D80 
		bool IJsonWrapper.IsObject { get; } // 0x0000000180C45D80-0x0000000180C45D90 
		bool IJsonWrapper.IsString { get; } // 0x0000000180C45D90-0x0000000180C45DA0 
		bool IList.IsFixedSize { get; } // 0x0000000180C46FB0-0x0000000180C47010 
		bool IList.IsReadOnly { get; } // 0x0000000180C47010-0x0000000180C47070 
		object IDictionary.this[object key] { get => default; set {} } // 0x0000000180C46660-0x0000000180C466C0 0x0000000180C46BE0-0x0000000180C46CC0
		object IOrderedDictionary.this[int idx] { get => default; set {} } // 0x0000000180C47440-0x0000000180C47510 0x0000000180C47510-0x0000000180C47720
		object IList.this[int index] { get => default; set {} } // 0x0000000180C47070-0x0000000180C470D0 0x0000000180C470D0-0x0000000180C47120
		public JsonData this[string prop_name] { get => default; set {} } // 0x0000000180C484C0-0x0000000180C48580 0x0000000180C48D30-0x0000000180C48FF0
		public JsonData this[int index] { get => default; set {} } // 0x0000000180C48360-0x0000000180C484C0 0x0000000180C48AA0-0x0000000180C48D30
	
		// Constructors
		public JsonData(); // 0x0000000180373240-0x0000000180373250
		public JsonData(bool boolean); // 0x0000000180C48120-0x0000000180C48150
		public JsonData(double number); // 0x0000000180C48090-0x0000000180C480C0
		public JsonData(int number); // 0x0000000180C480C0-0x0000000180C480F0
		public JsonData(long number); // 0x0000000180C480F0-0x0000000180C48120
		public JsonData(object obj); // 0x0000000180C48150-0x0000000180C48360
		public JsonData(string str); // 0x0000000180C48060-0x0000000180C48090
	
		// Methods
		public static implicit operator JsonData(bool data); // 0x0000000180C48920-0x0000000180C48980
		public static implicit operator JsonData(double data); // 0x0000000180C489E0-0x0000000180C48A40
		public static implicit operator JsonData(int data); // 0x0000000180C48980-0x0000000180C489E0
		public static implicit operator JsonData(long data); // 0x0000000180C48A40-0x0000000180C48AA0
		public static implicit operator JsonData(string data); // 0x0000000180C488C0-0x0000000180C48920
		public static explicit operator bool(JsonData data); // 0x0000000180C48720-0x0000000180C48790
		public static explicit operator double(JsonData data); // 0x0000000180C485E0-0x0000000180C48680
		public static explicit operator int(JsonData data); // 0x0000000180C48790-0x0000000180C48820
		public static explicit operator long(JsonData data); // 0x0000000180C48680-0x0000000180C48720
		public static explicit operator string(JsonData data); // 0x0000000180C48820-0x0000000180C488C0
		void ICollection.CopyTo(Array array, int index); // 0x0000000180C45F30-0x0000000180C46000
		void IDictionary.Add(object key, object value); // 0x0000000180C46120-0x0000000180C462A0
		void IDictionary.Clear(); // 0x0000000180C462A0-0x0000000180C46320
		bool IDictionary.Contains(object key); // 0x0000000180C46320-0x0000000180C46390
		IDictionaryEnumerator IDictionary.GetEnumerator(); // 0x0000000180C46390-0x0000000180C463D0
		void IDictionary.Remove(object key); // 0x0000000180C463D0-0x0000000180C465A0
		IEnumerator IEnumerable.GetEnumerator(); // 0x0000000180C46CC0-0x0000000180C46D10
		bool IJsonWrapper.GetBoolean(); // 0x0000000180C45A10-0x0000000180C45A80
		double IJsonWrapper.GetDouble(); // 0x0000000180C45A80-0x0000000180C45AF0
		int IJsonWrapper.GetInt(); // 0x0000000180C45AF0-0x0000000180C45B60
		long IJsonWrapper.GetLong(); // 0x0000000180C45B60-0x0000000180C45BD0
		string IJsonWrapper.GetString(); // 0x0000000180C45BD0-0x0000000180C45C40
		void IJsonWrapper.SetBoolean(bool val); // 0x0000000180C45C40-0x0000000180C45C60
		void IJsonWrapper.SetDouble(double val); // 0x0000000180C45C60-0x0000000180C45C80
		void IJsonWrapper.SetInt(int val); // 0x0000000180C45C80-0x0000000180C45CA0
		void IJsonWrapper.SetLong(long val); // 0x0000000180C45CA0-0x0000000180C45CC0
		void IJsonWrapper.SetString(string val); // 0x0000000180C45CC0-0x0000000180C45CE0
		string IJsonWrapper.ToJson(); // 0x0000000180C45CE0-0x0000000180C45CF0
		void IJsonWrapper.ToJson(JsonWriter writer); // 0x0000000180C45CF0-0x0000000180C45D30
		int IList.Add(object value); // 0x0000000180C45480-0x0000000180C45500
		void IList.Clear(); // 0x0000000180C46D10-0x0000000180C46D70
		bool IList.Contains(object value); // 0x0000000180C46D70-0x0000000180C46DE0
		int IList.IndexOf(object value); // 0x0000000180C46DE0-0x0000000180C46E50
		void IList.Insert(int index, object value); // 0x0000000180C46E50-0x0000000180C46ED0
		void IList.Remove(object value); // 0x0000000180C46F40-0x0000000180C46FB0
		void IList.RemoveAt(int index); // 0x0000000180C46ED0-0x0000000180C46F40
		IDictionaryEnumerator IOrderedDictionary.GetEnumerator(); // 0x0000000180C47120-0x0000000180C471A0
		void IOrderedDictionary.Insert(int idx, object key, object value); // 0x0000000180C471A0-0x0000000180C47310
		void IOrderedDictionary.RemoveAt(int idx); // 0x0000000180C47310-0x0000000180C47440
		private ICollection EnsureCollection(); // 0x0000000180C455F0-0x0000000180C456C0
		private IDictionary EnsureDictionary(); // 0x0000000180C456C0-0x0000000180C457E0
		private IList EnsureList(); // 0x0000000180C457E0-0x0000000180C458E0
		private JsonData ToJsonData(object obj); // 0x0000000180C47720-0x0000000180C47810
		private static void WriteJson(IJsonWrapper obj, JsonWriter writer); // 0x0000000180C479F0-0x0000000180C48060
		public int Add(object value); // 0x0000000180C45480-0x0000000180C45500
		public bool Contains(object value); // 0x0000000180C45570-0x0000000180C455F0
		public void Clear(); // 0x0000000180C45500-0x0000000180C45570
		public bool Equals(JsonData x); // 0x0000000180C458E0-0x0000000180C45A10
		public JsonType GetJsonType(); // 0x00000001803F8270-0x00000001803F8280
		public void SetJsonType(JsonType type); // 0x0000000180C45DA0-0x0000000180C45F30
		public string ToJson(); // 0x0000000180C47810-0x0000000180C47920
		public void ToJson(JsonWriter writer); // 0x0000000180C45CF0-0x0000000180C45D30
		public override string ToString(); // 0x0000000180C47920-0x0000000180C479F0
	}
}
