/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace StrayTech
{
	public static class ReflectionExtension // TypeDefIndex: 14572
	{
		// Extension methods
		public static IList<TAttribute> GetCustomAttributes<TAttribute>(this ICustomAttributeProvider toScan, bool inherit = false /* Metadata: 0x007BACF3 */)
			where TAttribute : Attribute;
		public static TAttribute GetCustomAttribute<TAttribute>(this ICustomAttributeProvider toScan, bool inherit = false /* Metadata: 0x007BACF4 */)
			where TAttribute : Attribute;
		public static IList<TAttribute> GetFieldAttributes<TAttribute>(this FieldInfo field, bool inherit = false /* Metadata: 0x007BACF5 */)
			where TAttribute : Attribute;
		public static TAttribute GetFieldAttribute<TAttribute>(this FieldInfo field, bool inherit = false /* Metadata: 0x007BACF6 */)
			where TAttribute : Attribute;
		public static IEnumerable<FieldInfo> GetAllFields(this Type type); // 0x0000000180CB6D20-0x0000000180CB6E80
		public static void CopyFromOther(this UnityEngine.Object source, UnityEngine.Object target); // 0x0000000180CB6AF0-0x0000000180CB6D20
		public static void CopyFromOther(this UnityEngine.Object source, UnityEngine.Object target, HashSet<Type> typesToSkip); // 0x0000000180CB6890-0x0000000180CB6AF0
	}
}
