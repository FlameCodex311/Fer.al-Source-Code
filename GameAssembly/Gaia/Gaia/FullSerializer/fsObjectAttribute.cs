/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia.FullSerializer
{
	[AttributeUsage] // 0x00000001800C0F10-0x00000001800C0F30
	public sealed class fsObjectAttribute : Attribute // TypeDefIndex: 9128
	{
		// Fields
		public Type[] PreviousModels; // 0x10
		public string VersionString; // 0x18
		public fsMemberSerialization MemberSerialization; // 0x20
		public Type Converter; // 0x28
		public Type Processor; // 0x30
	
		// Constructors
		public fsObjectAttribute(); // 0x00000001818FB4E0-0x00000001818FB4F0
		public fsObjectAttribute(string versionString, params /* 0x00000001800B36B0-0x00000001800B36C0 */ Type[] previousModels); // 0x00000001818FB4F0-0x00000001818FB530
	}
}
