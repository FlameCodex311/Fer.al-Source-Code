/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace StrayTech
{
	public static class ReflectionExtension // TypeDefIndex: 13905
	{
		// Extension methods
		public static IList<TAttribute> GetCustomAttributes<TAttribute>(this ICustomAttributeProvider toScan, bool inherit = false /* Metadata: 0x00784230 */)
			where TAttribute : Attribute;
		public static TAttribute GetCustomAttribute<TAttribute>(this ICustomAttributeProvider toScan, bool inherit = false /* Metadata: 0x00784231 */)
			where TAttribute : Attribute;
		public static IList<TAttribute> GetFieldAttributes<TAttribute>(this FieldInfo field, bool inherit = false /* Metadata: 0x00784232 */)
			where TAttribute : Attribute;
		public static TAttribute GetFieldAttribute<TAttribute>(this FieldInfo field, bool inherit = false /* Metadata: 0x00784233 */)
			where TAttribute : Attribute;
		public static IEnumerable<FieldInfo> GetAllFields(this Type type); // 0x00000001812021A0-0x0000000181202300
		public static void CopyFromOther(this UnityEngine.Object source, UnityEngine.Object target); // 0x0000000181201F50-0x00000001812021A0
		public static void CopyFromOther(this UnityEngine.Object source, UnityEngine.Object target, HashSet<Type> typesToSkip); // 0x0000000181201CD0-0x0000000181201F50
	}
}
