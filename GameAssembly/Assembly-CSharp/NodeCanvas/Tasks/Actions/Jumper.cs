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
	[Category] // 0x000000018027D180-0x000000018027D240
	[Color] // 0x000000018027D180-0x000000018027D240
	[Icon] // 0x000000018027D180-0x000000018027D240
	[Name] // 0x000000018027D180-0x000000018027D240
	public class Jumper : ActionTask // TypeDefIndex: 15468
	{
		// Fields
		private string _priorTag; // 0x68
		public BBParameter<string> tag; // 0x70
		private object _sourceNode; // 0x78
	
		// Properties
		private Node sourceNode { get; set; } // 0x0000000180BB3EA0-0x0000000180BB3FF0 0x00000001804B47D0-0x00000001804B47E0
		protected override string info { get; } // 0x0000000180BB3DD0-0x0000000180BB3EA0 
	
		// Constructors
		public Jumper(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BB3D40-0x0000000180BB3DD0
	}
}
