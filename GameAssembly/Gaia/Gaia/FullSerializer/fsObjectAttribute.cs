/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia.FullSerializer
{
	[AttributeUsage] // 0x0000000180220D30-0x0000000180220D50
	public sealed class fsObjectAttribute : Attribute // TypeDefIndex: 9300
	{
		// Fields
		public Type[] PreviousModels; // 0x10
		public string VersionString; // 0x18
		public fsMemberSerialization MemberSerialization; // 0x20
		public Type Converter; // 0x28
		public Type Processor; // 0x30
	
		// Constructors
		public fsObjectAttribute(); // 0x0000000180E4EC90-0x0000000180E4ECA0
		public fsObjectAttribute(string versionString, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ Type[] previousModels); // 0x0000000180E4ECA0-0x0000000180E4ECE0
	}
}
