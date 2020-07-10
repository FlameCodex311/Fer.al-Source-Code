/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace LitJson
{
	public class JsonMockWrapper : IJsonWrapper // TypeDefIndex: 15423
	{
		// Properties
		public bool IsArray { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public bool IsBoolean { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public bool IsDouble { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public bool IsInt { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public bool IsLong { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public bool IsObject { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public bool IsString { get; } // 0x00000001803C28F0-0x00000001803C2900 
		bool IList.IsFixedSize { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		bool IList.IsReadOnly { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		object IList.this[int index] { get => default; set {} } // 0x000000018035FCC0-0x000000018035FCD0 0x00000001803581E0-0x00000001803581F0
		int ICollection.Count { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		bool ICollection.IsSynchronized { get; } // 0x00000001803C28F0-0x00000001803C2900 
		object ICollection.SyncRoot { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		bool IDictionary.IsFixedSize { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		bool IDictionary.IsReadOnly { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		ICollection IDictionary.Keys { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		ICollection IDictionary.Values { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		object IDictionary.this[object key] { get => default; set {} } // 0x000000018035FCC0-0x000000018035FCD0 0x00000001803581E0-0x00000001803581F0
		object IOrderedDictionary.this[int idx] { get => default; set {} } // 0x000000018035FCC0-0x000000018035FCD0 0x00000001803581E0-0x00000001803581F0
	
		// Constructors
		public JsonMockWrapper(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public bool GetBoolean(); // 0x00000001803C28F0-0x00000001803C2900
		public double GetDouble(); // 0x0000000180DD1F20-0x0000000180DD1F30
		public int GetInt(); // 0x000000018035FCC0-0x000000018035FCD0
		public JsonType GetJsonType(); // 0x000000018035FCC0-0x000000018035FCD0
		public long GetLong(); // 0x000000018035FCC0-0x000000018035FCD0
		public string GetString(); // 0x00000001811DE770-0x00000001811DE7A0
		public void SetBoolean(bool val); // 0x00000001803581E0-0x00000001803581F0
		public void SetDouble(double val); // 0x00000001803581E0-0x00000001803581F0
		public void SetInt(int val); // 0x00000001803581E0-0x00000001803581F0
		public void SetJsonType(JsonType type); // 0x00000001803581E0-0x00000001803581F0
		public void SetLong(long val); // 0x00000001803581E0-0x00000001803581F0
		public void SetString(string val); // 0x00000001803581E0-0x00000001803581F0
		public string ToJson(); // 0x00000001811DE7A0-0x00000001811DE7D0
		public void ToJson(JsonWriter writer); // 0x00000001803581E0-0x00000001803581F0
		int IList.Add(object value); // 0x000000018035FCC0-0x000000018035FCD0
		void IList.Clear(); // 0x00000001803581E0-0x00000001803581F0
		bool IList.Contains(object value); // 0x00000001803C28F0-0x00000001803C2900
		int IList.IndexOf(object value); // 0x00000001805F5E50-0x00000001805F5E60
		void IList.Insert(int i, object v); // 0x00000001803581E0-0x00000001803581F0
		void IList.Remove(object value); // 0x00000001803581E0-0x00000001803581F0
		void IList.RemoveAt(int index); // 0x00000001803581E0-0x00000001803581F0
		void ICollection.CopyTo(Array array, int index); // 0x00000001803581E0-0x00000001803581F0
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018035FCC0-0x000000018035FCD0
		void IDictionary.Add(object k, object v); // 0x00000001803581E0-0x00000001803581F0
		void IDictionary.Clear(); // 0x00000001803581E0-0x00000001803581F0
		bool IDictionary.Contains(object key); // 0x00000001803C28F0-0x00000001803C2900
		void IDictionary.Remove(object key); // 0x00000001803581E0-0x00000001803581F0
		IDictionaryEnumerator IDictionary.GetEnumerator(); // 0x000000018035FCC0-0x000000018035FCD0
		IDictionaryEnumerator IOrderedDictionary.GetEnumerator(); // 0x000000018035FCC0-0x000000018035FCD0
		void IOrderedDictionary.Insert(int i, object k, object v); // 0x00000001803581E0-0x00000001803581F0
		void IOrderedDictionary.RemoveAt(int i); // 0x00000001803581E0-0x00000001803581F0
	}
}
