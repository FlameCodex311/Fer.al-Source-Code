/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer.Internal;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia.FullSerializer
{
	public class fsMetaType // TypeDefIndex: 9278
	{
		// Fields
		private static Dictionary<Type, fsMetaType> _metaTypes; // 0x00
		public Type ReflectedType; // 0x10
		private bool _hasEmittedAotData; // 0x18
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private fsMetaProperty[] <Properties>k__BackingField; // 0x20
		private bool? _hasDefaultConstructorCache; // 0x28
		private bool _isDefaultConstructorPublic; // 0x2A
	
		// Properties
		public fsMetaProperty[] Properties { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
		public bool HasDefaultConstructor { get; } // 0x000000018151FEF0-0x00000001815200B0 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass5_0 // TypeDefIndex: 9279
		{
			// Fields
			public MemberInfo member; // 0x10
	
			// Constructors
			public <>c__DisplayClass5_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <CollectProperties>b__0(Type t); // 0x000000018150F610-0x000000018150F6C0
			internal bool <CollectProperties>b__1(Type t); // 0x000000018150F6C0-0x000000018150F770
			internal bool <CollectProperties>b__2(Type t); // 0x000000018150F770-0x000000018150F820
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass7_0 // TypeDefIndex: 9280
		{
			// Fields
			public PropertyInfo property; // 0x10
	
			// Constructors
			public <>c__DisplayClass7_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <CanSerializeProperty>b__0(Type t); // 0x0000000180E4E3D0-0x0000000180E4E440
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass8_0 // TypeDefIndex: 9281
		{
			// Fields
			public FieldInfo field; // 0x10
	
			// Constructors
			public <>c__DisplayClass8_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <CanSerializeField>b__0(Type t); // 0x0000000180E4E440-0x0000000180E4E4B0
		}
	
		// Constructors
		private fsMetaType(Type reflectedType); // 0x000000018151FE30-0x000000018151FEF0
		static fsMetaType(); // 0x000000018151FDD0-0x000000018151FE30
	
		// Methods
		public static fsMetaType Get(Type type); // 0x000000018151FAD0-0x000000018151FC80
		public static void ClearCache(); // 0x000000018151EC20-0x000000018151ECB0
		private static void CollectProperties(List<fsMetaProperty> properties, Type reflectedType); // 0x000000018151ECB0-0x000000018151F550
		private static bool IsAutoProperty(PropertyInfo property, MemberInfo[] members); // 0x000000018151FC80-0x000000018151FDD0
		private static bool CanSerializeProperty(PropertyInfo property, MemberInfo[] members, bool annotationFreeValue); // 0x000000018151E7B0-0x000000018151EC20
		private static bool CanSerializeField(FieldInfo field, bool annotationFreeValue); // 0x000000018151E580-0x000000018151E7B0
		public bool EmitAotData(); // 0x000000018151F920-0x000000018151FAD0
		public object CreateInstance(); // 0x000000018151F550-0x000000018151F920
	}
}
