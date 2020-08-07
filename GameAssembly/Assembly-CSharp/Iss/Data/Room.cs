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
	public class Room // TypeDefIndex: 14403
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
		public Room(int id, string name, int maxUsers, int maxSpectators, bool isTemp, bool isGame, bool isPrivate, bool isLimbo); // 0x0000000180881280-0x00000001808812E0
		public Room(int id, string name, int maxUsers, int maxSpectators, bool isTemp, bool isGame, bool isPrivate, bool isLimbo, int userCount); // 0x00000001808812E0-0x0000000180881340
		public Room(int id, string name, int maxUsers, int maxSpectators, bool isTemp, bool isGame, bool isPrivate, bool isLimbo, int userCount, int specCount); // 0x00000001808811A0-0x0000000180881280
	
		// Methods
		public void AddUser(User u, int id); // 0x0000000180880B50-0x0000000180880C00
		public void RemoveUser(int id); // 0x0000000180881060-0x0000000180881190
		public Hashtable GetUserList(); // 0x00000001803743D0-0x00000001803743E0
		public void SetUserList(Hashtable userList); // 0x00000001803FEB60-0x00000001803FEB70
		public User GetUser(object userId); // 0x0000000180880C70-0x0000000180881020
		public void ClearUserList(); // 0x0000000180880C00-0x0000000180880C40
		public object GetVariable(string varName); // 0x0000000180881020-0x0000000180881050
		public Hashtable GetVariables(); // 0x00000001803C7290-0x00000001803C72A0
		public void SetVariables(Hashtable vars); // 0x00000001804CD6C0-0x00000001804CD6D0
		public void ClearVariables(); // 0x0000000180880C40-0x0000000180880C70
		public string GetName(); // 0x0000000180372430-0x0000000180372440
		public int GetId(); // 0x0000000180387590-0x0000000180387930
		public bool IsTemp(); // 0x00000001804C6790-0x00000001804C67A0
		public bool IsGame(); // 0x0000000180880010-0x0000000180880020
		public bool IsPrivate(); // 0x0000000180880020-0x0000000180880030
		public int GetUserCount(); // 0x000000018043C670-0x000000018043C680
		public int GetSpectatorCount(); // 0x00000001804AA650-0x00000001804AA660
		public int GetMaxUsers(); // 0x00000001803FB670-0x00000001803FB680
		public int GetMaxSpectators(); // 0x0000000180491DB0-0x0000000180491DC0
		public void SetMyPlayerIndex(int id); // 0x000000018041B180-0x000000018041B190
		public int GetMyPlayerIndex(); // 0x00000001804EF8F0-0x00000001804EF900
		public void SetIsLimbo(bool b); // 0x0000000180881190-0x00000001808811A0
		public bool IsLimbo(); // 0x0000000180881050-0x0000000180881060
		public void SetUserCount(int n); // 0x000000018041A370-0x000000018041A380
		public void SetSpectatorCount(int n); // 0x000000018041A3B0-0x000000018041A400
	}
}
