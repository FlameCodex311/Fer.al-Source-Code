/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia.FullSerializer.Internal
{
	public static class fsPortableReflection // TypeDefIndex: 9159
	{
		// Fields
		public static Type[] EmptyTypes; // 0x00
		private static IDictionary<AttributeQuery, Attribute> _cachedAttributeQueries; // 0x08
		private static BindingFlags DeclaredFlags; // 0x10
	
		// Nested types
		private struct AttributeQuery // TypeDefIndex: 9160
		{
			// Fields
			public MemberInfo MemberInfo; // 0x00
			public Type AttributeType; // 0x08
		}
	
		private class AttributeQueryComparator : IEqualityComparer<AttributeQuery> // TypeDefIndex: 9161
		{
			// Constructors
			public AttributeQueryComparator(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			public bool Equals(AttributeQuery x, AttributeQuery y); // 0x00000001818E2690-0x00000001818E2730
			public int GetHashCode(AttributeQuery obj); // 0x00000001818E2730-0x00000001818E27A0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <GetFlattenedMethods>d__16 : IEnumerable<MethodInfo>, IEnumerator<MethodInfo> // TypeDefIndex: 9162
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
			MethodInfo IEnumerator<System.Reflection.MethodInfo>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <GetFlattenedMethods>d__16(int <>1__state); // 0x000000018094DE20-0x000000018094DE50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001818E9040-0x00000001818E9240
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001818E92E0-0x00000001818E9330
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator<MethodInfo> IEnumerable<MethodInfo>.GetEnumerator(); // 0x00000001818E9240-0x00000001818E92E0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			IEnumerator IEnumerable.GetEnumerator(); // 0x00000001818E9240-0x00000001818E92E0
		}
	
		// Constructors
		static fsPortableReflection(); // 0x00000001818FC860-0x00000001818FC910
	
		// Methods
		public static bool HasAttribute(MemberInfo element, Type attributeType); // 0x00000001818FC780-0x00000001818FC7F0
		public static bool HasAttribute<TAttribute>(MemberInfo element);
		public static Attribute GetAttribute(MemberInfo element, Type attributeType, bool shouldCache); // 0x00000001818FB600-0x00000001818FB8B0
		public static TAttribute GetAttribute<TAttribute>(MemberInfo element, bool shouldCache)
			where TAttribute : Attribute;
		public static TAttribute GetAttribute<TAttribute>(MemberInfo element)
			where TAttribute : Attribute;
		public static MemberInfo AsMemberInfo(Type type); // 0x0000000180362190-0x00000001803621A0
		public static bool IsType(MemberInfo member); // 0x00000001818FC7F0-0x00000001818FC860
		public static Type AsType(MemberInfo member); // 0x00000001818FB580-0x00000001818FB600
	
		// Extension methods
		public static PropertyInfo GetDeclaredProperty(this Type type, string propertyName); // 0x00000001818FC070-0x00000001818FC1F0
		public static MethodInfo GetDeclaredMethod(this Type type, string methodName); // 0x00000001818FBDF0-0x00000001818FBF70
		public static ConstructorInfo GetDeclaredConstructor(this Type type, Type[] parameters); // 0x00000001818FB8B0-0x00000001818FBAF0
		public static ConstructorInfo[] GetDeclaredConstructors(this Type type); // 0x00000001818FBAF0-0x00000001818FBB70
		public static MemberInfo[] GetFlattenedMember(this Type type, string memberName); // 0x00000001818FC1F0-0x00000001818FC3E0
		public static MethodInfo GetFlattenedMethod(this Type type, string methodName); // 0x00000001818FC3E0-0x00000001818FC570
		[IteratorStateMachine] // 0x00000001800F6DC0-0x00000001800F6E30
		public static IEnumerable<MethodInfo> GetFlattenedMethods(this Type type, string methodName); // 0x00000001818FC570-0x00000001818FC5F0
		public static PropertyInfo GetFlattenedProperty(this Type type, string propertyName); // 0x00000001818FC5F0-0x00000001818FC780
		public static MemberInfo GetDeclaredMember(this Type type, string memberName); // 0x00000001818FBBF0-0x00000001818FBD70
		public static MethodInfo[] GetDeclaredMethods(this Type type); // 0x00000001818FBF70-0x00000001818FBFF0
		public static PropertyInfo[] GetDeclaredProperties(this Type type); // 0x00000001818FBFF0-0x00000001818FC070
		public static FieldInfo[] GetDeclaredFields(this Type type); // 0x00000001818FBB70-0x00000001818FBBF0
		public static MemberInfo[] GetDeclaredMembers(this Type type); // 0x00000001818FBD70-0x00000001818FBDF0
		public static Type Resolve(this Type type); // 0x0000000180362190-0x00000001803621A0
	}
}
