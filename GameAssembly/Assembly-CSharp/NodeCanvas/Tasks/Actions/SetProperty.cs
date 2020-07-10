/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180107BB0-0x0000000180107C30
	[Description] // 0x0000000180107BB0-0x0000000180107C30
	[Name] // 0x0000000180107BB0-0x0000000180107C30
	public class SetProperty : ActionTask, ISubParametersContainer // TypeDefIndex: 14324
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected ReflectedActionWrapper functionWrapper; // 0x68
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x0000000181252400-0x0000000181252420 
		public override Type agentType { get; } // 0x0000000181262000-0x0000000181262110 
		protected override string info { get; } // 0x0000000181262110-0x00000001812622E0 
	
		// Constructors
		public SetProperty(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		new BBParameter[] ISubParametersContainer.GetSubParameters(); // 0x0000000181251910-0x0000000181251930
		public override void OnValidate(ITaskSystem ownerSystem); // 0x0000000181261ED0-0x0000000181261FC0
		protected override string OnInit(); // 0x0000000181261D90-0x0000000181261ED0
		protected override void OnExecute(); // 0x0000000181261D40-0x0000000181261D90
		private void SetMethod(MethodInfo method); // 0x0000000181261FC0-0x0000000181262000
	}
}
