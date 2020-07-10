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
	[Category] // 0x00000001801074A0-0x0000000180107520
	[Description] // 0x00000001801074A0-0x0000000180107520
	[Name] // 0x00000001801074A0-0x0000000180107520
	public class GetProperty : ActionTask, ISubParametersContainer // TypeDefIndex: 14322
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected ReflectedFunctionWrapper functionWrapper; // 0x68
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x0000000181252400-0x0000000181252420 
		public override Type agentType { get; } // 0x000000018154AAB0-0x000000018154ABC0 
		protected override string info { get; } // 0x000000018154ABC0-0x000000018154ADA0 
	
		// Constructors
		public GetProperty(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		new BBParameter[] ISubParametersContainer.GetSubParameters(); // 0x0000000181251910-0x0000000181251930
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018154A980-0x000000018154AA70
		protected override string OnInit(); // 0x000000018154A840-0x000000018154A980
		protected override void OnExecute(); // 0x0000000181261D40-0x0000000181261D90
		private void SetMethod(MethodInfo method); // 0x000000018154AA70-0x000000018154AAB0
	}
}
