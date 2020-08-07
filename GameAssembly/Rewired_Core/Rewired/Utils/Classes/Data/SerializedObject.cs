/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml;
using Rewired;
using Rewired.Utils.Attributes;
using Rewired.Utils.Interfaces;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Utils.Classes.Data
{
	[CustomClassObfuscation] // 0x00000001801CEB30-0x00000001801CEBB0
	[CustomObfuscation] // 0x00000001801CEB30-0x00000001801CEBB0
	[Preserve] // 0x00000001801CEB30-0x00000001801CEBB0
	internal sealed class SerializedObject : IEnumerable<SerializedObject.Field>, IAddValue<object>, IAddKeyValue<string, object>, IExportToXml, IExportToJson // TypeDefIndex: 6980
	{
		// Fields
		private readonly IndexedDictionary<string, Entry> ySajSnFbKHgdVuFdAWJcCwTpOXg; // 0x10
		private XmlInfo sMQZevdFTstQSGQKnEcYIUdKaQg; // 0x18
		private Type qYQtZXCUUQiyGpzdDXLOHBOwcPe; // 0x20
		private ObjectType pEOEuicaoSrPbieyGjgaTOirLUe; // 0x28
		private static readonly Dictionary<Type, Dictionary<string, FieldInfo>> mtjDgwrsKHLyGpZcHneeBeJiCIF; // 0x00
		private static readonly Dictionary<Type, Dictionary<string, PropertyInfo>> KzybAcqvobVRsvNuDNHGjeCrgkWj; // 0x08
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Func<FieldInfo, bool> rMADKvwwlBDxGizQaeqoBdFZwld; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Func<FieldInfo, string> JTCXEGDxEOeUKhqiWcgWTpItzfs; // 0x18
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Func<PropertyInfo, bool> qKeWAGlhnvzAfpdHfrtZXCbPGPfH; // 0x20
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Func<PropertyInfo, string> EWlhMlrDrFKXLfmWfTVIDnhEqEQ; // 0x28
	
		// Properties
		private bool allowDuplicateKeys { get; } // 0x00000001810A8010-0x00000001810A8020 
		public ObjectType objectType { get; set; } // 0x000000018043C680-0x000000018043C690 0x00000001810A8270-0x00000001810A82D0
		public Type type { get; } // 0x0000000180374AF0-0x0000000180374B00 
		public XmlInfo xmlInfo { get; set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
		public int count { get; } // 0x00000001810A8020-0x00000001810A8070 
		public Field this[int index] { get => default; } // 0x00000001810A7F50-0x00000001810A8010 
		bool IExportToXml.writesOwnElementTag { get; } // 0x0000000180380B60-0x0000000180380B70 
	
		// Nested types
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public enum ObjectType // TypeDefIndex: 6981
		{
			Object = 0,
			List = 1
		}
	
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[Flags] // 0x00000001801D00E0-0x00000001801D0120
		public enum FieldOptions // TypeDefIndex: 6982
		{
			None = 0,
			ExculdeFromXml = 1
		}
	
		private struct Entry // TypeDefIndex: 6983
		{
			// Fields
			public Type type; // 0x00
			public object value; // 0x08
			public FieldOptions options; // 0x10
	
			// Constructors
			public Entry(Type type, object value, FieldOptions options); // 0x00000001800C16A0-0x00000001800C16D0
	
			// Methods
			public override string ToString(); // 0x00000001800C1690-0x00000001800C16A0
		}
	
		[CustomClassObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
		[CustomObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
		public struct Field // TypeDefIndex: 6984
		{
			// Fields
			public string name; // 0x00
			public object value; // 0x08
			public Type type; // 0x10
			public FieldOptions options; // 0x18
	
			// Constructors
			public Field(string name, object value, Type type, FieldOptions options); // 0x00000001800C19D0-0x00000001800C1A10
	
			// Methods
			public override string ToString(); // 0x00000001800C19C0-0x00000001800C19D0
		}
	
		[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
		[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
		public class XmlInfo // TypeDefIndex: 6985
		{
			// Fields
			private List<XmlAttribute> CjCObhIbdjJBbcPIpPIfpHmiUPx; // 0x10
	
			// Properties
			public List<XmlAttribute> attributes { get; } // 0x0000000181400ED0-0x0000000181400F40 
	
			// Nested types
			public abstract class XmlAttribute // TypeDefIndex: 6986
			{
				// Constructors
				protected XmlAttribute(); // 0x0000000180373240-0x0000000180373250
			}
	
			public class XmlStringAttribute : XmlAttribute // TypeDefIndex: 6987
			{
				// Fields
				public string prefix; // 0x10
				public string localName; // 0x18
				public string ns; // 0x20
				public string value; // 0x28
	
				// Constructors
				public XmlStringAttribute(); // 0x0000000180373240-0x0000000180373250
	
				// Methods
				public override string ToString(); // 0x0000000181400F40-0x0000000181401020
			}
	
			// Constructors
			public XmlInfo(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			public override string ToString(); // 0x0000000181400D40-0x0000000181400ED0
		}
	
		[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
		[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
		public struct Enumerator : IEnumerator<Field> // TypeDefIndex: 6988
		{
			// Fields
			private IndexedDictionary<string, Entry> PPzpPGLKIynvruBNxkGUfOVeEjO; // 0x00
			private Field hXsQEjeqlbsWHdImyyWjqLiDOxk; // 0x08
			private IEnumerator<KeyValuePair<string, Entry>> KkUPIlZfykaAVAeYrQJjyKHWghgJ; // 0x28
	
			// Properties
			public Field Current { get; } // 0x00000001800C1980-0x00000001800C19C0 
			object IEnumerator.Current { get; } // 0x00000001800C1870-0x00000001800C18C0 
	
			// Constructors
			internal Enumerator(object dictionary); // 0x00000001800C18C0-0x00000001800C1980
	
			// Methods
			public bool MoveNext(); // 0x00000001800C16D0-0x00000001800C1810
			public void Dispose(); // 0x0000000180003FD0-0x00000001800045A0
			void IEnumerator.Reset(); // 0x00000001800C1810-0x00000001800C1870
		}
	
		private class XmlDocument // TypeDefIndex: 6989
		{
			// Fields
			private readonly Element _root; // 0x10
	
			// Properties
			public Element root { get; } // 0x0000000180372440-0x0000000180372450 
			public bool isValid { get; } // 0x0000000181400D30-0x0000000181400D40 
	
			// Nested types
			public class Element // TypeDefIndex: 6990
			{
				// Fields
				public readonly string name; // 0x10
				public readonly Element parent; // 0x18
				public string content; // 0x20
				public Dictionary<string, string> attributes; // 0x28
				public List<Element> children; // 0x30
	
				// Properties
				public int childCount { get; } // 0x00000001813E7990-0x00000001813E7C90 
				public int attributeCount { get; } // 0x00000001813E7940-0x00000001813E7990 
	
				// Constructors
				public Element(string name, Element parent); // 0x00000001813E7860-0x00000001813E7940
	
				// Methods
				public void AddChild(Element element); // 0x00000001813E62C0-0x00000001813E6380
				public void AddAttribute(string key, string value); // 0x00000001813E6170-0x00000001813E62C0
				public bool ContainsChild(string name); // 0x00000001813E6380-0x00000001813E64E0
				public Element FindChild(string name); // 0x00000001813E64E0-0x00000001813E6640
				public object GetSerializedObject(); // 0x00000001813E6640-0x00000001813E67F0
				public override string ToString(); // 0x00000001813E67F0-0x00000001813E6830
				private string ToString(string s, int indent); // 0x00000001813E6830-0x00000001813E7860
			}
	
			// Constructors
			public XmlDocument(string xml); // 0x0000000181400B40-0x0000000181400D30
	
			// Methods
			private void ReadAll(XmlReader reader); // 0x00000001814003D0-0x0000000181400AA0
			public override string ToString(); // 0x0000000181400AA0-0x0000000181400B40
		}
	
		// Constructors
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private SerializedObject(); // 0x00000001810A7DD0-0x00000001810A7E40
		private SerializedObject(int capacity); // 0x00000001810A7CC0-0x00000001810A7D40
		public SerializedObject(Type type, ObjectType objectType); // 0x00000001810A7950-0x00000001810A7970
		public SerializedObject(Type type, ObjectType objectType, int capacity); // 0x00000001810A7D40-0x00000001810A7DD0
		public SerializedObject(Type type, IDictionary<string, object> dictionary, ObjectType objectType); // 0x00000001810A7970-0x00000001810A7CC0
		static SerializedObject(); // 0x00000001810A78C0-0x00000001810A7950
	
		// Methods
		public void Add<T>(string fieldName, T value, FieldOptions options = FieldOptions.None /* Metadata: 0x0076664A */);
		public void Add(Type type, string fieldName, object value, FieldOptions options = FieldOptions.None /* Metadata: 0x0076664E */); // 0x000000018109BD30-0x000000018109C050
		public void Add(string fieldName, object value); // 0x000000018109C050-0x000000018109C0C0
		public bool Remove(string fieldName); // 0x000000018109CA30-0x000000018109CAA0
		public bool Contains(string fieldName); // 0x000000018109C0C0-0x000000018109C130
		public Type GetDataType(string fieldName); // 0x000000018109C820-0x000000018109C8D0
		public bool TryGetOriginalValue(string fieldName, out object value); // 0x00000001810A7320-0x00000001810A73D0
		public Field GetEntry(string fieldName); // 0x000000018109C8D0-0x000000018109C970
		public object GetOriginalValue(string fieldName); // 0x000000018109C9D0-0x000000018109CA30
		public object GetOriginalValue(int index); // 0x000000018109C970-0x000000018109C9D0
		public T GetOriginalValue<T>(string fieldName);
		public T GetOriginalValue<T>(int index);
		public bool TryGetDeserializedValue<T>(string fieldName, out T value);
		public bool TryGetDeserializedValue<T>(int index, out T value);
		public bool TryGetDeserializedValueByRef<T>(string fieldName, ref T value);
		public bool TryGetDeserializedValueByRef<T>(int index, ref T value);
		public string ToXmlString(bool writeDocumentTag); // 0x000000018109D4F0-0x000000018109D8E0
		public string ToJsonString(); // 0x000000018109D110-0x000000018109D120
		public override string ToString(); // 0x000000018109D120-0x000000018109D4F0
		private void WriteXml(XmlWriter writer); // 0x000000018109CEF0-0x000000018109CFF0
		private void WriteXml_Value(XmlWriter writer); // 0x00000001810A73D0-0x00000001810A78C0
		void IExportToXml.WriteXml(XmlWriter writer); // 0x000000018109CEF0-0x000000018109CFF0
		void IExportToJson.WriteJson(StringBuilder stringBuilder, Action<StringBuilder, object> appendValueDelegate); // 0x000000018109CB00-0x000000018109CEF0
		void IAddValue<object>.Add(object value); // 0x000000018109CAA0-0x000000018109CB00
		void IAddKeyValue<string, object>.Add(string key, object value); // 0x000000018109C050-0x000000018109C0C0
		IEnumerator<Field> System.Collections.Generic.IEnumerable<Rewired.Utils.Classes.Data.SerializedObject.Field>.GetEnumerator(); // 0x000000018109CFF0-0x000000018109D080
		IEnumerator IEnumerable.GetEnumerator(); // 0x000000018109D080-0x000000018109D110
		private static bool TryConvertOrCreateObject<T>(object obj, out T result, NumberStyles numberStyle = NumberStyles.None | NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent | NumberStyles.AllowCurrencySymbol | NumberStyles.Integer | NumberStyles.Number | NumberStyles.Float | NumberStyles.Currency | NumberStyles.Any /* Metadata: 0x00766652 */, CultureInfo cultureInfo = null);
		private static bool TryConvertOrCreateObject(Type targetType, object obj, out object result, NumberStyles numberStyle = NumberStyles.None | NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent | NumberStyles.AllowCurrencySymbol | NumberStyles.Integer | NumberStyles.Number | NumberStyles.Float | NumberStyles.Currency | NumberStyles.Any /* Metadata: 0x00766656 */, CultureInfo cultureInfo = null); // 0x000000018109D8E0-0x00000001810A69C0
		private static bool TryCreateObject(Type type, SerializedObject serializedObject, out object result, NumberStyles numberStyle = NumberStyles.None | NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowTrailingSign | NumberStyles.AllowParentheses | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent | NumberStyles.AllowCurrencySymbol | NumberStyles.Integer | NumberStyles.Number | NumberStyles.Float | NumberStyles.Currency | NumberStyles.Any /* Metadata: 0x0076665A */, CultureInfo cultureInfo = null); // 0x00000001810A69C0-0x00000001810A7320
		public static SerializedObject FromJson(Type type, string jsonString); // 0x000000018109C2F0-0x000000018109C500
		public static SerializedObject FromXml(Type type, string xmlString); // 0x000000018109C500-0x000000018109C820
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static bool hTMmGFUzslkPOpeckvSuGKZifFM(FieldInfo param_0000eea7); // 0x00000001810A8070-0x00000001810A8270
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static string EOKBSkHDOwjZsiFoXGItfFheNaH(FieldInfo param_0000eea8); // 0x000000018109C130-0x000000018109C2F0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static bool dfbvxYLwDGmNWNvGvVcTWxGNSDW(PropertyInfo param_0000eea9); // 0x00000001810A7E40-0x00000001810A7F50
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static string sxEANbGdTKXGUGDohUfWhrwXRnqk(PropertyInfo param_0000eeaa); // 0x00000001810A82D0-0x00000001810A8490
	}
}
