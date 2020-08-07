/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer.Internal;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia.FullSerializer
{
	public class fsSerializer // TypeDefIndex: 9304
	{
		// Fields
		private static HashSet<string> _reservedKeywords; // 0x00
		private const string Key_ObjectReference = "$ref"; // Metadata: 0x00778FB9
		private const string Key_ObjectDefinition = "$id"; // Metadata: 0x00778FC1
		private const string Key_InstanceType = "$type"; // Metadata: 0x00778FC8
		private const string Key_Version = "$version"; // Metadata: 0x00778FD1
		private const string Key_Content = "$content"; // Metadata: 0x00778FDD
		private Dictionary<Type, fsBaseConverter> _cachedConverters; // 0x10
		private Dictionary<Type, List<fsObjectProcessor>> _cachedProcessors; // 0x18
		private readonly List<fsConverter> _availableConverters; // 0x20
		private readonly Dictionary<Type, fsDirectConverter> _availableDirectConverters; // 0x28
		private readonly List<fsObjectProcessor> _processors; // 0x30
		private readonly fsCyclicReferenceManager _references; // 0x38
		private readonly fsLazyCycleDefinitionWriter _lazyReferenceWriter; // 0x40
		public fsContext Context; // 0x48
	
		// Nested types
		internal class fsLazyCycleDefinitionWriter // TypeDefIndex: 9305
		{
			// Fields
			private Dictionary<int, fsData> _pendingDefinitions; // 0x10
			private HashSet<int> _references; // 0x18
	
			// Constructors
			public fsLazyCycleDefinitionWriter(); // 0x0000000180E4EB80-0x0000000180E4EC00
	
			// Methods
			public void WriteDefinition(int id, fsData data); // 0x0000000180E4E7A0-0x0000000180E4E940
			public void WriteReference(int id, Dictionary<string, fsData> dict); // 0x0000000180E4E940-0x0000000180E4EB80
			public void Clear(); // 0x0000000180E4E750-0x0000000180E4E7A0
		}
	
		// Constructors
		static fsSerializer(); // 0x0000000180E52D30-0x0000000180E52E10
		public fsSerializer(); // 0x0000000180E52E10-0x0000000180E534A0
	
		// Methods
		public static bool IsReservedKeyword(string key); // 0x0000000180E52350-0x0000000180E523D0
		private static bool IsObjectReference(fsData data); // 0x0000000180E522D0-0x0000000180E52350
		private static bool IsObjectDefinition(fsData data); // 0x0000000180E52250-0x0000000180E522D0
		private static bool IsVersioned(fsData data); // 0x0000000180E52450-0x0000000180E524D0
		private static bool IsTypeSpecified(fsData data); // 0x0000000180E523D0-0x0000000180E52450
		private static bool IsWrappedData(fsData data); // 0x0000000180E524D0-0x0000000180E52550
		public static void StripDeserializationMetadata(ref fsData data); // 0x0000000180E52550-0x0000000180E526C0
		private static void ConvertLegacyData(ref fsData data); // 0x0000000180E4F730-0x0000000180E4FA90
		private static void Invoke_OnBeforeSerialize(List<fsObjectProcessor> processors, Type storageType, object instance); // 0x0000000180E52190-0x0000000180E52250
		private static void Invoke_OnAfterSerialize(List<fsObjectProcessor> processors, Type storageType, object instance, ref fsData data); // 0x0000000180E51F50-0x0000000180E52010
		private static void Invoke_OnBeforeDeserialize(List<fsObjectProcessor> processors, Type storageType, ref fsData data); // 0x0000000180E520D0-0x0000000180E52190
		private static void Invoke_OnBeforeDeserializeAfterInstanceCreation(List<fsObjectProcessor> processors, Type storageType, object instance, ref fsData data); // 0x0000000180E52010-0x0000000180E520D0
		private static void Invoke_OnAfterDeserialize(List<fsObjectProcessor> processors, Type storageType, object instance); // 0x0000000180E51E90-0x0000000180E51F50
		private static void EnsureDictionary(fsData data); // 0x0000000180E4FA90-0x0000000180E4FB30
		public void AddProcessor(fsObjectProcessor processor); // 0x0000000180E4F6B0-0x0000000180E4F730
		private List<fsObjectProcessor> GetProcessors(Type type); // 0x0000000180E4FF00-0x0000000180E501A0
		public void AddConverter(fsBaseConverter converter); // 0x0000000180E4F420-0x0000000180E4F6B0
		private fsBaseConverter GetConverter(Type type); // 0x0000000180E4FB30-0x0000000180E4FF00
		public fsResult TrySerialize<T>(T instance, out fsData data);
		public fsResult TryDeserialize<T>(fsData data, ref T instance);
		public fsResult TrySerialize(Type storageType, object instance, out fsData data); // 0x0000000180E52A90-0x0000000180E52D30
		private fsResult InternalSerialize_1_ProcessCycles(Type storageType, object instance, out fsData data); // 0x0000000180E51430-0x0000000180E51940
		private fsResult InternalSerialize_2_Inheritance(Type storageType, object instance, out fsData data); // 0x0000000180E51940-0x0000000180E51B20
		private fsResult InternalSerialize_3_ProcessVersioning(object instance, out fsData data); // 0x0000000180E51B20-0x0000000180E51DE0
		private fsResult InternalSerialize_4_Converter(object instance, out fsData data); // 0x0000000180E51DE0-0x0000000180E51E90
		public fsResult TryDeserialize(fsData data, Type storageType, ref object result); // 0x0000000180E526C0-0x0000000180E52A90
		private fsResult InternalDeserialize_1_CycleReference(fsData data, Type storageType, ref object result, out List<fsObjectProcessor> processors); // 0x0000000180E501A0-0x0000000180E503B0
		private fsResult InternalDeserialize_2_Version(fsData data, Type storageType, ref object result, out List<fsObjectProcessor> processors); // 0x0000000180E503B0-0x0000000180E508F0
		private fsResult InternalDeserialize_3_Inheritance(fsData data, Type storageType, ref object result, out List<fsObjectProcessor> processors); // 0x0000000180E508F0-0x0000000180E51050
		private fsResult InternalDeserialize_4_Cycles(fsData data, Type resultType, ref object result); // 0x0000000180E51050-0x0000000180E512D0
		private fsResult InternalDeserialize_5_Converter(fsData data, Type resultType, ref object result); // 0x0000000180E512D0-0x0000000180E51430
	}
}
