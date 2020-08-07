/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace LitJson
{
	public class JsonMockWrapper : IJsonWrapper // TypeDefIndex: 16078
	{
		// Properties
		public bool IsArray { get; } // 0x0000000180380950-0x0000000180380960 
		public bool IsBoolean { get; } // 0x0000000180380950-0x0000000180380960 
		public bool IsDouble { get; } // 0x0000000180380950-0x0000000180380960 
		public bool IsInt { get; } // 0x0000000180380950-0x0000000180380960 
		public bool IsLong { get; } // 0x0000000180380950-0x0000000180380960 
		public bool IsObject { get; } // 0x0000000180380950-0x0000000180380960 
		public bool IsString { get; } // 0x0000000180380950-0x0000000180380960 
		bool IList.IsFixedSize { get; } // 0x0000000180380B60-0x0000000180380B70 
		bool IList.IsReadOnly { get; } // 0x0000000180380B60-0x0000000180380B70 
		object IList.this[int index] { get => default; set {} } // 0x000000018037DDC0-0x000000018037DDD0 0x00000001803774A0-0x00000001803774B0
		int ICollection.Count { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		bool ICollection.IsSynchronized { get; } // 0x0000000180380950-0x0000000180380960 
		object ICollection.SyncRoot { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		bool IDictionary.IsFixedSize { get; } // 0x0000000180380B60-0x0000000180380B70 
		bool IDictionary.IsReadOnly { get; } // 0x0000000180380B60-0x0000000180380B70 
		ICollection IDictionary.Keys { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		ICollection IDictionary.Values { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		object IDictionary.this[object key] { get => default; set {} } // 0x000000018037DDC0-0x000000018037DDD0 0x00000001803774A0-0x00000001803774B0
		object IOrderedDictionary.this[int idx] { get => default; set {} } // 0x000000018037DDC0-0x000000018037DDD0 0x00000001803774A0-0x00000001803774B0
	
		// Constructors
		public JsonMockWrapper(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public bool GetBoolean(); // 0x0000000180380950-0x0000000180380960
		public double GetDouble(); // 0x000000018058C7E0-0x000000018058C7F0
		public int GetInt(); // 0x000000018037DDC0-0x000000018037DDD0
		public JsonType GetJsonType(); // 0x000000018037DDC0-0x000000018037DDD0
		public long GetLong(); // 0x000000018037DDC0-0x000000018037DDD0
		public string GetString(); // 0x0000000180C4FA90-0x0000000180C4FAC0
		public void SetBoolean(bool val); // 0x00000001803774A0-0x00000001803774B0
		public void SetDouble(double val); // 0x00000001803774A0-0x00000001803774B0
		public void SetInt(int val); // 0x00000001803774A0-0x00000001803774B0
		public void SetJsonType(JsonType type); // 0x00000001803774A0-0x00000001803774B0
		public void SetLong(long val); // 0x00000001803774A0-0x00000001803774B0
		public void SetString(string val); // 0x00000001803774A0-0x00000001803774B0
		public string ToJson(); // 0x0000000180C4FAC0-0x0000000180C4FAF0
		public void ToJson(JsonWriter writer); // 0x00000001803774A0-0x00000001803774B0
		int IList.Add(object value); // 0x000000018037DDC0-0x000000018037DDD0
		void IList.Clear(); // 0x00000001803774A0-0x00000001803774B0
		bool IList.Contains(object value); // 0x0000000180380950-0x0000000180380960
		int IList.IndexOf(object value); // 0x00000001807C4280-0x00000001807C4290
		void IList.Insert(int i, object v); // 0x00000001803774A0-0x00000001803774B0
		void IList.Remove(object value); // 0x00000001803774A0-0x00000001803774B0
		void IList.RemoveAt(int index); // 0x00000001803774A0-0x00000001803774B0
		void ICollection.CopyTo(Array array, int index); // 0x00000001803774A0-0x00000001803774B0
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018037DDC0-0x000000018037DDD0
		void IDictionary.Add(object k, object v); // 0x00000001803774A0-0x00000001803774B0
		void IDictionary.Clear(); // 0x00000001803774A0-0x00000001803774B0
		bool IDictionary.Contains(object key); // 0x0000000180380950-0x0000000180380960
		void IDictionary.Remove(object key); // 0x00000001803774A0-0x00000001803774B0
		IDictionaryEnumerator IDictionary.GetEnumerator(); // 0x000000018037DDC0-0x000000018037DDD0
		IDictionaryEnumerator IOrderedDictionary.GetEnumerator(); // 0x000000018037DDC0-0x000000018037DDD0
		void IOrderedDictionary.Insert(int i, object k, object v); // 0x00000001803774A0-0x00000001803774B0
		void IOrderedDictionary.RemoveAt(int i); // 0x00000001803774A0-0x00000001803774B0
	}
}
