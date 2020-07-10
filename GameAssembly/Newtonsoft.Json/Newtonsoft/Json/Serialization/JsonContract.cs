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

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	public abstract class JsonContract // TypeDefIndex: 7925
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
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Type <UnderlyingType>k__BackingField; // 0x60
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool? <IsReference>k__BackingField; // 0x68
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private JsonConverter <Converter>k__BackingField; // 0x70
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private JsonConverter <InternalConverter>k__BackingField; // 0x78
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Func<object> <DefaultCreator>k__BackingField; // 0x80
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <DefaultCreatorNonPublic>k__BackingField; // 0x88
	
		// Properties
		public Type UnderlyingType { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369B40-0x0000000180369B50 0x00000001803A27E0-0x00000001803A27F0
		public Type CreatedType { get; set; } // 0x0000000180357120-0x0000000180357130 0x00000001804E8AF0-0x00000001804E8B50
		public bool? IsReference { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804E88B0-0x00000001804E88C0 0x00000001804E8B50-0x00000001804E8B60
		public JsonConverter Converter { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180369B50-0x0000000180369B60 0x00000001803C87F0-0x00000001803C8800
		internal JsonConverter InternalConverter { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180369C70-0x0000000180369C80 0x00000001803D8EF0-0x00000001803D8F00
		public IList<SerializationCallback> OnDeserializedCallbacks { get; } // 0x00000001804E88C0-0x00000001804E8930 
		public IList<SerializationCallback> OnDeserializingCallbacks { get; } // 0x00000001804E8930-0x00000001804E89A0 
		public IList<SerializationCallback> OnSerializedCallbacks { get; } // 0x00000001804E8A10-0x00000001804E8A80 
		public IList<SerializationCallback> OnSerializingCallbacks { get; } // 0x00000001804E8A80-0x00000001804E8AF0 
		public IList<SerializationErrorCallback> OnErrorCallbacks { get; } // 0x00000001804E89A0-0x00000001804E8A10 
		public Func<object> DefaultCreator { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018035FCB0-0x000000018035FCC0 0x00000001803D8ED0-0x00000001803D8EE0
		public bool DefaultCreatorNonPublic { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001804E88A0-0x00000001804E88B0 0x0000000180386220-0x0000000180386230
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass73_0 // TypeDefIndex: 7926
		{
			// Fields
			public MethodInfo callbackMethodInfo; // 0x10
	
			// Constructors
			public <>c__DisplayClass73_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <CreateSerializationCallback>b__0(object o, StreamingContext context); // 0x00000001804F8600-0x00000001804F8700
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass74_0 // TypeDefIndex: 7927
		{
			// Fields
			public MethodInfo callbackMethodInfo; // 0x10
	
			// Constructors
			public <>c__DisplayClass74_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <CreateSerializationErrorCallback>b__0(object o, StreamingContext context, ErrorContext econtext); // 0x00000001804F8700-0x00000001804F8860
		}
	
		// Constructors
		internal JsonContract(Type underlyingType); // 0x00000001804E8750-0x00000001804E88A0
	
		// Methods
		internal void InvokeOnSerializing(object o, StreamingContext context); // 0x00000001804E85A0-0x00000001804E8750
		internal void InvokeOnSerialized(object o, StreamingContext context); // 0x00000001804E83F0-0x00000001804E85A0
		internal void InvokeOnDeserializing(object o, StreamingContext context); // 0x00000001804E8070-0x00000001804E8220
		internal void InvokeOnDeserialized(object o, StreamingContext context); // 0x00000001804E7F20-0x00000001804E8070
		internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext); // 0x00000001804E8220-0x00000001804E83F0
		internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo); // 0x00000001804E7E00-0x00000001804E7E90
		internal static SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo); // 0x00000001804E7E90-0x00000001804E7F20
	}
}
