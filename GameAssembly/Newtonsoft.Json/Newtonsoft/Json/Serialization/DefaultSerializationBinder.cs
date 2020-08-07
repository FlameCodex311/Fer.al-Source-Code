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

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class DefaultSerializationBinder : SerializationBinder // TypeDefIndex: 8080
	{
		// Fields
		internal static readonly DefaultSerializationBinder Instance; // 0x00
		private readonly ThreadSafeStore<TypeNameKey, Type> _typeCache; // 0x10
	
		// Nested types
		internal struct TypeNameKey : IEquatable<TypeNameKey> // TypeDefIndex: 8081
		{
			// Fields
			internal readonly string AssemblyName; // 0x00
			internal readonly string TypeName; // 0x08
	
			// Constructors
			public TypeNameKey(string assemblyName, string typeName); // 0x0000000180006CF0-0x0000000180006D00
	
			// Methods
			public override int GetHashCode(); // 0x00000001800A45F0-0x00000001800A4A00
			public override bool Equals(object obj); // 0x00000001800A44E0-0x00000001800A4590
			public bool Equals(TypeNameKey other); // 0x00000001800A4590-0x00000001800A45F0
		}
	
		// Constructors
		public DefaultSerializationBinder(); // 0x0000000180E8AFF0-0x0000000180E8B090
		static DefaultSerializationBinder(); // 0x0000000180E8AF20-0x0000000180E8AFF0
	
		// Methods
		private static Type GetTypeFromTypeNameKey(TypeNameKey typeNameKey); // 0x0000000180E8ACA0-0x0000000180E8AF20
		public override Type BindToType(string assemblyName, string typeName); // 0x0000000180E8AC20-0x0000000180E8ACA0
	}
}
