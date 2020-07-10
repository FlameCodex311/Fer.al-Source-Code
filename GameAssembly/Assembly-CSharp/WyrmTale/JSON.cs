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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WyrmTale
{
	public class JSON // TypeDefIndex: 15373
	{
		// Fields
		public string originalJSON; // 0x10
		public Dictionary<string, object> fields; // 0x18
	
		// Properties
		public object this[string fieldName] { get => default; set {} } // 0x0000000181F2DD20-0x0000000181F2DDB0 0x0000000181F2ED50-0x0000000181F2EE10
		public string serialized { get; set; } // 0x0000000181F2DDB0-0x0000000181F2DE70 0x0000000181F2EE10-0x0000000181F2EE50
	
		// Nested types
		private sealed class _JSON // TypeDefIndex: 15374
		{
			// Nested types
			private sealed class Parser : IDisposable // TypeDefIndex: 15375
			{
				// Fields
				private const string WHITE_SPACE = " \t\n\r"; // Metadata: 0x00784820
				private const string WORD_BREAK = " \t\n\r{}[],:\""; // Metadata: 0x00784828
				private StringReader json; // 0x10
	
				// Properties
				private char PeekChar { get; } // 0x0000000181F306D0-0x0000000181F30750 
				private char NextChar { get; } // 0x0000000181F30280-0x0000000181F30300 
				private string NextWord { get; } // 0x0000000181F305C0-0x0000000181F306D0 
				private TOKEN NextToken { get; } // 0x0000000181F30300-0x0000000181F305C0 
	
				// Nested types
				private enum TOKEN // TypeDefIndex: 15376
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
				private Parser(string jsonString); // 0x0000000181F30210-0x0000000181F30280
	
				// Methods
				public static JSON Parse(string jsonString); // 0x0000000181F30090-0x0000000181F30210
				public void Dispose(); // 0x0000000181F2F620-0x0000000181F2F650
				private JSON ParseObject(); // 0x0000000181F2FB50-0x0000000181F2FCF0
				private List<object> ParseArray(); // 0x0000000181F2F710-0x0000000181F2F7E0
				private object ParseValue(); // 0x0000000181F30060-0x0000000181F30090
				private object ParseByToken(TOKEN token); // 0x0000000181F2F7E0-0x0000000181F2FA60
				private string ParseString(); // 0x0000000181F2FCF0-0x0000000181F30060
				private object ParseNumber(); // 0x0000000181F2FA60-0x0000000181F2FB50
				private void EatWhitespace(); // 0x0000000181F2F650-0x0000000181F2F710
			}
	
			private sealed class Serializer // TypeDefIndex: 15377
			{
				// Fields
				private StringBuilder builder; // 0x10
	
				// Constructors
				private Serializer(); // 0x0000000181F336A0-0x0000000181F33700
	
				// Methods
				public static string Serialize(JSON obj); // 0x0000000181F2DDB0-0x0000000181F2DE70
				private void SerializeValue(object value); // 0x0000000181F33310-0x0000000181F336A0
				private void SerializeObject(JSON obj); // 0x0000000181F32E10-0x0000000181F32E40
				private void SerializeDictionary(IDictionary obj); // 0x0000000181F32B40-0x0000000181F32E10
				private void SerializeArray(IList anArray); // 0x0000000181F32910-0x0000000181F32B40
				private void SerializeString(string str); // 0x0000000181F32FC0-0x0000000181F33310
				private void SerializeOther(object value); // 0x0000000181F32E40-0x0000000181F32FC0
			}
	
			// Constructors
			public _JSON(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			public static JSON Deserialize(string json); // 0x0000000181F3E1A0-0x0000000181F3E1B0
			public static string Serialize(JSON obj); // 0x0000000181F2DDB0-0x0000000181F2DE70
		}
	
		// Constructors
		public JSON(); // 0x0000000181F2DCB0-0x0000000181F2DD20
	
		// Methods
		public string ToString(string fieldName); // 0x0000000181F2DBF0-0x0000000181F2DCB0
		public int ToInt(string fieldName); // 0x0000000181F2DA20-0x0000000181F2DAD0
		public float ToFloat(string fieldName); // 0x0000000181F2D970-0x0000000181F2DA20
		public bool ToBoolean(string fieldName); // 0x0000000181F2D8C0-0x0000000181F2D970
		public JSON ToJSON(string fieldName); // 0x0000000181F2DAD0-0x0000000181F2DBF0
		public static implicit operator Vector2(JSON value); // 0x0000000181F2E890-0x0000000181F2E9A0
		public static explicit operator JSON(Vector2 value); // 0x0000000181F2E120-0x0000000181F2E220
		public static implicit operator Vector3(JSON value); // 0x0000000181F2E780-0x0000000181F2E890
		public static explicit operator JSON(Vector3 value); // 0x0000000181F2E500-0x0000000181F2E640
		public static implicit operator Quaternion(JSON value); // 0x0000000181F2E640-0x0000000181F2E780
		public static explicit operator JSON(Quaternion value); // 0x0000000181F2DE70-0x0000000181F2DFD0
		public static implicit operator Color(JSON value); // 0x0000000181F2E9A0-0x0000000181F2EAE0
		public static explicit operator JSON(Color value); // 0x0000000181F2E220-0x0000000181F2E380
		public static implicit operator Color32(JSON value); // 0x0000000181F2EC30-0x0000000181F2ED50
		public static explicit operator JSON(Color32 value); // 0x0000000181F2DFD0-0x0000000181F2E120
		public static implicit operator Rect(JSON value); // 0x0000000181F2EAE0-0x0000000181F2EC30
		public static explicit operator JSON(Rect value); // 0x0000000181F2E380-0x0000000181F2E500
		public T[] ToArray<T>(string fieldName);
	}
}
