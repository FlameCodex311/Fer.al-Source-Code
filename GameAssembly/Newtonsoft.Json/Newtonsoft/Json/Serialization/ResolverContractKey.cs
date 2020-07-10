/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	internal struct ResolverContractKey : IEquatable<Newtonsoft.Json.Serialization.ResolverContractKey> // TypeDefIndex: 7903
	{
		// Fields
		private readonly Type _resolverType; // 0x00
		private readonly Type _contractType; // 0x08
	
		// Constructors
		public ResolverContractKey(Type resolverType, Type contractType); // 0x0000000180005D30-0x0000000180005EC0
	
		// Methods
		public override int GetHashCode(); // 0x0000000180007D30-0x0000000180007DB0
		public override bool Equals(object obj); // 0x0000000180007C60-0x0000000180007D00
		public bool Equals(ResolverContractKey other); // 0x0000000180007D00-0x0000000180007D30
	}
}
