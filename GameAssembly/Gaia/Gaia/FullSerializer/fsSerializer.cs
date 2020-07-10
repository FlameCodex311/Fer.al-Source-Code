/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer.Internal;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia.FullSerializer
{
	public class fsSerializer // TypeDefIndex: 9132
	{
		// Fields
		private static HashSet<string> _reservedKeywords; // 0x00
		private const string Key_ObjectReference = "$ref"; // Metadata: 0x007442CB
		private const string Key_ObjectDefinition = "$id"; // Metadata: 0x007442D3
		private const string Key_InstanceType = "$type"; // Metadata: 0x007442DA
		private const string Key_Version = "$version"; // Metadata: 0x007442E3
		private const string Key_Content = "$content"; // Metadata: 0x007442EF
		private Dictionary<Type, fsBaseConverter> _cachedConverters; // 0x10
		private Dictionary<Type, List<fsObjectProcessor>> _cachedProcessors; // 0x18
		private readonly List<fsConverter> _availableConverters; // 0x20
		private readonly Dictionary<Type, fsDirectConverter> _availableDirectConverters; // 0x28
		private readonly List<fsObjectProcessor> _processors; // 0x30
		private readonly fsCyclicReferenceManager _references; // 0x38
		private readonly fsLazyCycleDefinitionWriter _lazyReferenceWriter; // 0x40
		public fsContext Context; // 0x48
	
		// Nested types
		internal class fsLazyCycleDefinitionWriter // TypeDefIndex: 9133
		{
			// Fields
			private Dictionary<int, fsData> _pendingDefinitions; // 0x10
			private HashSet<int> _references; // 0x18
	
			// Constructors
			public fsLazyCycleDefinitionWriter(); // 0x00000001815A7940-0x00000001815A79C0
	
			// Methods
			public void WriteDefinition(int id, fsData data); // 0x00000001815A7620-0x00000001815A7760
			public void WriteReference(int id, Dictionary<string, fsData> dict); // 0x00000001815A7760-0x00000001815A7940
			public void Clear(); // 0x00000001815A75D0-0x00000001815A7620
		}
	
		// Constructors
		static fsSerializer(); // 0x0000000181903280-0x0000000181903360
		public fsSerializer(); // 0x0000000181903360-0x0000000181903A90
	
		// Methods
		public static bool IsReservedKeyword(string key); // 0x0000000181902800-0x0000000181902880
		private static bool IsObjectReference(fsData data); // 0x0000000181902760-0x0000000181902800
		private static bool IsObjectDefinition(fsData data); // 0x00000001819026C0-0x0000000181902760
		private static bool IsVersioned(fsData data); // 0x0000000181902920-0x00000001819029C0
		private static bool IsTypeSpecified(fsData data); // 0x0000000181902880-0x0000000181902920
		private static bool IsWrappedData(fsData data); // 0x00000001819029C0-0x0000000181902A60
		public static void StripDeserializationMetadata(ref fsData data); // 0x0000000181902A60-0x0000000181902C60
		private static void ConvertLegacyData(ref fsData data); // 0x00000001818FF740-0x00000001818FFAD0
		private static void Invoke_OnBeforeSerialize(List<fsObjectProcessor> processors, Type storageType, object instance); // 0x0000000181902600-0x00000001819026C0
		private static void Invoke_OnAfterSerialize(List<fsObjectProcessor> processors, Type storageType, object instance, ref fsData data); // 0x00000001819023C0-0x0000000181902480
		private static void Invoke_OnBeforeDeserialize(List<fsObjectProcessor> processors, Type storageType, ref fsData data); // 0x0000000181902540-0x0000000181902600
		private static void Invoke_OnBeforeDeserializeAfterInstanceCreation(List<fsObjectProcessor> processors, Type storageType, object instance, ref fsData data); // 0x0000000181902480-0x0000000181902540
		private static void Invoke_OnAfterDeserialize(List<fsObjectProcessor> processors, Type storageType, object instance); // 0x0000000181902300-0x00000001819023C0
		private static void EnsureDictionary(fsData data); // 0x00000001818FFAD0-0x00000001818FFC10
		public void AddProcessor(fsObjectProcessor processor); // 0x00000001818FF6C0-0x00000001818FF740
		private List<fsObjectProcessor> GetProcessors(Type type); // 0x00000001818FFFD0-0x0000000181900270
		public void AddConverter(fsBaseConverter converter); // 0x00000001818FF430-0x00000001818FF6C0
		private fsBaseConverter GetConverter(Type type); // 0x00000001818FFC10-0x00000001818FFFD0
		public fsResult TrySerialize<T>(T instance, out fsData data);
		public fsResult TryDeserialize<T>(fsData data, ref T instance);
		public fsResult TrySerialize(Type storageType, object instance, out fsData data); // 0x0000000181903030-0x0000000181903280
		private fsResult InternalSerialize_1_ProcessCycles(Type storageType, object instance, out fsData data); // 0x0000000181901910-0x0000000181901DC0
		private fsResult InternalSerialize_2_Inheritance(Type storageType, object instance, out fsData data); // 0x0000000181901DC0-0x0000000181901FD0
		private fsResult InternalSerialize_3_ProcessVersioning(object instance, out fsData data); // 0x0000000181901FD0-0x0000000181902250
		private fsResult InternalSerialize_4_Converter(object instance, out fsData data); // 0x0000000181902250-0x0000000181902300
		public fsResult TryDeserialize(fsData data, Type storageType, ref object result); // 0x0000000181902C60-0x0000000181903030
		private fsResult InternalDeserialize_1_CycleReference(fsData data, Type storageType, ref object result, out List<fsObjectProcessor> processors); // 0x0000000181900270-0x00000001819005A0
		private fsResult InternalDeserialize_2_Version(fsData data, Type storageType, ref object result, out List<fsObjectProcessor> processors); // 0x00000001819005A0-0x0000000181900BC0
		private fsResult InternalDeserialize_3_Inheritance(fsData data, Type storageType, ref object result, out List<fsObjectProcessor> processors); // 0x0000000181900BC0-0x00000001819013E0
		private fsResult InternalDeserialize_4_Cycles(fsData data, Type resultType, ref object result); // 0x00000001819013E0-0x0000000181901760
		private fsResult InternalDeserialize_5_Converter(fsData data, Type resultType, ref object result); // 0x0000000181901760-0x0000000181901910
	}
}
