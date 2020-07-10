/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion.Serialization.FullSerializer.Internal;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ParadoxNotion.Serialization.FullSerializer
{
	public class fsSerializer // TypeDefIndex: 15316
	{
		// Fields
		public const string KEY_OBJECT_REFERENCE = "$ref"; // Metadata: 0x007847CF
		public const string KEY_OBJECT_DEFINITION = "$id"; // Metadata: 0x007847D7
		public const string KEY_INSTANCE_TYPE = "$type"; // Metadata: 0x007847DE
		public const string KEY_VERSION = "$version"; // Metadata: 0x007847E7
		public const string KEY_CONTENT = "$content"; // Metadata: 0x007847F3
		private Dictionary<Type, fsBaseConverter> _cachedOverrideConverterInstances; // 0x10
		private Dictionary<Type, fsBaseConverter> _cachedConverters; // 0x18
		private readonly List<fsConverter> _availableConverters; // 0x20
		private readonly Dictionary<Type, fsDirectConverter> _availableDirectConverters; // 0x28
		private static readonly Type[] _directConverterTypes; // 0x00
		private readonly List<fsObjectProcessor> _processors; // 0x30
		private Dictionary<Type, List<fsObjectProcessor>> _cachedProcessors; // 0x38
		private readonly fsCyclicReferenceManager _references; // 0x40
		private readonly fsLazyCycleDefinitionWriter _lazyReferenceWriter; // 0x48
		public fsContext Context; // 0x50
		public fsConfig Config; // 0x58
	
		// Nested types
		internal class fsLazyCycleDefinitionWriter // TypeDefIndex: 15317
		{
			// Fields
			private Dictionary<int, fsData> _pendingDefinitions; // 0x10
			private HashSet<int> _references; // 0x18
	
			// Constructors
			public fsLazyCycleDefinitionWriter(); // 0x000000018117DD10-0x000000018117DD90
	
			// Methods
			public void WriteDefinition(int id, fsData data); // 0x000000018117D930-0x000000018117DAD0
			public void WriteReference(int id, Dictionary<string, fsData> dict); // 0x000000018117DAD0-0x000000018117DD10
			public void Clear(); // 0x000000018117D8D0-0x000000018117D930
		}
	
		// Constructors
		static fsSerializer(); // 0x0000000181181F00-0x0000000181181FA0
		public fsSerializer(); // 0x0000000181181FA0-0x0000000181182480
	
		// Methods
		public static bool IsReservedKeyword(string key); // 0x0000000181181380-0x0000000181181430
		private static bool IsObjectReference(fsData data); // 0x0000000181181300-0x0000000181181380
		private static bool IsObjectDefinition(fsData data); // 0x0000000181181280-0x0000000181181300
		private static bool IsVersioned(fsData data); // 0x00000001811814B0-0x0000000181181530
		private static bool IsTypeSpecified(fsData data); // 0x0000000181181430-0x00000001811814B0
		private static bool IsWrappedData(fsData data); // 0x0000000181181530-0x00000001811815B0
		private static void Invoke_OnBeforeSerialize(List<fsObjectProcessor> processors, Type storageType, object instance); // 0x0000000181181100-0x0000000181181280
		private static void Invoke_OnAfterSerialize(List<fsObjectProcessor> processors, Type storageType, object instance, ref fsData data); // 0x0000000181180EC0-0x0000000181180F80
		private static void Invoke_OnBeforeDeserialize(List<fsObjectProcessor> processors, Type storageType, ref fsData data); // 0x0000000181181040-0x0000000181181100
		private static void Invoke_OnBeforeDeserializeAfterInstanceCreation(List<fsObjectProcessor> processors, Type storageType, object instance, ref fsData data); // 0x0000000181180F80-0x0000000181181040
		private static void Invoke_OnAfterDeserialize(List<fsObjectProcessor> processors, Type storageType, object instance); // 0x0000000181180D30-0x0000000181180EC0
		private static void EnsureDictionary(fsData data); // 0x000000018117F690-0x000000018117F730
		private List<fsObjectProcessor> GetProcessors(Type type); // 0x000000018117FB80-0x000000018117FE70
		public void AddConverter(fsBaseConverter converter); // 0x000000018117F400-0x000000018117F690
		private fsBaseConverter GetConverter(Type type, Type overrideConverterType); // 0x000000018117F730-0x000000018117FB80
		public fsResult TrySerialize<T>(T instance, out fsData data);
		public fsResult TrySerialize(Type storageType, object instance, out fsData data); // 0x0000000181181EC0-0x0000000181181F00
		public fsResult TrySerialize(Type storageType, Type overrideConverterType, object instance, out fsData data); // 0x0000000181181AD0-0x0000000181181EC0
		private fsResult Internal_Serialize(Type storageType, Type overrideConverterType, object instance, out fsData data); // 0x0000000181180720-0x0000000181180D30
		public fsResult TryDeserialize<T>(fsData data, ref T instance);
		public fsResult TryDeserialize(fsData data, Type storageType, ref object result); // 0x00000001811815B0-0x00000001811815F0
		public fsResult TryDeserialize(fsData data, Type storageType, Type overrideConverterType, ref object result); // 0x00000001811815F0-0x0000000181181AD0
		private fsResult Internal_Deserialize(Type overrideConverterType, fsData data, Type storageType, ref object result, out List<fsObjectProcessor> processors); // 0x000000018117FE70-0x0000000181180720
	}
}
