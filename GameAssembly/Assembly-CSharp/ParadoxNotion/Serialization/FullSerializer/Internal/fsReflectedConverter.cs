/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion.Serialization.FullSerializer;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion.Serialization.FullSerializer.Internal
{
	public class fsReflectedConverter : fsConverter // TypeDefIndex: 15933
	{
		// Constructors
		public fsReflectedConverter(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public override bool CanProcess(Type type); // 0x00000001811B7AE0-0x00000001811B7B90
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType); // 0x00000001811B8100-0x00000001811B8840
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType); // 0x00000001811B7C00-0x00000001811B8100
		public override object CreateInstance(fsData data, Type storageType); // 0x00000001811B7B90-0x00000001811B7C00
	}
}
