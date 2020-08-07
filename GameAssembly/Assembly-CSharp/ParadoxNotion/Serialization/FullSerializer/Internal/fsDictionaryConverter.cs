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
	public class fsDictionaryConverter : fsConverter // TypeDefIndex: 15928
	{
		// Constructors
		public fsDictionaryConverter(); // 0x00000001803F46D0-0x00000001803F46E0
	
		// Methods
		public override bool CanProcess(Type type); // 0x00000001806DAD10-0x00000001806DADC0
		public override object CreateInstance(fsData data, Type storageType); // 0x00000001806DADC0-0x00000001806DAE30
		public override fsResult TrySerialize(object instance_, out fsData serialized, Type storageType); // 0x00000001806DB710-0x00000001806DBE20
		public override fsResult TryDeserialize(fsData data, ref object instance_, Type storageType); // 0x00000001806DAE30-0x00000001806DB710
	}
}
