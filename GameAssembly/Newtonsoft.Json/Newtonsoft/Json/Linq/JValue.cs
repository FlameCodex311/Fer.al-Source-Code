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

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Linq
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	public class JValue : JToken, IFormattable, IComparable, IEquatable<JValue>, IComparable<JValue>, IConvertible // TypeDefIndex: 7991
	{
		// Fields
		private JTokenType _valueType; // 0x30
		private object _value; // 0x38
	
		// Properties
		public override bool HasValues { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public override JTokenType Type { get; } // 0x000000018043DDC0-0x000000018043DDD0 
		public object Value { get; } // 0x0000000180369BB0-0x0000000180369BC0 
	
		// Constructors
		internal JValue(object value, JTokenType type); // 0x00000001804E6760-0x00000001804E67E0
		public JValue(JValue other); // 0x00000001804E67E0-0x00000001804E68C0
		public JValue(object value); // 0x00000001804E66E0-0x00000001804E6760
	
		// Methods
		internal override bool DeepEquals(JToken node); // 0x00000001804E4B40-0x00000001804E4C10
		internal static int Compare(JTokenType valueType, object objA, object objB); // 0x00000001804E3FD0-0x00000001804E4980
		private static int CompareFloat(object objA, object objB); // 0x00000001804E3EC0-0x00000001804E3FB0
		internal override JToken CloneToken(); // 0x00000001804E3DC0-0x00000001804E3EC0
		public static JValue CreateComment(string value); // 0x00000001804E4980-0x00000001804E4A20
		public static JValue CreateNull(); // 0x00000001804E4A20-0x00000001804E4AB0
		public static JValue CreateUndefined(); // 0x00000001804E4AB0-0x00000001804E4B40
		private static JTokenType GetValueType(JTokenType? current, object value); // 0x00000001804E4E10-0x00000001804E5220
		private static JTokenType GetStringValueType(JTokenType? current); // 0x00000001804E4DB0-0x00000001804E4E10
		public override void WriteTo(JsonWriter writer, params /* 0x00000001800B36B0-0x00000001800B36C0 */ JsonConverter[] converters); // 0x00000001804E5C40-0x00000001804E66E0
		internal override int GetDeepHashCode(); // 0x00000001804E4D40-0x00000001804E4D90
		private static bool ValuesEquals(JValue v1, JValue v2); // 0x00000001804E5BE0-0x00000001804E5C40
		public bool Equals(JValue other); // 0x00000001804E4CF0-0x00000001804E4D40
		public override bool Equals(object obj); // 0x00000001804E4C10-0x00000001804E4CF0
		public override int GetHashCode(); // 0x00000001804E4D90-0x00000001804E4DB0
		public override string ToString(); // 0x00000001804E5920-0x00000001804E5980
		public string ToString(IFormatProvider formatProvider); // 0x00000001804E5980-0x00000001804E5AA0
		public string ToString(string format, IFormatProvider formatProvider); // 0x00000001804E5AA0-0x00000001804E5BE0
		int IComparable.CompareTo(object obj); // 0x00000001804E5220-0x00000001804E5350
		public int CompareTo(JValue obj); // 0x00000001804E3FB0-0x00000001804E3FD0
		TypeCode IConvertible.GetTypeCode(); // 0x00000001804E5350-0x00000001804E53C0
		bool IConvertible.ToBoolean(IFormatProvider provider); // 0x00000001804E53C0-0x00000001804E5420
		char IConvertible.ToChar(IFormatProvider provider); // 0x00000001804E5480-0x00000001804E54E0
		sbyte IConvertible.ToSByte(IFormatProvider provider); // 0x00000001804E5730-0x00000001804E5790
		byte IConvertible.ToByte(IFormatProvider provider); // 0x00000001804E5420-0x00000001804E5480
		short IConvertible.ToInt16(IFormatProvider provider); // 0x00000001804E5610-0x00000001804E5670
		ushort IConvertible.ToUInt16(IFormatProvider provider); // 0x00000001804E5800-0x00000001804E5860
		int IConvertible.ToInt32(IFormatProvider provider); // 0x00000001804E5670-0x00000001804E56D0
		uint IConvertible.ToUInt32(IFormatProvider provider); // 0x00000001804E5860-0x00000001804E58C0
		long IConvertible.ToInt64(IFormatProvider provider); // 0x00000001804E56D0-0x00000001804E5730
		ulong IConvertible.ToUInt64(IFormatProvider provider); // 0x00000001804E58C0-0x00000001804E5920
		float IConvertible.ToSingle(IFormatProvider provider); // 0x00000001804E5790-0x00000001804E57F0
		double IConvertible.ToDouble(IFormatProvider provider); // 0x00000001804E55B0-0x00000001804E5610
		decimal IConvertible.ToDecimal(IFormatProvider provider); // 0x00000001804E5540-0x00000001804E55B0
		DateTime IConvertible.ToDateTime(IFormatProvider provider); // 0x00000001804E54E0-0x00000001804E5540
		object IConvertible.ToType(Type conversionType, IFormatProvider provider); // 0x00000001804E57F0-0x00000001804E5800
	}
}
