/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001800D3EF0-0x00000001800D3F70
	[Description] // 0x00000001800D3EF0-0x00000001800D3F70
	[Name] // 0x00000001800D3EF0-0x00000001800D3F70
	public class CheckFunction_Multiplatform : ConditionTask // TypeDefIndex: 14154
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected SerializedMethodInfo method; // 0x68
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected List<BBObjectParameter> parameters; // 0x70
		[BlackboardOnly] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		protected BBObjectParameter checkValue; // 0x78
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected CompareMethod comparison; // 0x80
		private object[] args; // 0x88
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x0000000181251900-0x0000000181251910 
		public override Type agentType { get; } // 0x0000000181251440-0x0000000181251540 
		protected override string info { get; } // 0x0000000181251540-0x0000000181251900 
	
		// Constructors
		public CheckFunction_Multiplatform(); // 0x00000001812513E0-0x0000000181251440
	
		// Methods
		public override void OnValidate(ITaskSystem ownerSystem); // 0x00000001812510C0-0x0000000181251190
		protected override string OnInit(); // 0x0000000181251030-0x00000001812510C0
		protected override bool OnCheck(); // 0x0000000181250BA0-0x0000000181251030
		private void SetMethod(MethodInfo method); // 0x0000000181251190-0x00000001812513E0
	}
}
