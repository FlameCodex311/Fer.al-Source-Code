/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia.FullSerializer.Internal
{
	public class fsPrimitiveConverter : fsConverter // TypeDefIndex: 9149
	{
		// Constructors
		public fsPrimitiveConverter(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public override bool CanProcess(Type type); // 0x00000001818FC910-0x00000001818FCA10
		public override bool RequestCycleSupport(Type storageType); // 0x00000001803C28F0-0x00000001803C2900
		public override bool RequestInheritanceSupport(Type storageType); // 0x00000001803C28F0-0x00000001803C2900
		private static bool UseBool(Type type); // 0x00000001818FD8D0-0x00000001818FD940
		private static bool UseInt64(Type type); // 0x00000001818FDA50-0x00000001818FDC70
		private static bool UseUInt64(Type type); // 0x00000001818FDD30-0x00000001818FDDA0
		private static bool UseDouble(Type type); // 0x00000001818FD940-0x00000001818FDA50
		private static bool UseString(Type type); // 0x00000001818FDC70-0x00000001818FDD30
		public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType); // 0x00000001818FD2B0-0x00000001818FD8D0
		public override fsResult TryDeserialize(fsData storage, ref object instance, Type storageType); // 0x00000001818FCA10-0x00000001818FD2B0
	}
}
