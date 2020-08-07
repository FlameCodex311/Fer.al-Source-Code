/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	internal struct ResolverContractKey : IEquatable<Newtonsoft.Json.Serialization.ResolverContractKey> // TypeDefIndex: 8069
	{
		// Fields
		private readonly Type _resolverType; // 0x00
		private readonly Type _contractType; // 0x08
	
		// Constructors
		public ResolverContractKey(Type resolverType, Type contractType); // 0x0000000180006CF0-0x0000000180006D00
	
		// Methods
		public override int GetHashCode(); // 0x000000018001B770-0x000000018001B7D0
		public override bool Equals(object obj); // 0x000000018005CF30-0x000000018005CFD0
		public bool Equals(ResolverContractKey other); // 0x000000018005CFD0-0x000000018005D020
	}
}
