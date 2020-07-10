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
	public class fsPrimitiveConverter : fsConverter // TypeDefIndex: 15329
	{
		// Constructors
		public fsPrimitiveConverter(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public override bool CanProcess(Type type); // 0x00000001813935F0-0x00000001813936E0
		public override bool RequestCycleSupport(Type storageType); // 0x00000001803C28F0-0x00000001803C2900
		public override bool RequestInheritanceSupport(Type storageType); // 0x00000001803C28F0-0x00000001803C2900
		private static bool UseBool(Type type); // 0x0000000181394720-0x0000000181394790
		private static bool UseInt64(Type type); // 0x00000001813948A0-0x0000000181394B00
		private static bool UseDouble(Type type); // 0x0000000181394790-0x00000001813948A0
		private static bool UseString(Type type); // 0x0000000181394B00-0x0000000181394BC0
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType); // 0x0000000181394000-0x0000000181394720
		public override fsResult TryDeserialize(fsData storage, ref object instance, Type storageType); // 0x00000001813936E0-0x0000000181394000
	}
}
