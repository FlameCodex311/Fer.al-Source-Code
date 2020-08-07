/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	internal class DefaultReferenceResolver : IReferenceResolver // TypeDefIndex: 8067
	{
		// Fields
		private int _referenceCount; // 0x10
	
		// Constructors
		public DefaultReferenceResolver(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		private BidirectionalDictionary<string, object> GetMappings(object context); // 0x0000000180E8A7B0-0x0000000180E8AA30
		public object ResolveReference(object context, string reference); // 0x0000000180E8AB90-0x0000000180E8AC20
		public string GetReference(object context, object value); // 0x0000000180E8AA30-0x0000000180E8AB10
		public void AddReference(object context, string reference, object value); // 0x0000000180E8A730-0x0000000180E8A7B0
		public bool IsReferenced(object context, object value); // 0x0000000180E8AB10-0x0000000180E8AB90
	}
}
