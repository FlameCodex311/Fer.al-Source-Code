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

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001802444A0-0x0000000180244500
	[Description] // 0x00000001802444A0-0x0000000180244500
	public class NetworkObjectCheckState : NetworkConditionTask<NetworkedObjectInfo> // TypeDefIndex: 15286
	{
		// Fields
		public CompareMethod checkType; // 0x68
		public BBParameter<int> checkValue; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000180801890-0x0000000180801C10 
	
		// Constructors
		public NetworkObjectCheckState(); // 0x0000000180801840-0x0000000180801890
	
		// Methods
		protected override bool OnCheck(); // 0x0000000180801770-0x0000000180801840
	}
}
