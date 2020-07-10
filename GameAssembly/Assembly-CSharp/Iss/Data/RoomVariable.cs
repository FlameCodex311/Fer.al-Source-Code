/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Iss.Data
{
	public class RoomVariable // TypeDefIndex: 16017
	{
		// Fields
		private string name; // 0x10
		private object value; // 0x18
		private bool isPrivate; // 0x20
		private bool isPersistent; // 0x21
	
		// Constructors
		public RoomVariable(string name, object value); // 0x0000000180F6BCA0-0x0000000180F6BCE0
		public RoomVariable(string name, object value, bool isPrivate); // 0x0000000180F6BBF0-0x0000000180F6BC40
		public RoomVariable(string name, object value, bool isPrivate, bool isPersistent); // 0x0000000180F6BC40-0x0000000180F6BCA0
	
		// Methods
		public string GetName(); // 0x000000018036AC80-0x000000018036AC90
		public object GetValue(); // 0x000000018038B150-0x000000018038B160
		public bool IsPrivate(); // 0x00000001803C19E0-0x00000001803C19F0
		public bool IsPersistent(); // 0x00000001803C19F0-0x00000001803C1A00
	}
}
