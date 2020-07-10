/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	public class DefaultSerializationBinder : SerializationBinder // TypeDefIndex: 7914
	{
		// Fields
		internal static readonly DefaultSerializationBinder Instance; // 0x00
		private readonly ThreadSafeStore<TypeNameKey, Type> _typeCache; // 0x10
	
		// Nested types
		internal struct TypeNameKey : IEquatable<TypeNameKey> // TypeDefIndex: 7915
		{
			// Fields
			internal readonly string AssemblyName; // 0x00
			internal readonly string TypeName; // 0x08
	
			// Constructors
			public TypeNameKey(string assemblyName, string typeName); // 0x0000000180005D30-0x0000000180005EC0
	
			// Methods
			public override int GetHashCode(); // 0x00000001800065E0-0x0000000180006720
			public override bool Equals(object obj); // 0x00000001800064D0-0x0000000180006580
			public bool Equals(TypeNameKey other); // 0x0000000180006580-0x00000001800065E0
		}
	
		// Constructors
		public DefaultSerializationBinder(); // 0x00000001804E0820-0x00000001804E08C0
		static DefaultSerializationBinder(); // 0x00000001804E0750-0x00000001804E0820
	
		// Methods
		private static Type GetTypeFromTypeNameKey(TypeNameKey typeNameKey); // 0x00000001804E04C0-0x00000001804E0750
		public override Type BindToType(string assemblyName, string typeName); // 0x00000001804E0440-0x00000001804E04C0
	}
}
