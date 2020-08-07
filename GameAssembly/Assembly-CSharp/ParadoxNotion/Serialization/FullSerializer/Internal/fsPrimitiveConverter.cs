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
	public class fsPrimitiveConverter : fsConverter // TypeDefIndex: 15932
	{
		// Constructors
		public fsPrimitiveConverter(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public override bool CanProcess(Type type); // 0x00000001811B64B0-0x00000001811B6590
		public override bool RequestCycleSupport(Type storageType); // 0x0000000180380950-0x0000000180380960
		public override bool RequestInheritanceSupport(Type storageType); // 0x0000000180380950-0x0000000180380960
		private static bool UseBool(Type type); // 0x00000001811B7640-0x00000001811B76B0
		private static bool UseInt64(Type type); // 0x00000001811B77C0-0x00000001811B7A20
		private static bool UseDouble(Type type); // 0x00000001811B76B0-0x00000001811B77C0
		private static bool UseString(Type type); // 0x00000001811B7A20-0x00000001811B7AE0
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType); // 0x00000001811B6F30-0x00000001811B7640
		public override fsResult TryDeserialize(fsData storage, ref object instance, Type storageType); // 0x00000001811B6590-0x00000001811B6F30
	}
}
