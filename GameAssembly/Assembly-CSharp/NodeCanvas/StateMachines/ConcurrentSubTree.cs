/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.BehaviourTrees;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.StateMachines
{
	[Category] // 0x00000001801F2DA0-0x00000001801F2E50
	[Color] // 0x00000001801F2DA0-0x00000001801F2E50
	[Description] // 0x00000001801F2DA0-0x00000001801F2E50
	[Name] // 0x00000001801F2DA0-0x00000001801F2E50
	public class ConcurrentSubTree : FSMNodeNested<BehaviourTree>, IUpdatable // TypeDefIndex: 15086
	{
		// Fields
		[ExposeField] // 0x00000001801F3280-0x00000001801F32D0
		[Name] // 0x00000001801F3280-0x00000001801F32D0
		[SerializeField] // 0x00000001801F3280-0x00000001801F32D0
		protected BBParameter<BehaviourTree> _subTree; // 0xA0
	
		// Properties
		public override string name { get; } // 0x00000001807C41C0-0x00000001807C41F0 
		public override int maxInConnections { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		public override int maxOutConnections { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		public override bool allowAsPrime { get; } // 0x0000000180380950-0x0000000180380960 
		public override BehaviourTree subGraph { get; set; } // 0x0000000180CC0960-0x0000000180CC09B0 0x0000000180CC09B0-0x0000000180CC0A10
		public override BBParameter subGraphParameter { get; } // 0x00000001803D6D90-0x00000001803D6DA0 
	
		// Constructors
		public ConcurrentSubTree(); // 0x0000000180CC0920-0x0000000180CC0960
	
		// Methods
		public override void OnGraphStarted(); // 0x0000000180CC0830-0x0000000180CC0920
		void IUpdatable.Update(); // 0x0000000180CC05F0-0x0000000180CC0600
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <OnGraphStarted>b__14_0(bool result); // 0x0000000180CC06F0-0x0000000180CC0740
	}
}
