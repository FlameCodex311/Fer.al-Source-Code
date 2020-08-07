/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 75: AmplifyOcclusion.dll - Assembly: AmplifyOcclusion, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9107-9123

namespace AmplifyOcclusion
{
	[Serializable]
	public class VersionInfo // TypeDefIndex: 9120
	{
		// Fields
		public const byte Major = 2; // Metadata: 0x00778BCB
		public const byte Minor = 0; // Metadata: 0x00778BCC
		public const byte Release = 3; // Metadata: 0x00778BCD
		public const byte Revision = 0; // Metadata: 0x00778BCE
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int m_major; // 0x10
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int m_minor; // 0x14
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int m_release; // 0x18
	
		// Properties
		public int Number { get; } // 0x0000000182098A60-0x0000000182098A80 
	
		// Constructors
		private VersionInfo(); // 0x00000001820989E0-0x0000000182098A10
		private VersionInfo(byte major, byte minor, byte release); // 0x0000000182098A10-0x0000000182098A60
	
		// Methods
		public static string StaticToString(); // 0x00000001820985E0-0x00000001820987E0
		public override string ToString(); // 0x00000001820987E0-0x00000001820989E0
		public static VersionInfo Current(); // 0x0000000182098550-0x00000001820985B0
		public static bool Matches(VersionInfo version); // 0x00000001820985B0-0x00000001820985E0
	}
}
