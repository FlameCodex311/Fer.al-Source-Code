/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Iss.Util;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Iss.Data
{
	public class Zone // TypeDefIndex: 16019
	{
		// Fields
		private SyncArrayList roomList; // 0x10
		private string name; // 0x18
	
		// Constructors
		public Zone(string name); // 0x0000000180F70AF0-0x0000000180F70B60
	
		// Methods
		public string GetName(); // 0x000000018038B150-0x000000018038B160
		public Room GetRoom(int id); // 0x0000000180F70A40-0x0000000180F70AF0
		public Room GetRoomByName(string name); // 0x0000000180F70820-0x0000000180F70A40
	}
}
