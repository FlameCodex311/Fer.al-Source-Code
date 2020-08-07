/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using World_Challenge.World_Puzzle;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001801D0590-0x00000001801D05F0
	[Description] // 0x00000001801D0590-0x00000001801D05F0
	public class PlayRingStatuePuzzleFX : ActionTask // TypeDefIndex: 15584
	{
		// Fields
		public BBParameter<NetworkedObjectInfo> fxIndex; // 0x68
		public BBParameter<RingStatuePuzzle> ringStatuePuzzle; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018079E650-0x000000018079E680 
	
		// Constructors
		public PlayRingStatuePuzzleFX(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x000000018079E5B0-0x000000018079E650
	}
}
