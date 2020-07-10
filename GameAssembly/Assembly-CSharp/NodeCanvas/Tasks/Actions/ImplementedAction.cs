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
	[Category] // 0x0000000180107830-0x0000000180107890
	[Description] // 0x0000000180107830-0x0000000180107890
	public class ImplementedAction : ActionTask, ISubParametersContainer // TypeDefIndex: 14323
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected ReflectedFunctionWrapper functionWrapper; // 0x68
		private Status actionStatus; // 0x70
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x0000000181252400-0x0000000181252420 
		public override Type agentType { get; } // 0x000000018154C7D0-0x000000018154C8E0 
		protected override string info { get; } // 0x000000018154C8E0-0x000000018154CB30 
	
		// Constructors
		public ImplementedAction(); // 0x000000018154C7C0-0x000000018154C7D0
	
		// Methods
		new BBParameter[] ISubParametersContainer.GetSubParameters(); // 0x0000000181251910-0x0000000181251930
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018154C6D0-0x000000018154C7C0
		protected override string OnInit(); // 0x000000018154C4D0-0x000000018154C610
		protected override void OnUpdate(); // 0x000000018154C620-0x000000018154C6D0
		protected override void OnStop(); // 0x000000018154C610-0x000000018154C620
		private void SetMethod(MethodInfo method); // 0x000000018154AA70-0x000000018154AAB0
	}
}
