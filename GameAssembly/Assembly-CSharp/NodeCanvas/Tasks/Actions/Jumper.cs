/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180110100-0x00000001801101C0
	[Color] // 0x0000000180110100-0x00000001801101C0
	[Icon] // 0x0000000180110100-0x00000001801101C0
	[Name] // 0x0000000180110100-0x00000001801101C0
	public class Jumper : ActionTask // TypeDefIndex: 14365
	{
		// Fields
		private string _priorTag; // 0x68
		public BBParameter<string> tag; // 0x70
		private object _sourceNode; // 0x78
	
		// Properties
		private Node sourceNode { get; set; } // 0x000000018154E0A0-0x000000018154E210 0x00000001803D8EF0-0x00000001803D8F00
		protected override string info { get; } // 0x000000018154DFD0-0x000000018154E0A0 
	
		// Constructors
		public Jumper(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x000000018154DF50-0x000000018154DFD0
	}
}
