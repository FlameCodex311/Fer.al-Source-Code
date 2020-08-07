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
	public class fsListConverter : fsConverter // TypeDefIndex: 15931
	{
		// Constructors
		public fsListConverter(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public override bool CanProcess(Type type); // 0x00000001811B4720-0x00000001811B47D0
		public override object CreateInstance(fsData data, Type storageType); // 0x00000001811B47D0-0x00000001811B4840
		public override fsResult TrySerialize(object instance_, out fsData serialized, Type storageType); // 0x00000001811B4F10-0x00000001811B5290
		public override fsResult TryDeserialize(fsData data, ref object instance_, Type storageType); // 0x00000001811B4840-0x00000001811B4F10
	}
}
