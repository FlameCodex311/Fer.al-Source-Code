/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.BehaviourTrees
{
	[Category] // 0x0000000180217DA0-0x0000000180217E60
	[Description] // 0x0000000180217DA0-0x0000000180217E60
	[Icon] // 0x0000000180217DA0-0x0000000180217E60
	[Name] // 0x0000000180217DA0-0x0000000180217E60
	public class Iterator : BTDecorator // TypeDefIndex: 15169
	{
		// Fields
		[BlackboardOnly] // 0x0000000180218260-0x00000001802182B0
		[RequiredField] // 0x0000000180218260-0x00000001802182B0
		[Tooltip] // 0x0000000180218260-0x00000001802182B0
		public BBParameter<IList> targetList; // 0x88
		[BlackboardOnly] // 0x0000000180218640-0x00000001802186B0
		[Name] // 0x0000000180218640-0x00000001802186B0
		[Tooltip] // 0x0000000180218640-0x00000001802186B0
		public BBObjectParameter current; // 0x90
		[BlackboardOnly] // 0x0000000180218950-0x00000001802189C0
		[Name] // 0x0000000180218950-0x00000001802189C0
		[Tooltip] // 0x0000000180218950-0x00000001802189C0
		public BBParameter<int> storeIndex; // 0x98
		[Tooltip] // 0x0000000180218E10-0x0000000180218E40
		public BBParameter<int> maxIteration; // 0xA0
		[Tooltip] // 0x0000000180218FB0-0x0000000180218FE0
		public TerminationConditions terminationCondition; // 0xA8
		[Tooltip] // 0x00000001802190A0-0x00000001802190D0
		public bool resetIndex; // 0xAC
		private int currentIndex; // 0xB0
	
		// Properties
		private IList list { get; } // 0x00000001808B01E0-0x00000001808B0230 
	
		// Nested types
		public enum TerminationConditions // TypeDefIndex: 15170
		{
			None = 0,
			FirstSuccess = 1,
			FirstFailure = 2
		}
	
		// Constructors
		public Iterator(); // 0x00000001808B0180-0x00000001808B01E0
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001808AFD40-0x00000001808B0160
		protected override void OnReset(); // 0x00000001808B0160-0x00000001808B0180
	}
}
