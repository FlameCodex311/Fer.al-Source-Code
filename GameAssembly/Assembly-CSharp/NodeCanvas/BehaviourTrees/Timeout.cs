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
	[Category] // 0x000000018021CF50-0x000000018021CFF0
	[Description] // 0x000000018021CF50-0x000000018021CFF0
	[Icon] // 0x000000018021CF50-0x000000018021CFF0
	public class Timeout : BTDecorator // TypeDefIndex: 15182
	{
		// Fields
		public BBParameter<float> timeout; // 0x88
	
		// Constructors
		public Timeout(); // 0x00000001808B5F30-0x00000001808B5F80
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001808B5DD0-0x00000001808B5F30
	}
}
