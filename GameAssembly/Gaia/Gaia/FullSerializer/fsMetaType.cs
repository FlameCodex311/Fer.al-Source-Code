/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer.Internal;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia.FullSerializer
{
	public class fsMetaType // TypeDefIndex: 9136
	{
		// Fields
		private static Dictionary<Type, fsMetaType> _metaTypes; // 0x00
		public Type ReflectedType; // 0x10
		private bool _hasEmittedAotData; // 0x18
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private fsMetaProperty[] <Properties>k__BackingField; // 0x20
		private bool? _hasDefaultConstructorCache; // 0x28
		private bool _isDefaultConstructorPublic; // 0x2A
	
		// Properties
		public fsMetaProperty[] Properties { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
		public bool HasDefaultConstructor { get; } // 0x00000001818FB0C0-0x00000001818FB280 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass5_0 // TypeDefIndex: 9137
		{
			// Fields
			public MemberInfo member; // 0x10
	
			// Constructors
			public <>c__DisplayClass5_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <CollectProperties>b__0(Type t); // 0x00000001818E93B0-0x00000001818E9460
			internal bool <CollectProperties>b__1(Type t); // 0x00000001818E9460-0x00000001818E9510
			internal bool <CollectProperties>b__2(Type t); // 0x00000001818E9510-0x00000001818E95C0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass7_0 // TypeDefIndex: 9138
		{
			// Fields
			public PropertyInfo property; // 0x10
	
			// Constructors
			public <>c__DisplayClass7_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <CanSerializeProperty>b__0(Type t); // 0x00000001818E95C0-0x00000001818E9670
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass8_0 // TypeDefIndex: 9139
		{
			// Fields
			public FieldInfo field; // 0x10
	
			// Constructors
			public <>c__DisplayClass8_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <CanSerializeField>b__0(Type t); // 0x00000001818E9670-0x00000001818E9720
		}
	
		// Constructors
		private fsMetaType(Type reflectedType); // 0x00000001818FB000-0x00000001818FB0C0
		static fsMetaType(); // 0x00000001818FAFA0-0x00000001818FB000
	
		// Methods
		public static fsMetaType Get(Type type); // 0x00000001818FACA0-0x00000001818FAE50
		public static void ClearCache(); // 0x00000001818F9DC0-0x00000001818F9E50
		private static void CollectProperties(List<fsMetaProperty> properties, Type reflectedType); // 0x00000001818F9E50-0x00000001818FA700
		private static bool IsAutoProperty(PropertyInfo property, MemberInfo[] members); // 0x00000001818FAE50-0x00000001818FAFA0
		private static bool CanSerializeProperty(PropertyInfo property, MemberInfo[] members, bool annotationFreeValue); // 0x00000001818F9940-0x00000001818F9DC0
		private static bool CanSerializeField(FieldInfo field, bool annotationFreeValue); // 0x00000001818F9710-0x00000001818F9940
		public bool EmitAotData(); // 0x00000001818FAAE0-0x00000001818FACA0
		public object CreateInstance(); // 0x00000001818FA700-0x00000001818FAAE0
	}
}
