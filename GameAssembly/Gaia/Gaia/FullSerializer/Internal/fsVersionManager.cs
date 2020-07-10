/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia.FullSerializer.Internal
{
	public static class fsVersionManager // TypeDefIndex: 9164
	{
		// Fields
		private static readonly Dictionary<Type, fsOption<fsVersionedType>> _cache; // 0x00
	
		// Constructors
		static fsVersionManager(); // 0x0000000181904F60-0x0000000181905450
	
		// Methods
		public static fsResult GetVersionImportPath(string currentVersion, fsVersionedType targetVersion, out List<fsVersionedType> path); // 0x00000001819041B0-0x0000000181904580
		private static bool GetVersionImportPathRecursive(List<fsVersionedType> path, string currentVersion, fsVersionedType current); // 0x0000000181904020-0x00000001819041B0
		public static fsOption<fsVersionedType> GetVersionedType(Type type); // 0x0000000181904580-0x00000001819049D0
		private static void VerifyConstructors(fsVersionedType type); // 0x00000001819049D0-0x0000000181904CA0
		private static void VerifyUniqueVersionStrings(fsVersionedType type); // 0x0000000181904CA0-0x0000000181904F60
	}
}
