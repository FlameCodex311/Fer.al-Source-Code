/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018024EDD0-0x000000018024EE30
	[Description] // 0x000000018024EDD0-0x000000018024EE30
	public class LoadBlackboard : ActionTask<Blackboard> // TypeDefIndex: 15332
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<string> saveKey; // 0x68
	
		// Properties
		protected override string info { get; } // 0x0000000180BB40C0-0x0000000180BB4120 
	
		// Constructors
		public LoadBlackboard(); // 0x0000000180BB4080-0x0000000180BB40C0
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BB3FF0-0x0000000180BB4080
	}
}
