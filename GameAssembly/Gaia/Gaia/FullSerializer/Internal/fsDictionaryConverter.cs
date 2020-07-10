/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia.FullSerializer.Internal
{
	public class fsDictionaryConverter : fsConverter // TypeDefIndex: 9142
	{
		// Constructors
		public fsDictionaryConverter(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public override bool CanProcess(Type type); // 0x00000001818EF480-0x00000001818EF510
		public override object CreateInstance(fsData data, Type storageType); // 0x00000001818EF510-0x00000001818EF580
		public override fsResult TryDeserialize(fsData data, ref object instance_, Type storageType); // 0x00000001818EF6D0-0x00000001818F0AD0
		public override fsResult TrySerialize(object instance_, out fsData serialized, Type storageType); // 0x00000001818F0AD0-0x00000001818F1260
		private fsResult AddItemToDictionary(IDictionary dictionary, object key, object value); // 0x00000001818EEFE0-0x00000001818EF480
		private static void GetKeyValueTypes(Type dictionaryType, out Type keyStorageType, out Type valueStorageType); // 0x00000001818EF580-0x00000001818EF6D0
	}
}
