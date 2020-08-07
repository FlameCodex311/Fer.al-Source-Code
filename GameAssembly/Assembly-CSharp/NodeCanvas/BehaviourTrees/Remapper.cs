/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.BehaviourTrees
{
	[Category] // 0x000000018021BCE0-0x000000018021BDA0
	[Description] // 0x000000018021BCE0-0x000000018021BDA0
	[Icon] // 0x000000018021BCE0-0x000000018021BDA0
	[Name] // 0x000000018021BCE0-0x000000018021BDA0
	public class Remapper : BTDecorator // TypeDefIndex: 15176
	{
		// Fields
		public RemapStatus successRemap; // 0x88
		public RemapStatus failureRemap; // 0x8C
	
		// Nested types
		public enum RemapStatus // TypeDefIndex: 15177
		{
			Failure = 0,
			Success = 1
		}
	
		// Constructors
		public Remapper(); // 0x00000001808B3DC0-0x00000001808B3DE0
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001808B3D00-0x00000001808B3DC0
	}
}
