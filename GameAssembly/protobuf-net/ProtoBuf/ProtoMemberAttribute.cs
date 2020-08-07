/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 55: protobuf-net.dll - Assembly: protobuf-net, Version=2.0.0.580, Culture=neutral, PublicKeyToken=257b51d87d2e4d67 - Types 7326-7328

namespace ProtoBuf
{
	[AttributeUsage] // 0x00000001801D30E0-0x00000001801D3110
	public class ProtoMemberAttribute : Attribute, IComparable, IComparable<ProtoBuf.ProtoMemberAttribute> // TypeDefIndex: 7328
	{
		// Fields
		private string name; // 0x10
		private int tag; // 0x18
	
		// Constructors
		public ProtoMemberAttribute(int tag); // 0x00000001820EA3E0-0x00000001820EA460
		internal ProtoMemberAttribute(int tag, bool forced); // 0x00000001820EA350-0x00000001820EA3E0
	
		// Methods
		public int CompareTo(object other); // 0x00000001820EA200-0x00000001820EA2E0
		public int CompareTo(ProtoMemberAttribute other); // 0x00000001820EA2E0-0x00000001820EA350
	}
}
