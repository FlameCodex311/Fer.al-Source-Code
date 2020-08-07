/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Iss.Util;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Iss.Data
{
	public class Zone // TypeDefIndex: 14406
	{
		// Fields
		private SyncArrayList roomList; // 0x10
		private string name; // 0x18
	
		// Constructors
		public Zone(string name); // 0x0000000180885F10-0x0000000180885FC0
	
		// Methods
		public string GetName(); // 0x0000000180372430-0x0000000180372440
		public Room GetRoom(int id); // 0x0000000180885E60-0x0000000180885F10
		public Room GetRoomByName(string name); // 0x0000000180885C50-0x0000000180885E60
	}
}
