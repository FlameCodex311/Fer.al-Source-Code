/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.BehaviourTrees
{
	[Category] // 0x000000018016EB40-0x000000018016EC00
	[Description] // 0x000000018016EB40-0x000000018016EC00
	[Icon] // 0x000000018016EB40-0x000000018016EC00
	[Name] // 0x000000018016EB40-0x000000018016EC00
	public class Setter : BTDecorator // TypeDefIndex: 14062
	{
		// Fields
		public BBParameter<GameObject> newAgent; // 0x78
	
		// Constructors
		public Setter(); // 0x000000018155E370-0x000000018155E380
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001815720C0-0x00000001815721D0
	}
}
