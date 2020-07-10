/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia.FullSerializer.Internal
{
	public class fsIEnumerableConverter : fsConverter // TypeDefIndex: 9146
	{
		// Constructors
		public fsIEnumerableConverter(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public override bool CanProcess(Type type); // 0x00000001818F2D10-0x00000001818F2DC0
		public override object CreateInstance(fsData data, Type storageType); // 0x00000001818F2DC0-0x00000001818F2E30
		public override fsResult TrySerialize(object instance_, out fsData serialized, Type storageType); // 0x00000001818F3CA0-0x00000001818F4470
		private bool IsStack(Type type); // 0x00000001818F3320-0x00000001818F33D0
		public override fsResult TryDeserialize(fsData data, ref object instance_, Type storageType); // 0x00000001818F3470-0x00000001818F3BB0
		private static int HintSize(IEnumerable collection); // 0x00000001818F3260-0x00000001818F3320
		private static Type GetElementType(Type objectType); // 0x00000001818F3110-0x00000001818F3260
		private static void TryClear(Type type, object instance); // 0x00000001818F33D0-0x00000001818F3470
		private static int TryGetExistingSize(Type type, object instance); // 0x00000001818F3BB0-0x00000001818F3CA0
		private static MethodInfo GetAddMethod(Type type); // 0x00000001818F2E30-0x00000001818F3110
	}
}
