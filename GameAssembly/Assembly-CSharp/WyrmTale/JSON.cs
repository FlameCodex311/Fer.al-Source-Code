/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WyrmTale
{
	public class JSON // TypeDefIndex: 16088
	{
		// Fields
		public string originalJSON; // 0x10
		public Dictionary<string, object> fields; // 0x18
	
		// Properties
		public object this[string fieldName] { get => default; set {} } // 0x0000000181979A90-0x0000000181979B20 0x000000018197AAA0-0x000000018197AB60
		public string serialized { get; set; } // 0x0000000181979B20-0x0000000181979BE0 0x000000018197AB60-0x000000018197ABA0
	
		// Nested types
		private sealed class _JSON // TypeDefIndex: 16089
		{
			// Nested types
			private sealed class Parser : IDisposable // TypeDefIndex: 16090
			{
				// Fields
				private const string WHITE_SPACE = " \t\n\r"; // Metadata: 0x007BB8A8
				private const string WORD_BREAK = " \t\n\r{}[],:\""; // Metadata: 0x007BB8B0
				private StringReader json; // 0x10
	
				// Properties
				private char PeekChar { get; } // 0x000000018197C3D0-0x000000018197C450 
				private char NextChar { get; } // 0x000000018197BF90-0x000000018197C010 
				private string NextWord { get; } // 0x000000018197C2D0-0x000000018197C3D0 
				private TOKEN NextToken { get; } // 0x000000018197C010-0x000000018197C2D0 
	
				// Nested types
				private enum TOKEN // TypeDefIndex: 16091
				{
					NONE = 0,
					CURLY_OPEN = 1,
					CURLY_CLOSE = 2,
					SQUARED_OPEN = 3,
					SQUARED_CLOSE = 4,
					COLON = 5,
					COMMA = 6,
					STRING = 7,
					NUMBER = 8,
					TRUE = 9,
					FALSE = 10,
					NULL = 11
				}
	
				// Constructors
				private Parser(string jsonString); // 0x000000018197BF20-0x000000018197BF90
	
				// Methods
				public static JSON Parse(string jsonString); // 0x000000018197BDA0-0x000000018197BF20
				public void Dispose(); // 0x000000018197B360-0x000000018197B390
				private JSON ParseObject(); // 0x000000018197B880-0x000000018197BA20
				private List<object> ParseArray(); // 0x000000018197B450-0x000000018197B520
				private object ParseValue(); // 0x000000018197BD70-0x000000018197BDA0
				private object ParseByToken(TOKEN token); // 0x000000018197B520-0x000000018197B790
				private string ParseString(); // 0x000000018197BA20-0x000000018197BD70
				private object ParseNumber(); // 0x000000018197B790-0x000000018197B880
				private void EatWhitespace(); // 0x000000018197B390-0x000000018197B450
			}
	
			private sealed class Serializer // TypeDefIndex: 16092
			{
				// Fields
				private StringBuilder builder; // 0x10
	
				// Constructors
				private Serializer(); // 0x000000018197FFA0-0x0000000181980000
	
				// Methods
				public static string Serialize(JSON obj); // 0x0000000181979B20-0x0000000181979BE0
				private void SerializeValue(object value); // 0x000000018197FC20-0x000000018197FFA0
				private void SerializeObject(JSON obj); // 0x000000018197F740-0x000000018197F760
				private void SerializeDictionary(IDictionary obj); // 0x000000018197F480-0x000000018197F740
				private void SerializeArray(IList anArray); // 0x000000018197F250-0x000000018197F480
				private void SerializeString(string str); // 0x000000018197F8E0-0x000000018197FC20
				private void SerializeOther(object value); // 0x000000018197F760-0x000000018197F8E0
			}
	
			// Constructors
			public _JSON(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			public static JSON Deserialize(string json); // 0x000000018198B3B0-0x000000018198B3C0
			public static string Serialize(JSON obj); // 0x0000000181979B20-0x0000000181979BE0
		}
	
		// Constructors
		public JSON(); // 0x0000000181979A20-0x0000000181979A90
	
		// Methods
		public string ToString(string fieldName); // 0x0000000181979960-0x0000000181979A20
		public int ToInt(string fieldName); // 0x0000000181979790-0x0000000181979840
		public float ToFloat(string fieldName); // 0x00000001819796E0-0x0000000181979790
		public bool ToBoolean(string fieldName); // 0x0000000181979630-0x00000001819796E0
		public JSON ToJSON(string fieldName); // 0x0000000181979840-0x0000000181979960
		public static implicit operator Vector2(JSON value); // 0x000000018197A5F0-0x000000018197A700
		public static explicit operator JSON(Vector2 value); // 0x0000000181979E90-0x0000000181979F90
		public static implicit operator Vector3(JSON value); // 0x000000018197A4F0-0x000000018197A5F0
		public static explicit operator JSON(Vector3 value); // 0x000000018197A270-0x000000018197A3B0
		public static implicit operator Quaternion(JSON value); // 0x000000018197A3B0-0x000000018197A4F0
		public static explicit operator JSON(Quaternion value); // 0x0000000181979BE0-0x0000000181979D40
		public static implicit operator Color(JSON value); // 0x000000018197A700-0x000000018197A840
		public static explicit operator JSON(Color value); // 0x0000000181979F90-0x000000018197A0F0
		public static implicit operator Color32(JSON value); // 0x000000018197A980-0x000000018197AAA0
		public static explicit operator JSON(Color32 value); // 0x0000000181979D40-0x0000000181979E90
		public static implicit operator Rect(JSON value); // 0x000000018197A840-0x000000018197A980
		public static explicit operator JSON(Rect value); // 0x000000018197A0F0-0x000000018197A270
		public T[] ToArray<T>(string fieldName);
	}
}
