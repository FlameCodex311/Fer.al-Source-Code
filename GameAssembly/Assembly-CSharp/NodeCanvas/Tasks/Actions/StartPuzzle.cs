/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using World_Challenge;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001801D0C70-0x00000001801D0CD0
	[Description] // 0x00000001801D0C70-0x00000001801D0CD0
	public class StartPuzzle : ActionTask // TypeDefIndex: 15587
	{
		// Fields
		public BBParameter<bool> success; // 0x68
		public BBParameter<bool> endPan; // 0x70
		public BBParameter<WorldPuzzle> worldPuzzle; // 0x78
		public BBParameter<bool> waitToContinue; // 0x80
	
		// Properties
		protected override string info { get; } // 0x00000001807A9700-0x00000001807A9730 
	
		// Constructors
		public StartPuzzle(); // 0x00000001807A96B0-0x00000001807A9700
	
		// Methods
		protected override void OnExecute(); // 0x00000001807A9500-0x00000001807A96B0
		internal void GameOver(bool completed); // 0x00000001807A9470-0x00000001807A9500
	}
}
