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

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	internal class DefaultReferenceResolver : IReferenceResolver // TypeDefIndex: 7901
	{
		// Fields
		private int _referenceCount; // 0x10
	
		// Constructors
		public DefaultReferenceResolver(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		private BidirectionalDictionary<string, object> GetMappings(object context); // 0x00000001804DFFC0-0x00000001804E0250
		public object ResolveReference(object context, string reference); // 0x00000001804E03B0-0x00000001804E0440
		public string GetReference(object context, object value); // 0x00000001804E0250-0x00000001804E0330
		public void AddReference(object context, string reference, object value); // 0x00000001804DFF40-0x00000001804DFFC0
		public bool IsReferenced(object context, object value); // 0x00000001804E0330-0x00000001804E03B0
	}
}
