/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia.FullSerializer.Internal
{
	public class fsDictionaryConverter : fsConverter // TypeDefIndex: 9308
	{
		// Constructors
		public fsDictionaryConverter(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public override bool CanProcess(Type type); // 0x0000000181514EF0-0x0000000181514F80
		public override object CreateInstance(fsData data, Type storageType); // 0x0000000181514F80-0x0000000181514FF0
		public override fsResult TryDeserialize(fsData data, ref object instance_, Type storageType); // 0x0000000181515140-0x0000000181516260
		public override fsResult TrySerialize(object instance_, out fsData serialized, Type storageType); // 0x0000000181516260-0x0000000181516930
		private fsResult AddItemToDictionary(IDictionary dictionary, object key, object value); // 0x0000000181514AD0-0x0000000181514EF0
		private static void GetKeyValueTypes(Type dictionaryType, out Type keyStorageType, out Type valueStorageType); // 0x0000000181514FF0-0x0000000181515140
	}
}
