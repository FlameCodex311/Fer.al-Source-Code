/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Server
{
	public class MessageRouteAttribute : Attribute // TypeDefIndex: 16036
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private string <Cmd>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private QueueMessageMode <QueueMode>k__BackingField; // 0x18
	
		// Properties
		public string Cmd { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
		public QueueMessageMode QueueMode { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180367710-0x0000000180367720 0x000000018036B1F0-0x000000018036B200
	
		// Constructors
		public MessageRouteAttribute(XtCmd cmd, QueueMessageMode queueMode = QueueMessageMode.Never /* Metadata: 0x007851D3 */); // 0x0000000180EB96E0-0x0000000180EB9720
		public MessageRouteAttribute(string cmd, QueueMessageMode queueMode = QueueMessageMode.Never /* Metadata: 0x007851D7 */); // 0x0000000180B57450-0x0000000180B57490
	}
}
