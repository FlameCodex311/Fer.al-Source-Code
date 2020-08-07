/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia.FullSerializer.Internal
{
	public static class fsPortableReflection // TypeDefIndex: 9323
	{
		// Fields
		public static Type[] EmptyTypes; // 0x00
		private static IDictionary<AttributeQuery, Attribute> _cachedAttributeQueries; // 0x08
		private static BindingFlags DeclaredFlags; // 0x10
	
		// Nested types
		private struct AttributeQuery // TypeDefIndex: 9324
		{
			// Fields
			public MemberInfo MemberInfo; // 0x00
			public Type AttributeType; // 0x08
		}
	
		private class AttributeQueryComparator : IEqualityComparer<AttributeQuery> // TypeDefIndex: 9325
		{
			// Constructors
			public AttributeQueryComparator(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			public bool Equals(AttributeQuery x, AttributeQuery y); // 0x0000000181509B20-0x0000000181509BC0
			public int GetHashCode(AttributeQuery obj); // 0x0000000181509BC0-0x0000000181509C30
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <GetFlattenedMethods>d__16 : IEnumerable<MethodInfo>, IEnumerator<MethodInfo> // TypeDefIndex: 9326
		{
			// Fields
			private int <>1__state; // 0x10
			private MethodInfo <>2__current; // 0x18
			private int <>l__initialThreadId; // 0x20
			private Type type; // 0x28
			public Type <>3__type; // 0x30
			private string methodName; // 0x38
			public string <>3__methodName; // 0x40
			private MethodInfo[] <methods>5__2; // 0x48
			private int <i>5__3; // 0x50
	
			// Properties
			MethodInfo IEnumerator<System.Reflection.MethodInfo>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <GetFlattenedMethods>d__16(int <>1__state); // 0x00000001806301B0-0x00000001806301E0
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x000000018150F2B0-0x000000018150F4A0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x000000018150F540-0x000000018150F590
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<MethodInfo> IEnumerable<MethodInfo>.GetEnumerator(); // 0x000000018150F4A0-0x000000018150F540
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator(); // 0x000000018150F4A0-0x000000018150F540
		}
	
		// Constructors
		static fsPortableReflection(); // 0x0000000181521530-0x00000001815215E0
	
		// Methods
		public static bool HasAttribute(MemberInfo element, Type attributeType); // 0x0000000181521450-0x00000001815214C0
		public static bool HasAttribute<TAttribute>(MemberInfo element);
		public static Attribute GetAttribute(MemberInfo element, Type attributeType, bool shouldCache); // 0x0000000181520300-0x00000001815205A0
		public static TAttribute GetAttribute<TAttribute>(MemberInfo element, bool shouldCache)
			where TAttribute : Attribute;
		public static TAttribute GetAttribute<TAttribute>(MemberInfo element)
			where TAttribute : Attribute;
		public static MemberInfo AsMemberInfo(Type type); // 0x0000000180411160-0x0000000180411170
		public static bool IsType(MemberInfo member); // 0x00000001815214C0-0x0000000181521530
		public static Type AsType(MemberInfo member); // 0x0000000181520280-0x0000000181520300
	
		// Extension methods
		public static PropertyInfo GetDeclaredProperty(this Type type, string propertyName); // 0x0000000181520D50-0x0000000181520ED0
		public static MethodInfo GetDeclaredMethod(this Type type, string methodName); // 0x0000000181520AD0-0x0000000181520C50
		public static ConstructorInfo GetDeclaredConstructor(this Type type, Type[] parameters); // 0x00000001815205A0-0x00000001815207D0
		public static ConstructorInfo[] GetDeclaredConstructors(this Type type); // 0x00000001815207D0-0x0000000181520850
		public static MemberInfo[] GetFlattenedMember(this Type type, string memberName); // 0x0000000181520ED0-0x00000001815210B0
		public static MethodInfo GetFlattenedMethod(this Type type, string methodName); // 0x00000001815210B0-0x0000000181521240
		[IteratorStateMachine] // 0x00000001802562B0-0x0000000180256320
		public static IEnumerable<MethodInfo> GetFlattenedMethods(this Type type, string methodName); // 0x0000000181521240-0x00000001815212C0
		public static PropertyInfo GetFlattenedProperty(this Type type, string propertyName); // 0x00000001815212C0-0x0000000181521450
		public static MemberInfo GetDeclaredMember(this Type type, string memberName); // 0x00000001815208D0-0x0000000181520A50
		public static MethodInfo[] GetDeclaredMethods(this Type type); // 0x0000000181520C50-0x0000000181520CD0
		public static PropertyInfo[] GetDeclaredProperties(this Type type); // 0x0000000181520CD0-0x0000000181520D50
		public static FieldInfo[] GetDeclaredFields(this Type type); // 0x0000000181520850-0x00000001815208D0
		public static MemberInfo[] GetDeclaredMembers(this Type type); // 0x0000000181520A50-0x0000000181520AD0
		public static Type Resolve(this Type type); // 0x0000000180411160-0x0000000180411170
	}
}
