/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001800D5B00-0x00000001800D5B60
	[Description] // 0x00000001800D5B00-0x00000001800D5B60
	public class CheckProperty : ConditionTask, ISubParametersContainer // TypeDefIndex: 14157
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected ReflectedFunctionWrapper functionWrapper; // 0x68
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected BBParameter checkValue; // 0x70
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected CompareMethod comparison; // 0x78
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x0000000181252400-0x0000000181252420 
		public override Type agentType { get; } // 0x0000000181254F20-0x0000000181255030 
		protected override string info { get; } // 0x0000000181255030-0x0000000181255200 
	
		// Constructors
		public CheckProperty(); // 0x000000018124D940-0x000000018124D950
	
		// Methods
		new BBParameter[] ISubParametersContainer.GetSubParameters(); // 0x0000000181251910-0x0000000181251930
		public override void OnValidate(ITaskSystem ownerSystem); // 0x0000000181254E00-0x0000000181254F20
		protected override string OnInit(); // 0x0000000181254CF0-0x0000000181254E00
		protected override bool OnCheck(); // 0x00000001812549C0-0x0000000181254CF0
		private void SetMethod(MethodInfo method); // 0x0000000181251E90-0x0000000181251F10
	}
}
