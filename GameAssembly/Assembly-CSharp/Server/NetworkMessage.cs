/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Server
{
	public abstract class NetworkMessage : IMessage // TypeDefIndex: 16031
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private readonly string <Cmd>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private string <EventId>k__BackingField; // 0x18
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private MessageRouteInfo <RouteInfo>k__BackingField; // 0x20
	
		// Properties
		public virtual string Cmd { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036AC80-0x000000018036AC90 
		public string EventId { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
		internal MessageRouteInfo RouteInfo { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
	
		// Constructors
		protected NetworkMessage(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public virtual void ReturnToPool(); // 0x00000001803581E0-0x00000001803581F0
	}
}
