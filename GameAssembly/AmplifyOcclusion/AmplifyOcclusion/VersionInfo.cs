/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 74: AmplifyOcclusion.dll - Assembly: AmplifyOcclusion, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8941-8957

namespace AmplifyOcclusion
{
	[Serializable]
	public class VersionInfo // TypeDefIndex: 8954
	{
		// Fields
		public const byte Major = 2; // Metadata: 0x00743EDD
		public const byte Minor = 0; // Metadata: 0x00743EDE
		public const byte Release = 3; // Metadata: 0x00743EDF
		public const byte Revision = 0; // Metadata: 0x00743EE0
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private int m_major; // 0x10
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private int m_minor; // 0x14
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private int m_release; // 0x18
	
		// Properties
		public int Number { get; } // 0x00000001822BD6F0-0x00000001822BD710 
	
		// Constructors
		private VersionInfo(); // 0x00000001822BD670-0x00000001822BD6A0
		private VersionInfo(byte major, byte minor, byte release); // 0x00000001822BD6A0-0x00000001822BD6F0
	
		// Methods
		public static string StaticToString(); // 0x00000001822BD240-0x00000001822BD450
		public override string ToString(); // 0x00000001822BD450-0x00000001822BD670
		public static VersionInfo Current(); // 0x00000001822BD1B0-0x00000001822BD210
		public static bool Matches(VersionInfo version); // 0x00000001822BD210-0x00000001822BD240
	}
}
