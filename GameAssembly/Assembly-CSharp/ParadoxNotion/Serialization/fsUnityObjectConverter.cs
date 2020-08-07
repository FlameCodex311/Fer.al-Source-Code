/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion.Serialization.FullSerializer;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion.Serialization
{
	public class fsUnityObjectConverter : fsConverter // TypeDefIndex: 15887
	{
		// Constructors
		public fsUnityObjectConverter(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public override bool CanProcess(Type type); // 0x00000001811BDE30-0x00000001811BDEC0
		public override bool RequestCycleSupport(Type storageType); // 0x0000000180380950-0x0000000180380960
		public override bool RequestInheritanceSupport(Type storageType); // 0x0000000180380950-0x0000000180380960
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType); // 0x00000001811BE120-0x00000001811BE370
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType); // 0x00000001811BDEC0-0x00000001811BE120
		public override object CreateInstance(fsData data, Type storageType); // 0x000000018037DDC0-0x000000018037DDD0
	}
}
