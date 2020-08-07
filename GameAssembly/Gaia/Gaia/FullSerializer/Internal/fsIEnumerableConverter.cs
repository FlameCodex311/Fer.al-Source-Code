/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia.FullSerializer.Internal
{
	public class fsIEnumerableConverter : fsConverter // TypeDefIndex: 9312
	{
		// Constructors
		public fsIEnumerableConverter(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public override bool CanProcess(Type type); // 0x00000001815181C0-0x0000000181518270
		public override object CreateInstance(fsData data, Type storageType); // 0x0000000181518270-0x00000001815182E0
		public override fsResult TrySerialize(object instance_, out fsData serialized, Type storageType); // 0x0000000181519150-0x0000000181519630
		private bool IsStack(Type type); // 0x00000001815187B0-0x0000000181518860
		public override fsResult TryDeserialize(fsData data, ref object instance_, Type storageType); // 0x0000000181518900-0x0000000181518F00
		private static int HintSize(IEnumerable collection); // 0x0000000181518700-0x00000001815187B0
		private static Type GetElementType(Type objectType); // 0x00000001815185C0-0x0000000181518700
		private static void TryClear(Type type, object instance); // 0x0000000181518860-0x0000000181518900
		private static int TryGetExistingSize(Type type, object instance); // 0x0000000181518F00-0x0000000181519150
		private static MethodInfo GetAddMethod(Type type); // 0x00000001815182E0-0x00000001815185C0
	}
}
