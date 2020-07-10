/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace LitJson
{
	public class JsonMapper // TypeDefIndex: 15419
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
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 15420
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
			static <>c(); // 0x00000001811F66B0-0x00000001811F6710
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal IJsonWrapper <ReadSkip>b__23_0(); // 0x00000001811F5470-0x00000001811F54C0
			internal void <RegisterBaseExporters>b__24_0(object obj, JsonWriter writer); // 0x00000001811F54C0-0x00000001811F5570
			internal void <RegisterBaseExporters>b__24_1(object obj, JsonWriter writer); // 0x00000001811F5570-0x00000001811F5620
			internal void <RegisterBaseExporters>b__24_2(object obj, JsonWriter writer); // 0x00000001811F5620-0x00000001811F5710
			internal void <RegisterBaseExporters>b__24_3(object obj, JsonWriter writer); // 0x00000001811F5710-0x00000001811F57A0
			internal void <RegisterBaseExporters>b__24_4(object obj, JsonWriter writer); // 0x00000001811F57A0-0x00000001811F5850
			internal void <RegisterBaseExporters>b__24_5(object obj, JsonWriter writer); // 0x00000001811F5850-0x00000001811F5900
			internal void <RegisterBaseExporters>b__24_6(object obj, JsonWriter writer); // 0x00000001811F5900-0x00000001811F59B0
			internal void <RegisterBaseExporters>b__24_7(object obj, JsonWriter writer); // 0x00000001811F59B0-0x00000001811F5A60
			internal void <RegisterBaseExporters>b__24_8(object obj, JsonWriter writer); // 0x00000001811F5A60-0x00000001811F5AE0
			internal object <RegisterBaseImporters>b__25_0(object input); // 0x00000001811F5AE0-0x00000001811F5B80
			internal object <RegisterBaseImporters>b__25_1(object input); // 0x00000001811F5CE0-0x00000001811F5D80
			internal object <RegisterBaseImporters>b__25_2(object input); // 0x00000001811F5D80-0x00000001811F5E20
			internal object <RegisterBaseImporters>b__25_3(object input); // 0x00000001811F5E20-0x00000001811F5EC0
			internal object <RegisterBaseImporters>b__25_4(object input); // 0x00000001811F5EC0-0x00000001811F5F60
			internal object <RegisterBaseImporters>b__25_5(object input); // 0x00000001811F5F60-0x00000001811F6000
			internal object <RegisterBaseImporters>b__25_6(object input); // 0x00000001811F6000-0x00000001811F60A0
			internal object <RegisterBaseImporters>b__25_7(object input); // 0x00000001811F60A0-0x00000001811F6140
			internal object <RegisterBaseImporters>b__25_8(object input); // 0x00000001811F6140-0x00000001811F61F0
			internal object <RegisterBaseImporters>b__25_9(object input); // 0x00000001811F61F0-0x00000001811F6290
			internal object <RegisterBaseImporters>b__25_10(object input); // 0x00000001811F5B80-0x00000001811F5C10
			internal object <RegisterBaseImporters>b__25_11(object input); // 0x00000001811F5C10-0x00000001811F5CE0
			internal IJsonWrapper <ToObject>b__30_0(); // 0x00000001811F6290-0x00000001811F62E0
			internal IJsonWrapper <ToObject>b__31_0(); // 0x00000001811F62E0-0x00000001811F6330
			internal IJsonWrapper <ToObject>b__32_0(); // 0x00000001811F6330-0x00000001811F6380
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass39_0<T> // TypeDefIndex: 15421
		{
			// Fields
			public ExporterFunc<T> exporter;
	
			// Constructors
			public <>c__DisplayClass39_0();
	
			// Methods
			internal void <RegisterExporter>b__0(object obj, JsonWriter writer);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass40_0<TJson, TValue> // TypeDefIndex: 15422
		{
			// Fields
			public ImporterFunc<TJson, TValue> importer;
	
			// Constructors
			public <>c__DisplayClass40_0();
	
			// Methods
			internal object <RegisterImporter>b__0(object input);
		}
	
		// Constructors
		static JsonMapper(); // 0x00000001812CAC10-0x00000001812CAF20
		public JsonMapper(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		private static void AddArrayMetadata(Type type); // 0x00000001812C47B0-0x00000001812C4C00
		private static void AddObjectMetadata(Type type); // 0x00000001812C4C00-0x00000001812C5250
		private static void AddTypeProperties(Type type); // 0x00000001812C5250-0x00000001812C56A0
		private static MethodInfo GetConvOp(Type t1, Type t2); // 0x00000001812C56A0-0x00000001812C5CD0
		private static object ReadValue(Type inst_type, JsonReader reader); // 0x00000001812C5E10-0x00000001812C6F00
		private static IJsonWrapper ReadValue(WrapperFactory factory, JsonReader reader); // 0x00000001812C6F00-0x00000001812C7470
		private static void ReadSkip(JsonReader reader); // 0x00000001812C5CD0-0x00000001812C5E10
		private static void RegisterBaseExporters(); // 0x00000001812C7470-0x00000001812C7F40
		private static void RegisterBaseImporters(); // 0x00000001812C7F40-0x00000001812C8CE0
		private static void RegisterImporter(IDictionary<Type, IDictionary<Type, ImporterFunc>> table, Type json_type, Type value_type, ImporterFunc importer); // 0x00000001812C8CE0-0x00000001812C8E40
		private static void WriteValue(object obj, JsonWriter writer, bool writer_is_private, int depth); // 0x00000001812C9800-0x00000001812CAC10
		public static string ToJson(object obj); // 0x00000001812C8E40-0x00000001812C8FF0
		public static void ToJson(object obj, JsonWriter writer); // 0x00000001812C8FF0-0x00000001812C9060
		public static JsonData ToObject(JsonReader reader); // 0x00000001812C9060-0x00000001812C9200
		public static JsonData ToObject(TextReader reader); // 0x00000001812C93B0-0x00000001812C9570
		public static JsonData ToObject(string json); // 0x00000001812C9200-0x00000001812C93B0
		public static T ToObject<T>(JsonReader reader);
		public static T ToObject<T>(TextReader reader);
		public static T ToObject<T>(string json);
		public static object ToObject(string json, Type ConvertType); // 0x00000001812C9570-0x00000001812C9600
		public static IJsonWrapper ToWrapper(WrapperFactory factory, JsonReader reader); // 0x00000001812C9690-0x00000001812C9700
		public static IJsonWrapper ToWrapper(WrapperFactory factory, string json); // 0x00000001812C9600-0x00000001812C9690
		public static void RegisterExporter<T>(ExporterFunc<T> exporter);
		public static void RegisterImporter<TJson, TValue>(ImporterFunc<TJson, TValue> importer);
		public static void UnregisterExporters(); // 0x00000001812C9700-0x00000001812C9780
		public static void UnregisterImporters(); // 0x00000001812C9780-0x00000001812C9800
	}
}
