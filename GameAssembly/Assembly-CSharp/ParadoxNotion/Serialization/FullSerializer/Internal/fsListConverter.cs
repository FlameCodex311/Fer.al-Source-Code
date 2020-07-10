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
	public class fsListConverter : fsConverter // TypeDefIndex: 15328
	{
		// Constructors
		public fsListConverter(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public override bool CanProcess(Type type); // 0x0000000181392C10-0x0000000181392CC0
		public override object CreateInstance(fsData data, Type storageType); // 0x0000000181392CC0-0x0000000181392D50
		public override fsResult TrySerialize(object instance_, out fsData serialized, Type storageType); // 0x0000000181393120-0x00000001813934F0
		public override fsResult TryDeserialize(fsData data, ref object instance_, Type storageType); // 0x0000000181392D50-0x0000000181393120
	}
}
