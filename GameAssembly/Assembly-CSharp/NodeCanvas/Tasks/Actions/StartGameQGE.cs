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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001801CF9D0-0x00000001801CFA30
	[Description] // 0x00000001801CF9D0-0x00000001801CFA30
	public class StartGameQGE : ActionTask<Transform> // TypeDefIndex: 15580
	{
		// Fields
		public string quickGameBundleId; // 0x68
		protected QuickGamesBase _quickGame; // 0x70
	
		// Properties
		protected override string info { get; } // 0x00000001807A8F60-0x00000001807A9030 
	
		// Constructors
		public StartGameQGE(); // 0x00000001807A8F20-0x00000001807A8F60
	
		// Methods
		protected override void OnExecute(); // 0x00000001807A8A00-0x00000001807A8C60
		protected virtual void InitializeQuickGame(QuickGamesBase inQuickGame); // 0x00000001807A87E0-0x00000001807A8A00
		public void QuickGameReturn(QuickGamesBase.EQuickGamesResults qgeResults, QuickGamesBase.EQuickGameRewardTier qgeRewardTier, Dictionary<string, object> customResults); // 0x00000001807A8C60-0x00000001807A8E50
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <OnExecute>b__4_0(GameObject go); // 0x00000001807A8E50-0x00000001807A8F20
	}
}
