/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.BehaviourTrees
{
	[Category] // 0x000000018016E160-0x000000018016E220
	[Description] // 0x000000018016E160-0x000000018016E220
	[Icon] // 0x000000018016E160-0x000000018016E220
	[Name] // 0x000000018016E160-0x000000018016E220
	public class Remapper : BTDecorator // TypeDefIndex: 14057
	{
		// Fields
		public RemapStatus successRemap; // 0x78
		public RemapStatus failureRemap; // 0x7C
	
		// Nested types
		public enum RemapStatus // TypeDefIndex: 14058
		{
			Failure = 0,
			Success = 1
		}
	
		// Constructors
		public Remapper(); // 0x0000000181571580-0x0000000181571590
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001815714B0-0x0000000181571580
	}
}
