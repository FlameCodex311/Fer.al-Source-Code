/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion.Serialization.FullSerializer;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ParadoxNotion.Serialization.FullSerializer.Internal
{
	public class fsDictionaryConverter : fsConverter // TypeDefIndex: 15325
	{
		// Constructors
		public fsDictionaryConverter(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public override bool CanProcess(Type type); // 0x000000018138D900-0x000000018138D9B0
		public override object CreateInstance(fsData data, Type storageType); // 0x000000018138D9B0-0x000000018138DA40
		public override fsResult TrySerialize(object instance_, out fsData serialized, Type storageType); // 0x000000018138E4D0-0x000000018138EC10
		public override fsResult TryDeserialize(fsData data, ref object instance_, Type storageType); // 0x000000018138DA40-0x000000018138E4D0
	}
}
