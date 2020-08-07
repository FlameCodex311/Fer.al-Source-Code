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
	[Category] // 0x0000000180279590-0x00000001802795C0
	public class OpenItemNotification : ActionTask // TypeDefIndex: 15511
	{
		// Fields
		public string imageDefId; // 0x68
		public string itemNameDefId; // 0x70
		public int quantity; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000180BBC640-0x0000000180BBC670 
	
		// Constructors
		public OpenItemNotification(); // 0x0000000180BBC5F0-0x0000000180BBC640
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BBC4A0-0x0000000180BBC5F0
	}
}
