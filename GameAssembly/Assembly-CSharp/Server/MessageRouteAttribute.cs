/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Server
{
	public class MessageRouteAttribute : Attribute // TypeDefIndex: 14423
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string <Cmd>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private QueueMessageMode <QueueMode>k__BackingField; // 0x18
	
		// Properties
		public string Cmd { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
		public QueueMessageMode QueueMode { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803F46B0-0x00000001803F46C0 0x00000001803F46C0-0x00000001803F46D0
	
		// Constructors
		public MessageRouteAttribute(XtCmd cmd, QueueMessageMode queueMode = QueueMessageMode.Never /* Metadata: 0x007BA8FD */); // 0x00000001803F4630-0x00000001803F4670
		public MessageRouteAttribute(string cmd, QueueMessageMode queueMode = QueueMessageMode.Never /* Metadata: 0x007BA901 */); // 0x00000001803F4670-0x00000001803F46B0
	}
}
