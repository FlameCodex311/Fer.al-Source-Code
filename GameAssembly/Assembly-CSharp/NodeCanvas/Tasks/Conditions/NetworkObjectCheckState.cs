/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001800DFB00-0x00000001800DFB60
	[Description] // 0x00000001800DFB00-0x00000001800DFB60
	public class NetworkObjectCheckState : NetworkConditionTask<NetworkedObjectInfo> // TypeDefIndex: 14183
	{
		// Fields
		public CompareMethod checkType; // 0x68
		public BBParameter<int> checkValue; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000181259280-0x0000000181259630 
	
		// Constructors
		public NetworkObjectCheckState(); // 0x0000000181259230-0x0000000181259280
	
		// Methods
		protected override bool OnCheck(); // 0x0000000181259160-0x0000000181259230
	}
}
