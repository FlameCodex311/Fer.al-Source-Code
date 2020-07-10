/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia.FullSerializer.Internal
{
	public struct fsVersionedType // TypeDefIndex: 9163
	{
		// Fields
		public fsVersionedType[] Ancestors; // 0x00
		public string VersionString; // 0x08
		public Type ModelType; // 0x10
	
		// Methods
		public object Migrate(object ancestorInstance); // 0x00000001802A3AE0-0x00000001802A3AF0
		public override string ToString(); // 0x00000001802A3AF0-0x00000001802A3BC0
		public static bool operator ==(fsVersionedType a, fsVersionedType b); // 0x0000000181905450-0x00000001819054D0
		public static bool operator !=(fsVersionedType a, fsVersionedType b); // 0x00000001819054D0-0x0000000181905550
		public override bool Equals(object obj); // 0x00000001802A3A00-0x00000001802A3AB0
		public override int GetHashCode(); // 0x00000001802A3AB0-0x00000001802A3AE0
	}
}
