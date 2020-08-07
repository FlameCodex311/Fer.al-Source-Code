/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia.FullSerializer.Internal
{
	public static class fsVersionManager // TypeDefIndex: 9327
	{
		// Fields
		private static readonly Dictionary<Type, fsOption<fsVersionedType>> _cache; // 0x00
	
		// Constructors
		static fsVersionManager(); // 0x0000000181524E50-0x0000000181525310
	
		// Methods
		public static fsResult GetVersionImportPath(string currentVersion, fsVersionedType targetVersion, out List<fsVersionedType> path); // 0x0000000181524140-0x00000001815244A0
		private static bool GetVersionImportPathRecursive(List<fsVersionedType> path, string currentVersion, fsVersionedType current); // 0x0000000181523FC0-0x0000000181524140
		public static fsOption<fsVersionedType> GetVersionedType(Type type); // 0x00000001815244A0-0x00000001815248E0
		private static void VerifyConstructors(fsVersionedType type); // 0x00000001815248E0-0x0000000181524BA0
		private static void VerifyUniqueVersionStrings(fsVersionedType type); // 0x0000000181524BA0-0x0000000181524E50
	}
}
