/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia.FullSerializer.Internal
{
	public struct fsVersionedType // TypeDefIndex: 9328
	{
		// Fields
		public fsVersionedType[] Ancestors; // 0x00
		public string VersionString; // 0x08
		public Type ModelType; // 0x10
	
		// Methods
		public object Migrate(object ancestorInstance); // 0x00000001800C4A80-0x00000001800C4B40
		public override string ToString(); // 0x00000001800C4B40-0x00000001800C4C70
		public static bool operator ==(fsVersionedType a, fsVersionedType b); // 0x0000000181525310-0x0000000181525390
		public static bool operator !=(fsVersionedType a, fsVersionedType b); // 0x0000000181525390-0x0000000181525410
		public override bool Equals(object obj); // 0x00000001800C49A0-0x00000001800C4A50
		public override int GetHashCode(); // 0x00000001800C4A50-0x00000001800C4A80
	}
}
