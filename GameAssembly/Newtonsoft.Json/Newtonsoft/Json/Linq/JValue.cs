/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Linq
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class JValue : JToken, IFormattable, IComparable, IEquatable<JValue>, IComparable<JValue>, IConvertible // TypeDefIndex: 8157
	{
		// Fields
		private JTokenType _valueType; // 0x30
		private object _value; // 0x38
	
		// Properties
		public override bool HasValues { get; } // 0x0000000180380950-0x0000000180380960 
		public override JTokenType Type { get; } // 0x00000001804AA650-0x00000001804AA660 
		public object Value { get; } // 0x00000001803743D0-0x00000001803743E0 
	
		// Constructors
		internal JValue(object value, JTokenType type); // 0x000000018184A010-0x000000018184A090
		public JValue(JValue other); // 0x000000018184A090-0x000000018184A160
		public JValue(object value); // 0x0000000181849F90-0x000000018184A010
	
		// Methods
		internal override bool DeepEquals(JToken node); // 0x0000000181848420-0x00000001818484F0
		internal static int Compare(JTokenType valueType, object objA, object objB); // 0x00000001818478C0-0x0000000181848260
		private static int CompareFloat(object objA, object objB); // 0x00000001818477B0-0x00000001818478A0
		internal override JToken CloneToken(); // 0x0000000181847750-0x00000001818477B0
		public static JValue CreateComment(string value); // 0x0000000181848260-0x0000000181848300
		public static JValue CreateNull(); // 0x0000000181848300-0x0000000181848390
		public static JValue CreateUndefined(); // 0x0000000181848390-0x0000000181848420
		private static JTokenType GetValueType(JTokenType? current, object value); // 0x00000001818486F0-0x0000000181848B00
		private static JTokenType GetStringValueType(JTokenType? current); // 0x0000000181848690-0x00000001818486F0
		public override void WriteTo(JsonWriter writer, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ JsonConverter[] converters); // 0x0000000181849520-0x0000000181849F90
		internal override int GetDeepHashCode(); // 0x0000000181848620-0x0000000181848670
		private static bool ValuesEquals(JValue v1, JValue v2); // 0x00000001818494C0-0x0000000181849520
		public bool Equals(JValue other); // 0x00000001818485D0-0x0000000181848620
		public override bool Equals(object obj); // 0x00000001818484F0-0x00000001818485D0
		public override int GetHashCode(); // 0x0000000181848670-0x0000000181848690
		public override string ToString(); // 0x0000000181849200-0x0000000181849260
		public string ToString(IFormatProvider formatProvider); // 0x0000000181849260-0x0000000181849380
		public string ToString(string format, IFormatProvider formatProvider); // 0x0000000181849380-0x00000001818494C0
		int IComparable.CompareTo(object obj); // 0x0000000181848B00-0x0000000181848C30
		public int CompareTo(JValue obj); // 0x00000001818478A0-0x00000001818478C0
		TypeCode IConvertible.GetTypeCode(); // 0x0000000181848C30-0x0000000181848CA0
		bool IConvertible.ToBoolean(IFormatProvider provider); // 0x0000000181848CA0-0x0000000181848D00
		char IConvertible.ToChar(IFormatProvider provider); // 0x0000000181848D60-0x0000000181848DC0
		sbyte IConvertible.ToSByte(IFormatProvider provider); // 0x0000000181849010-0x0000000181849070
		byte IConvertible.ToByte(IFormatProvider provider); // 0x0000000181848D00-0x0000000181848D60
		short IConvertible.ToInt16(IFormatProvider provider); // 0x0000000181848EF0-0x0000000181848F50
		ushort IConvertible.ToUInt16(IFormatProvider provider); // 0x00000001818490E0-0x0000000181849140
		int IConvertible.ToInt32(IFormatProvider provider); // 0x0000000181848F50-0x0000000181848FB0
		uint IConvertible.ToUInt32(IFormatProvider provider); // 0x0000000181849140-0x00000001818491A0
		long IConvertible.ToInt64(IFormatProvider provider); // 0x0000000181848FB0-0x0000000181849010
		ulong IConvertible.ToUInt64(IFormatProvider provider); // 0x00000001818491A0-0x0000000181849200
		float IConvertible.ToSingle(IFormatProvider provider); // 0x0000000181849070-0x00000001818490D0
		double IConvertible.ToDouble(IFormatProvider provider); // 0x0000000181848E90-0x0000000181848EF0
		decimal IConvertible.ToDecimal(IFormatProvider provider); // 0x0000000181848E20-0x0000000181848E90
		DateTime IConvertible.ToDateTime(IFormatProvider provider); // 0x0000000181848DC0-0x0000000181848E20
		object IConvertible.ToType(Type conversionType, IFormatProvider provider); // 0x00000001818490D0-0x00000001818490E0
	}
}
