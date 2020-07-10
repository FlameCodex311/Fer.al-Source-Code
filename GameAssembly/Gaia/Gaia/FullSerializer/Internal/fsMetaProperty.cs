/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia.FullSerializer.Internal
{
	public class fsMetaProperty // TypeDefIndex: 9165
	{
		// Fields
		private MemberInfo _memberInfo; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Type <StorageType>k__BackingField; // 0x18
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <CanRead>k__BackingField; // 0x20
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <CanWrite>k__BackingField; // 0x21
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private string <JsonName>k__BackingField; // 0x28
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private string <MemberName>k__BackingField; // 0x30
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <IsPublic>k__BackingField; // 0x38
	
		// Properties
		public Type StorageType { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
		public bool CanRead { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803C19E0-0x00000001803C19F0 0x00000001804231D0-0x00000001804231E0
		public bool CanWrite { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803C19F0-0x00000001803C1A00 0x00000001804D5390-0x00000001804D53A0
		public string JsonName { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
		public string MemberName { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180397720-0x0000000180397730 0x00000001803A2800-0x00000001803A2810
		public bool IsPublic { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804AEAD0-0x00000001804AEAE0 0x000000018044E330-0x000000018044E340
	
		// Constructors
		internal fsMetaProperty(FieldInfo field); // 0x00000001818F9460-0x00000001818F9560
		internal fsMetaProperty(PropertyInfo property); // 0x00000001818F9560-0x00000001818F9710
	
		// Methods
		public void Write(object context, object value); // 0x00000001818F9270-0x00000001818F9460
		public object Read(object context); // 0x00000001818F9050-0x00000001818F9270
		private static string GetJsonName(MemberInfo member); // 0x00000001818F8FA0-0x00000001818F9050
	}
}
