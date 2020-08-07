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
	[Category] // 0x000000018024B160-0x000000018024B1C0
	[Name] // 0x000000018024B160-0x000000018024B1C0
	public class GetToString : ActionTask // TypeDefIndex: 15319
	{
		// Fields
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<object> variable; // 0x68
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<string> toString; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180BB0DC0-0x0000000180BB0E00 
	
		// Constructors
		public GetToString(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BB0D00-0x0000000180BB0DC0
	}
}
