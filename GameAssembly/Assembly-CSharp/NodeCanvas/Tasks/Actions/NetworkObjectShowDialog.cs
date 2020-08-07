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
	[Category] // 0x0000000180286A20-0x0000000180286A80
	[Description] // 0x0000000180286A20-0x0000000180286A80
	public class NetworkObjectShowDialog : NetworkActionTask // TypeDefIndex: 15503
	{
		// Fields
		public EDialogType dialogType; // 0x68
		public BBParameter<int> dialogIndex; // 0x70
		private NetworkedObjectInfo noi; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000180BBB200-0x0000000180BBB6E0 
	
		// Nested types
		public enum EDialogType // TypeDefIndex: 15504
		{
			Ask = 0,
			AskAll = 1
		}
	
		// Constructors
		public NetworkObjectShowDialog(); // 0x0000000180BBB1B0-0x0000000180BBB200
	}
}
