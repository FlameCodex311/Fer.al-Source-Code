/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	public abstract class JsonContract // TypeDefIndex: 8091
	{
		// Fields
		internal bool IsNullable; // 0x10
		internal bool IsConvertable; // 0x11
		internal bool IsEnum; // 0x12
		internal Type NonNullableUnderlyingType; // 0x18
		internal ReadType InternalReadType; // 0x20
		internal JsonContractType ContractType; // 0x24
		internal bool IsReadOnlyOrFixedSize; // 0x28
		internal bool IsSealed; // 0x29
		internal bool IsInstantiable; // 0x2A
		private List<SerializationCallback> _onDeserializedCallbacks; // 0x30
		private IList<SerializationCallback> _onDeserializingCallbacks; // 0x38
		private IList<SerializationCallback> _onSerializedCallbacks; // 0x40
		private IList<SerializationCallback> _onSerializingCallbacks; // 0x48
		private IList<SerializationErrorCallback> _onErrorCallbacks; // 0x50
		private Type _createdType; // 0x58
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Type <UnderlyingType>k__BackingField; // 0x60
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool? <IsReference>k__BackingField; // 0x68
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private JsonConverter <Converter>k__BackingField; // 0x70
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private JsonConverter <InternalConverter>k__BackingField; // 0x78
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Func<object> <DefaultCreator>k__BackingField; // 0x80
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <DefaultCreatorNonPublic>k__BackingField; // 0x88
	
		// Properties
		public Type UnderlyingType { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180418970-0x0000000180418980 0x00000001804AF510-0x00000001804AF520
		public Type CreatedType { get; set; } // 0x00000001803A1580-0x00000001803A1590 0x0000000180E8E300-0x0000000180E8E360
		public bool? IsReference { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180E8E0C0-0x0000000180E8E0D0 0x0000000180E8E360-0x0000000180E8E370
		public JsonConverter Converter { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180418980-0x0000000180418990 0x00000001804C61A0-0x00000001804C61B0
		internal JsonConverter InternalConverter { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180418A40-0x0000000180418A50 0x00000001804B47D0-0x00000001804B47E0
		public IList<SerializationCallback> OnDeserializedCallbacks { get; } // 0x0000000180E8E0D0-0x0000000180E8E140 
		public IList<SerializationCallback> OnDeserializingCallbacks { get; } // 0x0000000180E8E140-0x0000000180E8E1B0 
		public IList<SerializationCallback> OnSerializedCallbacks { get; } // 0x0000000180E8E220-0x0000000180E8E290 
		public IList<SerializationCallback> OnSerializingCallbacks { get; } // 0x0000000180E8E290-0x0000000180E8E300 
		public IList<SerializationErrorCallback> OnErrorCallbacks { get; } // 0x0000000180E8E1B0-0x0000000180E8E220 
		public Func<object> DefaultCreator { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018040ED60-0x000000018040ED70 0x00000001804793A0-0x00000001804793B0
		public bool DefaultCreatorNonPublic { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001804A0200-0x00000001804A0210 0x0000000180434D60-0x0000000180434D70
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass73_0 // TypeDefIndex: 8092
		{
			// Fields
			public MethodInfo callbackMethodInfo; // 0x10
	
			// Constructors
			public <>c__DisplayClass73_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <CreateSerializationCallback>b__0(object o, StreamingContext context); // 0x0000000180E9D870-0x0000000180E9D960
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass74_0 // TypeDefIndex: 8093
		{
			// Fields
			public MethodInfo callbackMethodInfo; // 0x10
	
			// Constructors
			public <>c__DisplayClass74_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <CreateSerializationErrorCallback>b__0(object o, StreamingContext context, ErrorContext econtext); // 0x0000000180E9D960-0x0000000180E9DAA0
		}
	
		// Constructors
		internal JsonContract(Type underlyingType); // 0x0000000180E8DF70-0x0000000180E8E0C0
	
		// Methods
		internal void InvokeOnSerializing(object o, StreamingContext context); // 0x0000000180E8DDC0-0x0000000180E8DF70
		internal void InvokeOnSerialized(object o, StreamingContext context); // 0x0000000180E8DC10-0x0000000180E8DDC0
		internal void InvokeOnDeserializing(object o, StreamingContext context); // 0x0000000180E8D8A0-0x0000000180E8DA50
		internal void InvokeOnDeserialized(object o, StreamingContext context); // 0x0000000180E8D750-0x0000000180E8D8A0
		internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext); // 0x0000000180E8DA50-0x0000000180E8DC10
		internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo); // 0x0000000180E8D630-0x0000000180E8D6C0
		internal static SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo); // 0x0000000180E8D6C0-0x0000000180E8D750
	}
}
