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
	public class fsForwardConverter : fsConverter // TypeDefIndex: 15930
	{
		// Fields
		private string _memberName; // 0x18
	
		// Constructors
		public fsForwardConverter(fsForwardAttribute attribute); // 0x00000001811AFBB0-0x00000001811AFBF0
	
		// Methods
		public override bool CanProcess(Type type); // 0x00000001811AF340-0x00000001811AF3A0
		private fsResult GetProperty(object instance, out fsMetaProperty property); // 0x00000001811AF410-0x00000001811AF6B0
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType); // 0x00000001811AF960-0x00000001811AFBB0
		public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType); // 0x00000001811AF6B0-0x00000001811AF960
		public override object CreateInstance(fsData data, Type storageType); // 0x00000001811AF3A0-0x00000001811AF410
	}
}
