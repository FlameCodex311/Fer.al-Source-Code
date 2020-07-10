/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018011AAE0-0x000000018011AB40
	[Description] // 0x000000018011AAE0-0x000000018011AB40
	public class NetworkObjectStartStop : NetworkActionTask<NetworkedObjectInfo> // TypeDefIndex: 14400
	{
		// Fields
		public EAction action; // 0x68
	
		// Properties
		protected override string info { get; } // 0x0000000181555220-0x00000001815554F0 
	
		// Nested types
		public enum EAction // TypeDefIndex: 14401
		{
			start = 0,
			stop = 1
		}
	
		// Constructors
		public NetworkObjectStartStop(); // 0x00000001815551E0-0x0000000181555220
	}
}
