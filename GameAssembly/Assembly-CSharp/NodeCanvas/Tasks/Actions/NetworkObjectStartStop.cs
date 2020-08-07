/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180286C50-0x0000000180286CB0
	[Description] // 0x0000000180286C50-0x0000000180286CB0
	public class NetworkObjectStartStop : NetworkActionTask<NetworkedObjectInfo> // TypeDefIndex: 15505
	{
		// Fields
		public EAction action; // 0x68
	
		// Properties
		protected override string info { get; } // 0x0000000180BBB720-0x0000000180BBB9D0 
	
		// Nested types
		public enum EAction // TypeDefIndex: 15506
		{
			start = 0,
			stop = 1
		}
	
		// Constructors
		public NetworkObjectStartStop(); // 0x0000000180BBB6E0-0x0000000180BBB720
	}
}
