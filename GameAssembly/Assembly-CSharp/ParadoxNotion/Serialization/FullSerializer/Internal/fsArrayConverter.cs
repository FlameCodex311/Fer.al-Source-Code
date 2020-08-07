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
	public class fsArrayConverter : fsConverter // TypeDefIndex: 15927
	{
		// Constructors
		public fsArrayConverter(); // 0x00000001803F46D0-0x00000001803F46E0
	
		// Methods
		public override bool CanProcess(Type type); // 0x00000001806DA5F0-0x00000001806DA610
		public override bool RequestCycleSupport(Type storageType); // 0x0000000180380950-0x0000000180380960
		public override bool RequestInheritanceSupport(Type storageType); // 0x0000000180380950-0x0000000180380960
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType); // 0x00000001806DA9D0-0x00000001806DAD10
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType); // 0x00000001806DA680-0x00000001806DA9D0
		public override object CreateInstance(fsData data, Type storageType); // 0x00000001806DA610-0x00000001806DA680
	}
}
