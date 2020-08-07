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
	public class fsTypeConverter : fsConverter // TypeDefIndex: 15934
	{
		// Constructors
		public fsTypeConverter(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public override bool CanProcess(Type type); // 0x00000001811BD9F0-0x00000001811BDA80
		public override bool RequestCycleSupport(Type type); // 0x0000000180380950-0x0000000180380960
		public override bool RequestInheritanceSupport(Type type); // 0x0000000180380950-0x0000000180380960
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType); // 0x00000001811BDD10-0x00000001811BDE30
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType); // 0x00000001811BDA80-0x00000001811BDD10
		public override object CreateInstance(fsData data, Type storageType); // 0x0000000180766BD0-0x0000000180766BE0
	}
}
