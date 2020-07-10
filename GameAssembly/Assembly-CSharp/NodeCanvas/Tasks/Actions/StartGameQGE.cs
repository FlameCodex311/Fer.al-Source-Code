/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using Prototype.QuickGames;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018012D890-0x000000018012D8F0
	[Description] // 0x000000018012D890-0x000000018012D8F0
	public class StartGameQGE : ActionTask<Transform> // TypeDefIndex: 14474
	{
		// Fields
		public string quickGameBundleId; // 0x68
		protected QuickGamesBase _quickGame; // 0x70
	
		// Properties
		protected override string info { get; } // 0x00000001812647F0-0x00000001812648C0 
	
		// Constructors
		public StartGameQGE(); // 0x00000001812647B0-0x00000001812647F0
	
		// Methods
		protected override void OnExecute(); // 0x00000001812641F0-0x0000000181264450
		protected virtual void InitializeQuickGame(QuickGamesBase inQuickGame); // 0x0000000181263FC0-0x00000001812641F0
		public void QuickGameReturn(QuickGamesBase.EQuickGamesResults qgeResults, QuickGamesBase.EQuickGameRewardTier qgeRewardTier, Dictionary<string, object> customResults); // 0x0000000181264450-0x00000001812646E0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <OnExecute>b__4_0(GameObject go); // 0x00000001812646E0-0x00000001812647B0
	}
}
