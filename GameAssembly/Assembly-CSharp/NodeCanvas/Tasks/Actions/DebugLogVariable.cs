/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180271920-0x00000001802719A0
	[Description] // 0x0000000180271920-0x00000001802719A0
	[Obsolete] // 0x0000000180271920-0x00000001802719A0
	public class DebugLogVariable : ActionTask // TypeDefIndex: 15433
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<object> log; // 0x68
		public BBParameter<string> prefix; // 0x70
		public float secondsToRun; // 0x78
		public CompactStatus finishStatus; // 0x7C
	
		// Properties
		protected override string info { get; } // 0x0000000180CC25D0-0x0000000180CC27D0 
	
		// Constructors
		public DebugLogVariable(); // 0x0000000180CC25B0-0x0000000180CC25D0
	
		// Methods
		protected override void OnExecute(); // 0x00000001803774A0-0x00000001803774B0
		protected override void OnUpdate(); // 0x0000000180CC2570-0x0000000180CC25B0
	}
}
