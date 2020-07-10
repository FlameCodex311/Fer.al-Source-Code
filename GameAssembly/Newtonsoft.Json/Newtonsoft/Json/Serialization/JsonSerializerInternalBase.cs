/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	internal abstract class JsonSerializerInternalBase // TypeDefIndex: 7933
	{
		// Fields
		private ErrorContext _currentErrorContext; // 0x10
		private BidirectionalDictionary<string, object> _mappings; // 0x18
		internal readonly JsonSerializer Serializer; // 0x20
		internal readonly ITraceWriter TraceWriter; // 0x28
		protected JsonSerializerProxy InternalSerializer; // 0x30
	
		// Properties
		internal BidirectionalDictionary<string, object> DefaultReferenceMappings { get; } // 0x00000001804EB760-0x00000001804EB830 
	
		// Nested types
		private class ReferenceEqualsEqualityComparer : IEqualityComparer<object> // TypeDefIndex: 7934
		{
			// Constructors
			public ReferenceEqualsEqualityComparer(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			bool IEqualityComparer<object>.Equals(object x, object y); // 0x00000001804F7880-0x00000001804F7890
			int IEqualityComparer<object>.GetHashCode(object obj); // 0x00000001804F7890-0x00000001804F7A10
		}
	
		// Constructors
		protected JsonSerializerInternalBase(JsonSerializer serializer); // 0x00000001804EB6E0-0x00000001804EB760
	
		// Methods
		private ErrorContext GetErrorContext(object currentObject, object member, string path, Exception error); // 0x00000001804EB250-0x00000001804EB340
		protected void ClearErrorContext(); // 0x00000001804EB1E0-0x00000001804EB250
		protected bool IsErrorHandled(object currentObject, JsonContract contract, object keyValue, IJsonLineInfo lineInfo, string path, Exception ex); // 0x00000001804EB340-0x00000001804EB6E0
	}
}
