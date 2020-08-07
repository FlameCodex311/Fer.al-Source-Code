/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion.Serialization.FullSerializer
{
	public class fsSerializer // TypeDefIndex: 15924
	{
		// Fields
		public const string KEY_OBJECT_REFERENCE = "$ref"; // Metadata: 0x007BB669
		public const string KEY_OBJECT_DEFINITION = "$id"; // Metadata: 0x007BB671
		public const string KEY_INSTANCE_TYPE = "$type"; // Metadata: 0x007BB678
		public const string KEY_VERSION = "$version"; // Metadata: 0x007BB681
		public const string KEY_CONTENT = "$content"; // Metadata: 0x007BB68D
		private Dictionary<Type, fsBaseConverter> _cachedOverrideConverterInstances; // 0x10
		private Dictionary<Type, fsBaseConverter> _cachedConverters; // 0x18
		private readonly List<fsConverter> _availableConverters; // 0x20
		private readonly Dictionary<Type, fsDirectConverter> _availableDirectConverters; // 0x28
		private readonly List<fsObjectProcessor> _processors; // 0x30
		private Dictionary<Type, List<fsObjectProcessor>> _cachedProcessors; // 0x38
		private fsCyclicReferenceManager _references; // 0x40
		private fsLazyCycleDefinitionWriter _lazyReferenceWriter; // 0x48
		private Stack<ISerializationCollector> _collectors; // 0x50
		private int _collectableDepth; // 0x58
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private List<UnityEngine.Object> <ReferencesDatabase>k__BackingField; // 0x60
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <IgnoreSerializeCycleReferences>k__BackingField; // 0x68
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action<object> onBeforeObjectSerialized; // 0x70
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action<object, fsData> onAfterObjectSerialized; // 0x78
	
		// Properties
		public List<UnityEngine.Object> ReferencesDatabase { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180418970-0x0000000180418980 0x00000001804AF510-0x00000001804AF520
		public bool IgnoreSerializeCycleReferences { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018037D390-0x000000018037D3A0 0x000000018039EC50-0x000000018039EC60
	
		// Events
		public event Action<object> onBeforeObjectSerialized {
			add; // 0x00000001811BD810-0x00000001811BD8B0
			remove; // 0x00000001811BD950-0x00000001811BD9F0
		}
		public event Action<object, fsData> onAfterObjectSerialized {
			add; // 0x00000001811BD770-0x00000001811BD810
			remove; // 0x00000001811BD8B0-0x00000001811BD950
		}
	
		// Nested types
		internal class fsLazyCycleDefinitionWriter // TypeDefIndex: 15925
		{
			// Fields
			private Dictionary<int, fsData> _pendingDefinitions; // 0x10
			private HashSet<int> _references; // 0x18
	
			// Constructors
			public fsLazyCycleDefinitionWriter(); // 0x00000001811B46A0-0x00000001811B4720
	
			// Methods
			public void WriteDefinition(int id, fsData data); // 0x00000001811B4180-0x00000001811B42C0
			public void WriteReference(int id, Dictionary<string, fsData> dict); // 0x00000001811B42C0-0x00000001811B46A0
			public void Clear(); // 0x00000001811B4120-0x00000001811B4180
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 15926
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<MethodInfo, bool> <>9__58_0; // 0x08
	
			// Constructors
			static <>c(); // 0x00000001811ABF10-0x00000001811ABF70
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <TryDeserializeMigration>b__58_0(MethodInfo m); // 0x00000001811ABB50-0x00000001811ABBB0
		}
	
		// Constructors
		public fsSerializer(); // 0x00000001811BD150-0x00000001811BD770
	
		// Methods
		public static bool IsReservedKeyword(string key); // 0x00000001811BB5B0-0x00000001811BB660
		public static void RemoveMetaData(ref fsData data); // 0x00000001811BB970-0x00000001811BBBB0
		private static void EnsureDictionary(ref fsData data); // 0x00000001811B8FB0-0x00000001811B91A0
		private static bool IsObjectReference(fsData data); // 0x00000001811BB510-0x00000001811BB5B0
		private static bool IsObjectDefinition(fsData data); // 0x00000001811BB470-0x00000001811BB510
		private static bool IsVersioned(fsData data); // 0x00000001811BB700-0x00000001811BB7A0
		private static bool IsTypeSpecified(fsData data); // 0x00000001811BB660-0x00000001811BB700
		private static bool IsWrappedData(fsData data); // 0x00000001811BB7A0-0x00000001811BB840
		private static void Invoke_OnBeforeSerialize(List<fsObjectProcessor> processors, Type storageType, object instance); // 0x00000001811BB300-0x00000001811BB470
		private static void Invoke_OnAfterSerialize(List<fsObjectProcessor> processors, Type storageType, object instance, ref fsData data); // 0x00000001811BB0C0-0x00000001811BB180
		private static void Invoke_OnBeforeDeserialize(List<fsObjectProcessor> processors, Type storageType, ref fsData data); // 0x00000001811BB240-0x00000001811BB300
		private static void Invoke_OnBeforeDeserializeAfterInstanceCreation(List<fsObjectProcessor> processors, Type storageType, object instance, ref fsData data); // 0x00000001811BB180-0x00000001811BB240
		private static void Invoke_OnAfterDeserialize(List<fsObjectProcessor> processors, Type storageType, object instance); // 0x00000001811BAF40-0x00000001811BB0C0
		public void PurgeTemporaryData(); // 0x00000001811BB840-0x00000001811BB970
		private List<fsObjectProcessor> GetProcessors(Type type); // 0x00000001811B95D0-0x00000001811B98B0
		public void AddConverter(fsBaseConverter converter); // 0x00000001811B8D20-0x00000001811B8FB0
		private fsBaseConverter GetConverter(Type type, Type overrideConverterType); // 0x00000001811B91A0-0x00000001811B95D0
		public fsResult TrySerialize(Type storageType, object instance, out fsData data); // 0x00000001811BCBF0-0x00000001811BCC30
		public fsResult TrySerialize(Type storageType, object instance, out fsData data, Type overrideConverterType); // 0x00000001811BCC30-0x00000001811BD150
		private fsResult Internal_Serialize(Type storageType, object instance, out fsData data, Type overrideConverterType); // 0x00000001811BA870-0x00000001811BAF40
		public fsResult TryDeserialize(fsData data, Type storageType, ref object result); // 0x00000001811BC6F0-0x00000001811BC730
		public fsResult TryDeserialize(fsData data, Type storageType, ref object result, Type overrideConverterType); // 0x00000001811BC420-0x00000001811BC6F0
		private fsResult Internal_Deserialize(fsData data, Type storageType, ref object result, Type overrideConverterType); // 0x00000001811B98B0-0x00000001811BA870
		private void TryPush(object o); // 0x00000001811BC820-0x00000001811BCAA0
		private void TryPop(object o); // 0x00000001811BC730-0x00000001811BC820
		private void TrySerializeVersioning(object currentInstance, ref fsData data); // 0x00000001811BCAA0-0x00000001811BCBF0
		private void TryDeserializeVersioning(ref object currentInstance, ref fsData currentData); // 0x00000001811BC230-0x00000001811BC420
		private void TryDeserializeMigration(ref object currentInstance, ref fsData currentData, Type previousType, object previousInstance); // 0x00000001811BBBB0-0x00000001811BC230
	}
}
