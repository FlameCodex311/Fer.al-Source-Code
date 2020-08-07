/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace LitJson
{
	public class JsonMapper // TypeDefIndex: 16074
	{
		// Fields
		private static readonly int max_nesting_depth; // 0x00
		private static readonly IFormatProvider datetime_format; // 0x08
		private static readonly IDictionary<Type, ExporterFunc> base_exporters_table; // 0x10
		private static readonly IDictionary<Type, ExporterFunc> custom_exporters_table; // 0x18
		private static readonly IDictionary<Type, IDictionary<Type, ImporterFunc>> base_importers_table; // 0x20
		private static readonly IDictionary<Type, IDictionary<Type, ImporterFunc>> custom_importers_table; // 0x28
		private static readonly IDictionary<Type, ArrayMetadata> array_metadata; // 0x30
		private static readonly object array_metadata_lock; // 0x38
		private static readonly IDictionary<Type, IDictionary<Type, MethodInfo>> conv_ops; // 0x40
		private static readonly object conv_ops_lock; // 0x48
		private static readonly IDictionary<Type, ObjectMetadata> object_metadata; // 0x50
		private static readonly object object_metadata_lock; // 0x58
		private static readonly IDictionary<Type, IList<PropertyMetadata>> type_properties; // 0x60
		private static readonly object type_properties_lock; // 0x68
		private static readonly JsonWriter static_writer; // 0x70
		private static readonly object static_writer_lock; // 0x78
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 16075
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static WrapperFactory <>9__23_0; // 0x08
			public static ExporterFunc <>9__24_0; // 0x10
			public static ExporterFunc <>9__24_1; // 0x18
			public static ExporterFunc <>9__24_2; // 0x20
			public static ExporterFunc <>9__24_3; // 0x28
			public static ExporterFunc <>9__24_4; // 0x30
			public static ExporterFunc <>9__24_5; // 0x38
			public static ExporterFunc <>9__24_6; // 0x40
			public static ExporterFunc <>9__24_7; // 0x48
			public static ExporterFunc <>9__24_8; // 0x50
			public static ImporterFunc <>9__25_0; // 0x58
			public static ImporterFunc <>9__25_1; // 0x60
			public static ImporterFunc <>9__25_2; // 0x68
			public static ImporterFunc <>9__25_3; // 0x70
			public static ImporterFunc <>9__25_4; // 0x78
			public static ImporterFunc <>9__25_5; // 0x80
			public static ImporterFunc <>9__25_6; // 0x88
			public static ImporterFunc <>9__25_7; // 0x90
			public static ImporterFunc <>9__25_8; // 0x98
			public static ImporterFunc <>9__25_9; // 0xA0
			public static ImporterFunc <>9__25_10; // 0xA8
			public static ImporterFunc <>9__25_11; // 0xB0
			public static WrapperFactory <>9__30_0; // 0xB8
			public static WrapperFactory <>9__31_0; // 0xC0
			public static WrapperFactory <>9__32_0; // 0xC8
	
			// Constructors
			static <>c(); // 0x0000000180C5D920-0x0000000180C5D980
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal IJsonWrapper <ReadSkip>b__23_0(); // 0x0000000180C5C7A0-0x0000000180C5C7F0
			internal void <RegisterBaseExporters>b__24_0(object obj, JsonWriter writer); // 0x0000000180C5C7F0-0x0000000180C5C8A0
			internal void <RegisterBaseExporters>b__24_1(object obj, JsonWriter writer); // 0x0000000180C5C8A0-0x0000000180C5C950
			internal void <RegisterBaseExporters>b__24_2(object obj, JsonWriter writer); // 0x0000000180C5C950-0x0000000180C5CA40
			internal void <RegisterBaseExporters>b__24_3(object obj, JsonWriter writer); // 0x0000000180C5CA40-0x0000000180C5CAD0
			internal void <RegisterBaseExporters>b__24_4(object obj, JsonWriter writer); // 0x0000000180C5CAD0-0x0000000180C5CB80
			internal void <RegisterBaseExporters>b__24_5(object obj, JsonWriter writer); // 0x0000000180C5CB80-0x0000000180C5CC30
			internal void <RegisterBaseExporters>b__24_6(object obj, JsonWriter writer); // 0x0000000180C5CC30-0x0000000180C5CCE0
			internal void <RegisterBaseExporters>b__24_7(object obj, JsonWriter writer); // 0x0000000180C5CCE0-0x0000000180C5CD90
			internal void <RegisterBaseExporters>b__24_8(object obj, JsonWriter writer); // 0x0000000180C5CD90-0x0000000180C5CE10
			internal object <RegisterBaseImporters>b__25_0(object input); // 0x0000000180C5CE10-0x0000000180C5CEB0
			internal object <RegisterBaseImporters>b__25_1(object input); // 0x0000000180C5D010-0x0000000180C5D0B0
			internal object <RegisterBaseImporters>b__25_2(object input); // 0x0000000180C5D0B0-0x0000000180C5D150
			internal object <RegisterBaseImporters>b__25_3(object input); // 0x0000000180C5D150-0x0000000180C5D1F0
			internal object <RegisterBaseImporters>b__25_4(object input); // 0x0000000180C5D1F0-0x0000000180C5D290
			internal object <RegisterBaseImporters>b__25_5(object input); // 0x0000000180C5D290-0x0000000180C5D330
			internal object <RegisterBaseImporters>b__25_6(object input); // 0x0000000180C5D330-0x0000000180C5D3D0
			internal object <RegisterBaseImporters>b__25_7(object input); // 0x0000000180C5D3D0-0x0000000180C5D470
			internal object <RegisterBaseImporters>b__25_8(object input); // 0x0000000180C5D470-0x0000000180C5D510
			internal object <RegisterBaseImporters>b__25_9(object input); // 0x0000000180C5D510-0x0000000180C5D5B0
			internal object <RegisterBaseImporters>b__25_10(object input); // 0x0000000180C5CEB0-0x0000000180C5CF40
			internal object <RegisterBaseImporters>b__25_11(object input); // 0x0000000180C5CF40-0x0000000180C5D010
			internal IJsonWrapper <ToObject>b__30_0(); // 0x0000000180C5D5B0-0x0000000180C5D600
			internal IJsonWrapper <ToObject>b__31_0(); // 0x0000000180C5D600-0x0000000180C5D650
			internal IJsonWrapper <ToObject>b__32_0(); // 0x0000000180C5D650-0x0000000180C5D6A0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass39_0<T> // TypeDefIndex: 16076
		{
			// Fields
			public ExporterFunc<T> exporter;
	
			// Constructors
			public <>c__DisplayClass39_0();
	
			// Methods
			internal void <RegisterExporter>b__0(object obj, JsonWriter writer);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass40_0<TJson, TValue> // TypeDefIndex: 16077
		{
			// Fields
			public ImporterFunc<TJson, TValue> importer;
	
			// Constructors
			public <>c__DisplayClass40_0();
	
			// Methods
			internal object <RegisterImporter>b__0(object input);
		}
	
		// Constructors
		static JsonMapper(); // 0x0000000180C4F710-0x0000000180C4FA90
		public JsonMapper(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		private static void AddArrayMetadata(Type type); // 0x0000000180C49200-0x0000000180C49640
		private static void AddObjectMetadata(Type type); // 0x0000000180C49640-0x0000000180C49C70
		private static void AddTypeProperties(Type type); // 0x0000000180C49C70-0x0000000180C4A0A0
		private static MethodInfo GetConvOp(Type t1, Type t2); // 0x0000000180C4A0A0-0x0000000180C4A6B0
		private static object ReadValue(Type inst_type, JsonReader reader); // 0x0000000180C4A7F0-0x0000000180C4B910
		private static IJsonWrapper ReadValue(WrapperFactory factory, JsonReader reader); // 0x0000000180C4B910-0x0000000180C4BE70
		private static void ReadSkip(JsonReader reader); // 0x0000000180C4A6B0-0x0000000180C4A7F0
		private static void RegisterBaseExporters(); // 0x0000000180C4BE70-0x0000000180C4C920
		private static void RegisterBaseImporters(); // 0x0000000180C4C920-0x0000000180C4D6C0
		private static void RegisterImporter(IDictionary<Type, IDictionary<Type, ImporterFunc>> table, Type json_type, Type value_type, ImporterFunc importer); // 0x0000000180C4D6C0-0x0000000180C4D820
		private static void WriteValue(object obj, JsonWriter writer, bool writer_is_private, int depth); // 0x0000000180C4E360-0x0000000180C4F710
		public static string ToJson(object obj); // 0x0000000180C4D820-0x0000000180C4DA80
		public static void ToJson(object obj, JsonWriter writer); // 0x0000000180C4DA80-0x0000000180C4DAF0
		public static JsonData ToObject(JsonReader reader); // 0x0000000180C4DAF0-0x0000000180C4DC90
		public static JsonData ToObject(TextReader reader); // 0x0000000180C4DE90-0x0000000180C4E050
		public static JsonData ToObject(string json); // 0x0000000180C4DC90-0x0000000180C4DE90
		public static T ToObject<T>(JsonReader reader);
		public static T ToObject<T>(TextReader reader);
		public static T ToObject<T>(string json);
		public static object ToObject(string json, Type ConvertType); // 0x0000000180C4E050-0x0000000180C4E120
		public static IJsonWrapper ToWrapper(WrapperFactory factory, JsonReader reader); // 0x0000000180C4E1F0-0x0000000180C4E260
		public static IJsonWrapper ToWrapper(WrapperFactory factory, string json); // 0x0000000180C4E120-0x0000000180C4E1F0
		public static void RegisterExporter<T>(ExporterFunc<T> exporter);
		public static void RegisterImporter<TJson, TValue>(ImporterFunc<TJson, TValue> importer);
		public static void UnregisterExporters(); // 0x0000000180C4E260-0x0000000180C4E2E0
		public static void UnregisterImporters(); // 0x0000000180C4E2E0-0x0000000180C4E360
	}
}
