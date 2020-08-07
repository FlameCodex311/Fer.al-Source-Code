/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using Prototype.QuickGames;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001801CFF70-0x00000001801CFFD0
	[Description] // 0x00000001801CFF70-0x00000001801CFFD0
	public class StartLockpickingQGE : StartGameQGE // TypeDefIndex: 15581
	{
		// Fields
		public BBParameter<QGEChestSettings> chestSettings; // 0x78
		public BBParameter<NetworkedObjectInfo> usePickNetworkObject; // 0x80
		public BBParameter<bool> autoDestroyGameController; // 0x88
		private LockPickingController _lockPickingGame; // 0x90
	
		// Constructors
		public StartLockpickingQGE(); // 0x00000001807A9400-0x00000001807A9470
	
		// Methods
		protected override void InitializeQuickGame(QuickGamesBase inQuickGame); // 0x00000001807A91D0-0x00000001807A9400
	}
}
