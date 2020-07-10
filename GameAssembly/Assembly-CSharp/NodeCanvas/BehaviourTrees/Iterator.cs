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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.BehaviourTrees
{
	[Category] // 0x000000018016AFF0-0x000000018016B0B0
	[Description] // 0x000000018016AFF0-0x000000018016B0B0
	[Icon] // 0x000000018016AFF0-0x000000018016B0B0
	[Name] // 0x000000018016AFF0-0x000000018016B0B0
	public class Iterator : BTDecorator // TypeDefIndex: 14051
	{
		// Fields
		[BlackboardOnly] // 0x000000018016B470-0x000000018016B4C0
		[RequiredField] // 0x000000018016B470-0x000000018016B4C0
		[Tooltip] // 0x000000018016B470-0x000000018016B4C0
		public BBParameter<IList> targetList; // 0x78
		[BlackboardOnly] // 0x000000018016B640-0x000000018016B6B0
		[Name] // 0x000000018016B640-0x000000018016B6B0
		[Tooltip] // 0x000000018016B640-0x000000018016B6B0
		public BBObjectParameter current; // 0x80
		[BlackboardOnly] // 0x000000018016B8A0-0x000000018016B910
		[Name] // 0x000000018016B8A0-0x000000018016B910
		[Tooltip] // 0x000000018016B8A0-0x000000018016B910
		public BBParameter<int> storeIndex; // 0x88
		[Tooltip] // 0x000000018016BC70-0x000000018016BCA0
		public BBParameter<int> maxIteration; // 0x90
		[Tooltip] // 0x000000018016BE80-0x000000018016BEB0
		public TerminationConditions terminationCondition; // 0x98
		[Tooltip] // 0x000000018016C120-0x000000018016C150
		public bool resetIndex; // 0x9C
		private int currentIndex; // 0xA0
	
		// Properties
		private IList list { get; } // 0x0000000181568B40-0x0000000181568B90 
	
		// Nested types
		public enum TerminationConditions // TypeDefIndex: 14052
		{
			None = 0,
			FirstSuccess = 1,
			FirstFailure = 2
		}
	
		// Constructors
		public Iterator(); // 0x0000000181568AE0-0x0000000181568B40
	
		// Methods
		protected override Status OnExecute(Component agent, IBlackboard blackboard); // 0x00000001815686D0-0x0000000181568AC0
		protected override void OnReset(); // 0x0000000181568AC0-0x0000000181568AE0
	}
}
