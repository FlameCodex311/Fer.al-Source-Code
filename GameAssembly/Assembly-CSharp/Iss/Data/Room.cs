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
	public class Room // TypeDefIndex: 16016
	{
		// Fields
		private int id; // 0x10
		private string name; // 0x18
		private int maxUsers; // 0x20
		private int maxSpectators; // 0x24
		private bool temp; // 0x28
		private bool game; // 0x29
		private bool priv; // 0x2A
		private bool limbo; // 0x2B
		private int userCount; // 0x2C
		private int specCount; // 0x30
		private int myPlayerIndex; // 0x34
		private Hashtable userList; // 0x38
		private Hashtable variables; // 0x40
	
		// Constructors
		public Room(int id, string name, int maxUsers, int maxSpectators, bool isTemp, bool isGame, bool isPrivate, bool isLimbo); // 0x0000000180F6C410-0x0000000180F6C470
		public Room(int id, string name, int maxUsers, int maxSpectators, bool isTemp, bool isGame, bool isPrivate, bool isLimbo, int userCount); // 0x0000000180F6C470-0x0000000180F6C4D0
		public Room(int id, string name, int maxUsers, int maxSpectators, bool isTemp, bool isGame, bool isPrivate, bool isLimbo, int userCount, int specCount); // 0x0000000180F6C330-0x0000000180F6C410
	
		// Methods
		public void AddUser(User u, int id); // 0x0000000180F6BCE0-0x0000000180F6BD90
		public void RemoveUser(int id); // 0x0000000180F6C1E0-0x0000000180F6C320
		public Hashtable GetUserList(); // 0x0000000180369BB0-0x0000000180369BC0
		public void SetUserList(Hashtable userList); // 0x00000001803A2820-0x00000001803A2830
		public User GetUser(object userId); // 0x0000000180F6BE00-0x0000000180F6C1B0
		public void ClearUserList(); // 0x0000000180F6BD90-0x0000000180F6BDD0
		public object GetVariable(string varName); // 0x0000000180F6C1B0-0x0000000180F6C1E0
		public Hashtable GetVariables(); // 0x0000000180369B30-0x0000000180369B40
		public void SetVariables(Hashtable vars); // 0x00000001803A2810-0x00000001803A2820
		public void ClearVariables(); // 0x0000000180F6BDD0-0x0000000180F6BE00
		public string GetName(); // 0x000000018038B150-0x000000018038B160
		public int GetId(); // 0x000000018036CFF0-0x000000018036D000
		public bool IsTemp(); // 0x00000001803A2790-0x00000001803A27A0
		public bool IsGame(); // 0x00000001805C9DA0-0x00000001805C9DB0
		public bool IsPrivate(); // 0x00000001809C8430-0x00000001809C8440
		public int GetUserCount(); // 0x000000018038E0D0-0x000000018038E0E0
		public int GetSpectatorCount(); // 0x000000018043DDC0-0x000000018043DDD0
		public int GetMaxUsers(); // 0x00000001803C2700-0x00000001803C2710
		public int GetMaxSpectators(); // 0x00000001803C26F0-0x00000001803C2700
		public void SetMyPlayerIndex(int id); // 0x000000018036C610-0x000000018036C620
		public int GetMyPlayerIndex(); // 0x000000018043E170-0x000000018043E180
		public void SetIsLimbo(bool b); // 0x0000000180F6C320-0x0000000180F6C330
		public bool IsLimbo(); // 0x00000001809C8440-0x00000001809C8450
		public void SetUserCount(int n); // 0x000000018036B760-0x000000018036B770
		public void SetSpectatorCount(int n); // 0x000000018036B7A0-0x000000018036B7F0
	}
}
