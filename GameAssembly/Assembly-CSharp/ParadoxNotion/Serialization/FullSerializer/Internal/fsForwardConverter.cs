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
	public class fsForwardConverter : fsConverter // TypeDefIndex: 15327
	{
		// Fields
		private string _memberName; // 0x18
	
		// Constructors
		public fsForwardConverter(fsForwardAttribute attribute); // 0x000000018138FE30-0x000000018138FE70
	
		// Methods
		public override bool CanProcess(Type type); // 0x000000018138F730-0x000000018138F790
		private fsResult GetProperty(object instance, out fsMetaProperty property); // 0x000000018138F820-0x000000018138FA80
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType); // 0x000000018138FC60-0x000000018138FE30
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType); // 0x000000018138FA80-0x000000018138FC60
		public override object CreateInstance(fsData data, Type storageType); // 0x000000018138F790-0x000000018138F820
	}
}
