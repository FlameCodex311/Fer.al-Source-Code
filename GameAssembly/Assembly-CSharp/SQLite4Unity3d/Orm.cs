/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace SQLite4Unity3d
{
	public static class Orm // TypeDefIndex: 15466
	{
		// Fields
		public const int DefaultMaxStringLength = 140; // Metadata: 0x007849A6
		public const string ImplicitPkName = "Id"; // Metadata: 0x007849AA
		public const string ImplicitIndexSuffix = "Id"; // Metadata: 0x007849B0
	
		// Methods
		public static string SqlDecl(TableMapping.Column p, bool storeDateTimeAsTicks); // 0x0000000180E07940-0x0000000180E07C30
		public static string SqlType(TableMapping.Column p, bool storeDateTimeAsTicks); // 0x0000000180E07C30-0x0000000180E082E0
		public static bool IsPK(MemberInfo p); // 0x0000000180E07700-0x0000000180E077A0
		public static string Collation(MemberInfo p); // 0x0000000180E07390-0x0000000180E07520
		public static bool IsAutoInc(MemberInfo p); // 0x0000000180E075C0-0x0000000180E07660
		public static IEnumerable<IndexedAttribute> GetIndices(MemberInfo p); // 0x0000000180E07520-0x0000000180E075C0
		public static int? MaxStringLength(PropertyInfo p); // 0x0000000180E077A0-0x0000000180E07940
		public static bool IsMarkedNotNull(MemberInfo p); // 0x0000000180E07660-0x0000000180E07700
	}
}
