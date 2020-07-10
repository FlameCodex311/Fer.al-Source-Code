/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using World_Challenge;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018012EC70-0x000000018012ECD0
	[Description] // 0x000000018012EC70-0x000000018012ECD0
	public class StartPuzzle : ActionTask // TypeDefIndex: 14481
	{
		// Fields
		public BBParameter<bool> success; // 0x68
		public BBParameter<bool> endPan; // 0x70
		public BBParameter<WorldPuzzle> worldPuzzle; // 0x78
		public BBParameter<bool> waitToContinue; // 0x80
	
		// Properties
		protected override string info { get; } // 0x0000000181264F90-0x0000000181264FC0 
	
		// Constructors
		public StartPuzzle(); // 0x0000000181264F40-0x0000000181264F90
	
		// Methods
		protected override void OnExecute(); // 0x0000000181264D90-0x0000000181264F40
		internal void GameOver(bool completed); // 0x0000000181264D00-0x0000000181264D90
	}
}
