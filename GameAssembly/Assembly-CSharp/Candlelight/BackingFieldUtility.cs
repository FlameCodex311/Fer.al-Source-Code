/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Candlelight
{
	public static class BackingFieldUtility // TypeDefIndex: 14467
	{
		// Nested types
		public enum IntKeyMode // TypeDefIndex: 14468
		{
			Increment = 0,
			SetToZero = 1
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass5_0<T> // TypeDefIndex: 14469
		{
			// Fields
			public int nullHash;
	
			// Constructors
			public <>c__DisplayClass5_0();
	
			// Methods
			internal bool <SetHashedListBackingFieldFromArray>b__0(T item);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass5_1<T> // TypeDefIndex: 14470
		{
			// Fields
			public T newValue;
	
			// Constructors
			public <>c__DisplayClass5_1();
	
			// Methods
			internal bool <SetHashedListBackingFieldFromArray>b__1(T item);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass9_0<T> // TypeDefIndex: 14471
		{
			// Fields
			public bool isString;
			public bool ignoreCase;
	
			// Constructors
			public <>c__DisplayClass9_0();
	
			// Methods
			internal T <SetHashedListBackingFieldFromHashset>b__0(T element);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass15_0<T, TId> // TypeDefIndex: 14472
			where T : IIdentifiable<TId>
		{
			// Fields
			public int nullHash;
	
			// Constructors
			public <>c__DisplayClass15_0();
	
			// Methods
			internal bool <SetKeyedListBackingFieldFromArray>b__0(T item);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass15_1<T, TId> // TypeDefIndex: 14473
			where T : IIdentifiable<TId>
		{
			// Fields
			public T newValue;
	
			// Constructors
			public <>c__DisplayClass15_1();
	
			// Methods
			internal bool <SetKeyedListBackingFieldFromArray>b__1(T item);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass19_0<TWrapper, TId, TData> // TypeDefIndex: 14474
			where TWrapper : IdentifiableBackingFieldCompatibleObjectWrapper<TId, TData>
		{
			// Fields
			public Func<TId, TData, TWrapper> factory;
			public bool isString;
			public bool ignoreCase;
	
			// Constructors
			public <>c__DisplayClass19_0();
	
			// Methods
			internal TWrapper <SetKeyedListBackingFieldFromDict>b__0(KeyValuePair<TId, TData> kv);
		}
	
		// Methods
		private static T ConvertStringKeyToLower<T>(T stringKey);
		public static int GenerateSerializedPropertiesHash<T>(IList<T> listField)
			where T : IPropertyBackingFieldCompatible;
		public static T GetInterfaceBackingField<T>(ref T interfaceBackingField, UnityEngine.Object objectBackingField)
			where T : class;
		public static void GetKeyedListBackingFieldAsDict<T, TId, TData>(List<T> backingField, Dictionary<TId, TData> result, Func<T, TData> getData)
			where T : IIdentifiable<TId>;
		private static bool SetHashedListBackingFieldFromArray<T>(List<T> backingField, IList<T> value, bool ignoreCase, IntKeyMode intKeyMode = IntKeyMode.Increment /* Metadata: 0x007BAC01 */);
		public static bool SetHashedListBackingFieldFromIntArray(List<int> backingField, IList<int> value, IntKeyMode mode = IntKeyMode.Increment /* Metadata: 0x007BAC05 */); // 0x0000000180491C20-0x0000000180491C80
		public static bool SetHashedListBackingFieldFromObjectArray<T>(List<T> backingField, IList<T> value)
			where T : UnityEngine.Object;
		public static bool SetHashedListBackingFieldFromStringArray(List<string> backingField, IList<string> value, bool ignoreCase = false /* Metadata: 0x007BAC09 */); // 0x0000000180491CD0-0x0000000180491D40
		private static bool SetHashedListBackingFieldFromHashset<T>(List<T> backingField, HashSet<T> value, bool ignoreCase = false /* Metadata: 0x007BAC0A */);
		public static bool SetHashedListBackingFieldFromIntHashset(List<int> backingField, HashSet<int> value); // 0x0000000180491C80-0x0000000180491CD0
		public static bool SetHashedListBackingFieldFromObjectHashset<T>(List<T> backingField, HashSet<T> value)
			where T : UnityEngine.Object;
		public static bool SetHashedListBackingFieldFromStringHashset(List<string> backingField, HashSet<string> value, bool ignoreCase = false /* Metadata: 0x007BAC0B */); // 0x0000000180491D40-0x0000000180491DA0
		public static bool SetInterfaceBackingField<T>(T value, ref T interfaceBackingField, ref UnityEngine.Object objectBackingField, Action<T> onAssign = null, Action<T> onUnassign = null)
			where T : class;
		public static void SetInterfaceBackingFieldObject<T>(UnityEngine.Object value, ref UnityEngine.Object backingField, Action<T> setInterfaceProperty)
			where T : class;
		private static bool SetKeyedListBackingFieldFromArray<T, TId>(List<T> backingField, IList<T> value, Func<TId, T, T> mutateIdentifier, bool ignoreCase, IntKeyMode intKeyMode = IntKeyMode.Increment /* Metadata: 0x007BAC0C */)
			where T : IIdentifiable<TId>;
		public static bool SetKeyedListBackingFieldFromIntKeyedArray<T>(List<T> backingField, IList<T> value, Func<int, T, T> mutateIdentifier, IntKeyMode mode = IntKeyMode.Increment /* Metadata: 0x007BAC10 */)
			where T : IIdentifiable<int>;
		public static bool SetKeyedListBackingFieldFromObjectKeyedArray<T, TId>(List<T> backingField, IList<T> value, Func<TId, T, T> mutateIdentifier)
			where T : IIdentifiable<TId>
			where TId : UnityEngine.Object;
		public static bool SetKeyedListBackingFieldFromStringKeyedArray<T>(List<T> backingField, IList<T> value, Func<string, T, T> mutateIdentifier, bool ignoreCase = false /* Metadata: 0x007BAC14 */)
			where T : IIdentifiable<string>;
		private static bool SetKeyedListBackingFieldFromDict<TWrapper, TId, TData>(List<TWrapper> backingField, Dictionary<TId, TData> value, Func<TId, TData, TWrapper> factory, bool ignoreCase = false /* Metadata: 0x007BAC15 */)
			where TWrapper : IdentifiableBackingFieldCompatibleObjectWrapper<TId, TData>;
		public static bool SetKeyedListBackingFieldFromIntKeyedDict<TWrapper, TData>(List<TWrapper> backingField, Dictionary<int, TData> value, Func<int, TData, TWrapper> factory)
			where TWrapper : IdentifiableBackingFieldCompatibleObjectWrapper<int, TData>;
		public static bool SetKeyedListBackingFieldFromObjectKeyedDict<TWrapper, TId, TData>(List<TWrapper> backingField, Dictionary<TId, TData> value, Func<TId, TData, TWrapper> factory)
			where TWrapper : IdentifiableBackingFieldCompatibleObjectWrapper<TId, TData>
			where TId : UnityEngine.Object;
		public static bool SetKeyedListBackingFieldFromStringKeyedDict<TWrapper, TData>(List<TWrapper> backingField, Dictionary<string, TData> value, Func<string, TData, TWrapper> factory, bool ignoreCase = false /* Metadata: 0x007BAC16 */)
			where TWrapper : IdentifiableBackingFieldCompatibleObjectWrapper<string, TData>;
	}
}
