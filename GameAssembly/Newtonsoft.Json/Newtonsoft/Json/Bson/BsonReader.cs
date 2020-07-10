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

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Bson
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	public class BsonReader : JsonReader // TypeDefIndex: 8047
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
		public DateTimeKind DateTimeKindHandling { get; } // 0x00000001806891F0-0x0000000180689200 
	
		// Nested types
		private enum BsonReaderState // TypeDefIndex: 8048
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
	
		private class ContainerContext // TypeDefIndex: 8049
		{
			// Fields
			public readonly BsonType Type; // 0x10
			public int Length; // 0x14
			public int Position; // 0x18
	
			// Constructors
			public ContainerContext(BsonType type); // 0x0000000180419200-0x0000000180419230
		}
	
		// Constructors
		static BsonReader(); // 0x0000000180689000-0x00000001806891F0
	
		// Methods
		private string ReadElement(); // 0x0000000180687AE0-0x0000000180687B40
		public override bool Read(); // 0x0000000180688E70-0x0000000180689000
		public override void Close(); // 0x0000000180686F90-0x0000000180686FC0
		private bool ReadCodeWScope(); // 0x0000000180687730-0x0000000180687AA0
		private bool ReadReference(); // 0x0000000180687FC0-0x0000000180688360
		private bool ReadNormal(); // 0x0000000180687C60-0x0000000180687FC0
		private void PopContext(); // 0x0000000180687450-0x0000000180687520
		private void PushContext(ContainerContext newContext); // 0x0000000180687520-0x0000000180687580
		private byte ReadByte(); // 0x00000001806876B0-0x00000001806876F0
		private void ReadType(BsonType type); // 0x00000001806886D0-0x0000000180688E70
		private byte[] ReadBinary(out BsonBinaryType binaryType); // 0x0000000180687580-0x00000001806876B0
		private string ReadString(); // 0x0000000180688360-0x0000000180688690
		private string ReadLengthString(); // 0x0000000180687BC0-0x0000000180687C60
		private string GetString(int length); // 0x00000001806870F0-0x0000000180687430
		private int GetLastFullCharStop(int start); // 0x0000000180687060-0x00000001806870F0
		private int BytesInSequence(byte b); // 0x0000000180686CA0-0x0000000180686F90
		private void EnsureBuffers(); // 0x0000000180686FC0-0x0000000180687060
		private double ReadDouble(); // 0x0000000180687AA0-0x0000000180687AE0
		private int ReadInt32(); // 0x0000000180687B40-0x0000000180687B80
		private long ReadInt64(); // 0x0000000180687B80-0x0000000180687BC0
		private BsonType ReadType(); // 0x0000000180688690-0x00000001806886D0
		private void MovePosition(int count); // 0x0000000180687430-0x0000000180687450
		private byte[] ReadBytes(int count); // 0x00000001806876F0-0x0000000180687730
	}
}
