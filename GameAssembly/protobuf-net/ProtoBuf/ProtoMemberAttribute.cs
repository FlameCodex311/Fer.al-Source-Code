/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 54: protobuf-net.dll - Assembly: protobuf-net, Version=2.0.0.580, Culture=neutral, PublicKeyToken=257b51d87d2e4d67 - Types 7160-7162

namespace ProtoBuf
{
	[AttributeUsage] // 0x00000001800CFBA0-0x00000001800CFBD0
	public class ProtoMemberAttribute : Attribute, IComparable, IComparable<ProtoBuf.ProtoMemberAttribute> // TypeDefIndex: 7162
	{
		// Fields
		private string name; // 0x10
		private int tag; // 0x18
	
		// Constructors
		public ProtoMemberAttribute(int tag); // 0x0000000180E061F0-0x0000000180E06270
		internal ProtoMemberAttribute(int tag, bool forced); // 0x0000000180E06160-0x0000000180E061F0
	
		// Methods
		public int CompareTo(object other); // 0x0000000180E06010-0x0000000180E060F0
		public int CompareTo(ProtoMemberAttribute other); // 0x0000000180E060F0-0x0000000180E06160
	}
}
