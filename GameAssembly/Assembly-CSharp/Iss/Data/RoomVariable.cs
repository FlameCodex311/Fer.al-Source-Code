/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Iss.Data
{
	public class RoomVariable // TypeDefIndex: 14404
	{
		// Fields
		private string name; // 0x10
		private object value; // 0x18
		private bool isPrivate; // 0x20
		private bool isPersistent; // 0x21
	
		// Constructors
		public RoomVariable(string name, object value); // 0x0000000180880B10-0x0000000180880B50
		public RoomVariable(string name, object value, bool isPrivate); // 0x0000000180880A60-0x0000000180880AB0
		public RoomVariable(string name, object value, bool isPrivate, bool isPersistent); // 0x0000000180880AB0-0x0000000180880B10
	
		// Methods
		public string GetName(); // 0x0000000180372440-0x0000000180372450
		public object GetValue(); // 0x0000000180372430-0x0000000180372440
		public bool IsPrivate(); // 0x00000001803FA090-0x00000001803FA0A0
		public bool IsPersistent(); // 0x00000001804F2E80-0x00000001804F2E90
	}
}
