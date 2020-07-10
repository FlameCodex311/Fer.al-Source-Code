/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Newtonsoft.Json.Shims;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Bson
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	internal class BsonBinaryWriter // TypeDefIndex: 8046
	{
		// Fields
		private static readonly Encoding Encoding; // 0x00
		private readonly BinaryWriter _writer; // 0x10
		private byte[] _largeByteBuffer; // 0x18
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private DateTimeKind <DateTimeKindHandling>k__BackingField; // 0x20
	
		// Properties
		public DateTimeKind DateTimeKindHandling { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x00000001803C2700-0x00000001803C2710 
	
		// Constructors
		static BsonBinaryWriter(); // 0x0000000180686530-0x0000000180686590
	
		// Methods
		public void Close(); // 0x000000018047ACE0-0x000000018047AD10
		public void WriteToken(BsonToken t); // 0x0000000180686360-0x0000000180686390
		private void WriteTokenInternal(BsonToken t); // 0x00000001806856F0-0x0000000180686360
		private void WriteString(string s, int byteCount, int? calculatedlengthPrefix); // 0x00000001806854E0-0x00000001806856F0
		public void WriteUtf8Bytes(string s, int byteCount); // 0x0000000180686390-0x0000000180686530
		private int CalculateSize(int stringByteCount); // 0x0000000180684F10-0x0000000180684F20
		private int CalculateSizeWithLength(int stringByteCount, bool includeSize); // 0x0000000180684EF0-0x0000000180684F10
		private int CalculateSize(BsonToken t); // 0x0000000180684F20-0x00000001806854E0
	}
}
