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
	public class fsReflectedConverter : fsConverter // TypeDefIndex: 15330
	{
		// Constructors
		public fsReflectedConverter(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public override bool CanProcess(Type type); // 0x0000000181394BC0-0x0000000181394C70
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType); // 0x00000001813950B0-0x0000000181395500
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType); // 0x0000000181394D00-0x00000001813950B0
		public override object CreateInstance(fsData data, Type storageType); // 0x0000000181394C70-0x0000000181394D00
	}
}
