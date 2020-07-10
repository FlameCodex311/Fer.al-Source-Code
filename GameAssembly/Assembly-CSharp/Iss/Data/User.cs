/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Iss.Data
{
	public class User // TypeDefIndex: 16018
	{
		// Fields
		private int id; // 0x10
		private string name; // 0x18
		private Hashtable variables; // 0x20
		private bool isSpec; // 0x28
		private bool isMod; // 0x29
		private int pId; // 0x2C
	
		// Constructors
		public User(int id, string name); // 0x0000000180F707A0-0x0000000180F70820
	
		// Methods
		public int GetId(); // 0x000000018036CFF0-0x000000018036D000
		public string GetName(); // 0x000000018038B150-0x000000018038B160
		public object GetVariable(string varName); // 0x0000000180F70500-0x0000000180F70530
		public Hashtable GetVariables(); // 0x000000018036AC70-0x000000018036AC80
		public void SetVariables(Hashtable o); // 0x0000000180F70530-0x0000000180F707A0
		internal void ClearVariables(); // 0x00000001804AE8E0-0x00000001804AE910
		public void SetIsSpectator(bool b); // 0x00000001803A2840-0x00000001803A2850
		public bool IsSpectator(); // 0x00000001803A2790-0x00000001803A27A0
		public void SetModerator(bool b); // 0x00000001809C86F0-0x00000001809C8700
		public bool IsModerator(); // 0x00000001805C9DA0-0x00000001805C9DB0
		public int GetPlayerId(); // 0x000000018038E0D0-0x000000018038E0E0
		public void SetPlayerId(int pid); // 0x000000018036B760-0x000000018036B770
	}
}
