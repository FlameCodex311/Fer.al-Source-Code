/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Bson
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class BsonReader : JsonReader // TypeDefIndex: 8213
	{
		// Fields
		private static readonly byte[] SeqRange1; // 0x00
		private static readonly byte[] SeqRange2; // 0x08
		private static readonly byte[] SeqRange3; // 0x10
		private static readonly byte[] SeqRange4; // 0x18
		private readonly BinaryReader _reader; // 0x78
		private readonly List<ContainerContext> _stack; // 0x80
		private byte[] _byteBuffer; // 0x88
		private char[] _charBuffer; // 0x90
		private BsonType _currentElementType; // 0x98
		private BsonReaderState _bsonReaderState; // 0x9C
		private ContainerContext _currentContext; // 0xA0
		private bool _readRootValueAsArray; // 0xA8
		private bool _jsonNet35BinaryCompatibility; // 0xA9
		private DateTimeKind _dateTimeKindHandling; // 0xAC
	
		// Properties
		public DateTimeKind DateTimeKindHandling { get; } // 0x0000000180AD57F0-0x0000000180AD5800 
	
		// Nested types
		private enum BsonReaderState // TypeDefIndex: 8214
		{
			Normal = 0,
			ReferenceStart = 1,
			ReferenceRef = 2,
			ReferenceId = 3,
			CodeWScopeStart = 4,
			CodeWScopeCode = 5,
			CodeWScopeScope = 6,
			CodeWScopeScopeObject = 7,
			CodeWScopeScopeEnd = 8
		}
	
		private class ContainerContext // TypeDefIndex: 8215
		{
			// Fields
			public readonly BsonType Type; // 0x10
			public int Length; // 0x14
			public int Position; // 0x18
	
			// Constructors
			public ContainerContext(BsonType type); // 0x0000000180824FE0-0x0000000180825010
		}
	
		// Constructors
		static BsonReader(); // 0x0000000180C61720-0x0000000180C618F0
	
		// Methods
		private string ReadElement(); // 0x0000000180C601F0-0x0000000180C60250
		public override bool Read(); // 0x0000000180C61590-0x0000000180C61720
		private bool ReadCodeWScope(); // 0x0000000180C5FE10-0x0000000180C601B0
		private bool ReadReference(); // 0x0000000180C606D0-0x0000000180C60A60
		private bool ReadNormal(); // 0x0000000180C60370-0x0000000180C606D0
		private void PopContext(); // 0x0000000180C5FB50-0x0000000180C5FC10
		private void PushContext(ContainerContext newContext); // 0x0000000180C5FC10-0x0000000180C5FC70
		private byte ReadByte(); // 0x0000000180C5FD90-0x0000000180C5FDD0
		private void ReadType(BsonType type); // 0x0000000180C60DC0-0x0000000180C61590
		private byte[] ReadBinary(out BsonBinaryType binaryType); // 0x0000000180C5FC70-0x0000000180C5FD90
		private string ReadString(); // 0x0000000180C60A60-0x0000000180C60D80
		private string ReadLengthString(); // 0x0000000180C602D0-0x0000000180C60370
		private string GetString(int length); // 0x0000000180C5F800-0x0000000180C5FB30
		private int GetLastFullCharStop(int start); // 0x0000000180C5F770-0x0000000180C5F800
		private int BytesInSequence(byte b); // 0x0000000180C5F400-0x0000000180C5F6D0
		private void EnsureBuffers(); // 0x0000000180C5F6D0-0x0000000180C5F770
		private double ReadDouble(); // 0x0000000180C601B0-0x0000000180C601F0
		private int ReadInt32(); // 0x0000000180C60250-0x0000000180C60290
		private long ReadInt64(); // 0x0000000180C60290-0x0000000180C602D0
		private BsonType ReadType(); // 0x0000000180C60D80-0x0000000180C60DC0
		private void MovePosition(int count); // 0x0000000180C5FB30-0x0000000180C5FB50
		private byte[] ReadBytes(int count); // 0x0000000180C5FDD0-0x0000000180C5FE10
	}
}
