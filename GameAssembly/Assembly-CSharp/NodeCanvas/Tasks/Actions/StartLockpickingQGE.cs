/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using Prototype.QuickGames;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018012DC70-0x000000018012DCD0
	[Description] // 0x000000018012DC70-0x000000018012DCD0
	public class StartLockpickingQGE : StartGameQGE // TypeDefIndex: 14475
	{
		// Fields
		public BBParameter<QGEChestSettings> chestSettings; // 0x78
		public BBParameter<NetworkedObjectInfo> usePickNetworkObject; // 0x80
		public BBParameter<bool> autoDestroyGameController; // 0x88
		private LockPickingController _lockPickingGame; // 0x90
	
		// Constructors
		public StartLockpickingQGE(); // 0x0000000181264C90-0x0000000181264D00
	
		// Methods
		protected override void InitializeQuickGame(QuickGamesBase inQuickGame); // 0x0000000181264A70-0x0000000181264C90
	}
}
