/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Iss.Data
{
	public class User // TypeDefIndex: 14405
	{
		// Fields
		private int id; // 0x10
		private string name; // 0x18
		private Hashtable variables; // 0x20
		private bool isSpec; // 0x28
		private bool isMod; // 0x29
		private int pId; // 0x2C
	
		// Constructors
		public User(int id, string name); // 0x0000000180884DA0-0x0000000180884E20
	
		// Methods
		public int GetId(); // 0x0000000180387590-0x0000000180387930
		public string GetName(); // 0x0000000180372430-0x0000000180372440
		public object GetVariable(string varName); // 0x0000000180884AF0-0x0000000180884B20
		public Hashtable GetVariables(); // 0x0000000180374AF0-0x0000000180374B00
		public void SetVariables(Hashtable o); // 0x0000000180884B30-0x0000000180884DA0
		internal void ClearVariables(); // 0x0000000180884AC0-0x0000000180884AF0
		public void SetIsSpectator(bool b); // 0x00000001804D9980-0x00000001804D9990
		public bool IsSpectator(); // 0x00000001804C6790-0x00000001804C67A0
		public void SetModerator(bool b); // 0x0000000180884B20-0x0000000180884B30
		public bool IsModerator(); // 0x0000000180880010-0x0000000180880020
		public int GetPlayerId(); // 0x000000018043C670-0x000000018043C680
		public void SetPlayerId(int pid); // 0x000000018041A370-0x000000018041A380
	}
}
