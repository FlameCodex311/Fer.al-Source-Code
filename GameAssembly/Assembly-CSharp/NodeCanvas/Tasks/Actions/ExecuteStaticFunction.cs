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
	[Category] // 0x00000001800E1760-0x00000001800E17E0
	[Description] // 0x00000001800E1760-0x00000001800E17E0
	[Obsolete] // 0x00000001800E1760-0x00000001800E17E0
	public class ExecuteStaticFunction : ActionTask, ISubParametersContainer // TypeDefIndex: 14198
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected ReflectedWrapper functionWrapper; // 0x68
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x0000000181252400-0x0000000181252420 
		protected override string info { get; } // 0x0000000181544420-0x0000000181544940 
	
		// Constructors
		public ExecuteStaticFunction(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		new BBParameter[] ISubParametersContainer.GetSubParameters(); // 0x0000000181251910-0x0000000181251930
		public override void OnValidate(ITaskSystem ownerSystem); // 0x0000000181544330-0x0000000181544420
		protected override string OnInit(); // 0x0000000181544240-0x0000000181544330
		protected override void OnExecute(); // 0x0000000181544090-0x0000000181544240
		private void SetMethod(MethodInfo method); // 0x0000000181542EE0-0x0000000181542F20
	}
}
