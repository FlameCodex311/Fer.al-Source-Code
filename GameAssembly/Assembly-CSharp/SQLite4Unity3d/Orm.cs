/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace SQLite4Unity3d
{
	public static class Orm // TypeDefIndex: 16305
	{
		// Fields
		public const int DefaultMaxStringLength = 140; // Metadata: 0x007BBB16
		public const string ImplicitPkName = "Id"; // Metadata: 0x007BBB1A
		public const string ImplicitIndexSuffix = "Id"; // Metadata: 0x007BBB20
	
		// Methods
		public static string SqlDecl(TableMapping.Column p, bool storeDateTimeAsTicks); // 0x000000018072DC00-0x000000018072DED0
		public static string SqlType(TableMapping.Column p, bool storeDateTimeAsTicks); // 0x000000018072DED0-0x000000018072E530
		public static bool IsPK(MemberInfo p); // 0x000000018072D9D0-0x000000018072DA70
		public static string Collation(MemberInfo p); // 0x000000018072D670-0x000000018072D7F0
		public static bool IsAutoInc(MemberInfo p); // 0x000000018072D890-0x000000018072D930
		public static IEnumerable<IndexedAttribute> GetIndices(MemberInfo p); // 0x000000018072D7F0-0x000000018072D890
		public static int? MaxStringLength(PropertyInfo p); // 0x000000018072DA70-0x000000018072DC00
		public static bool IsMarkedNotNull(MemberInfo p); // 0x000000018072D930-0x000000018072D9D0
	}
}
