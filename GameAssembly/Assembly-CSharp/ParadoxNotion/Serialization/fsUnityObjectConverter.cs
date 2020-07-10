/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion.Serialization.FullSerializer;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ParadoxNotion.Serialization
{
	public class fsUnityObjectConverter : fsConverter // TypeDefIndex: 15285
	{
		// Constructors
		public fsUnityObjectConverter(); // 0x000000018037E800-0x000000018037E810
	
		// Methods
		public override bool CanProcess(Type type); // 0x0000000181182480-0x0000000181182510
		public override bool RequestCycleSupport(Type storageType); // 0x00000001803C28F0-0x00000001803C2900
		public override bool RequestInheritanceSupport(Type storageType); // 0x00000001803C28F0-0x00000001803C2900
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType); // 0x0000000181182710-0x00000001811828D0
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType); // 0x0000000181182510-0x0000000181182710
		public override object CreateInstance(fsData data, Type storageType); // 0x000000018035FCC0-0x000000018035FCD0
	}
}
