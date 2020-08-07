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

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	internal abstract class JsonSerializerInternalBase // TypeDefIndex: 8099
	{
		// Fields
		private ErrorContext _currentErrorContext; // 0x10
		private BidirectionalDictionary<string, object> _mappings; // 0x18
		internal readonly JsonSerializer Serializer; // 0x20
		internal readonly ITraceWriter TraceWriter; // 0x28
		protected JsonSerializerProxy InternalSerializer; // 0x30
	
		// Properties
		internal BidirectionalDictionary<string, object> DefaultReferenceMappings { get; } // 0x0000000180E90E50-0x0000000180E90F20 
	
		// Nested types
		private class ReferenceEqualsEqualityComparer : IEqualityComparer<object> // TypeDefIndex: 8100
		{
			// Constructors
			public ReferenceEqualsEqualityComparer(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			bool IEqualityComparer<object>.Equals(object x, object y); // 0x0000000180442CA0-0x0000000180442CB0
			int IEqualityComparer<object>.GetHashCode(object obj); // 0x0000000180E9CB30-0x0000000180E9CCB0
		}
	
		// Constructors
		protected JsonSerializerInternalBase(JsonSerializer serializer); // 0x0000000180E90DD0-0x0000000180E90E50
	
		// Methods
		private ErrorContext GetErrorContext(object currentObject, object member, string path, Exception error); // 0x0000000180E90950-0x0000000180E90A40
		protected void ClearErrorContext(); // 0x0000000180E908E0-0x0000000180E90950
		protected bool IsErrorHandled(object currentObject, JsonContract contract, object keyValue, IJsonLineInfo lineInfo, string path, Exception ex); // 0x0000000180E90A40-0x0000000180E90DD0
	}
}
