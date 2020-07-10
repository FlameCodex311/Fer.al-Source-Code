/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using ParadoxNotion.Serialization.FullSerializer;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ParadoxNotion.Serialization.FullSerializer.Internal
{
	public class fsMetaProperty // TypeDefIndex: 15334
	{
		// Fields
		private FieldInfo _fieldInfo; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Type <StorageType>k__BackingField; // 0x18
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private string <JsonName>k__BackingField; // 0x20
	
		// Properties
		public Type StorageType { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
		public string JsonName { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
		public string MemberName { get; } // 0x0000000180470100-0x0000000180470130 
	
		// Constructors
		internal fsMetaProperty(fsConfig config, FieldInfo field); // 0x0000000181393510-0x00000001813935F0
	
		// Methods
		public void Write(object context, object value); // 0x00000001813934F0-0x0000000181393510
		public object Read(object context); // 0x000000018094A280-0x000000018094A2B0
	}
}
