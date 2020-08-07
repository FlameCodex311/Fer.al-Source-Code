/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018027D690-0x000000018027D6F0
	[Description] // 0x000000018027D690-0x000000018027D6F0
	public class Lobby_LC : ActionTask // TypeDefIndex: 15469
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public LobbyManager.ELobbyType lobbyType; // 0x68
		[Tooltip] // 0x000000018027DB10-0x000000018027DB40
		public string associatedDefId; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180BB4290-0x0000000180BB42C0 
	
		// Constructors
		public Lobby_LC(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BB41F0-0x0000000180BB4290
	}
}
