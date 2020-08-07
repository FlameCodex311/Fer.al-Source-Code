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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x000000018023A140-0x000000018023A1C0
	[Description] // 0x000000018023A140-0x000000018023A1C0
	[Name] // 0x000000018023A140-0x000000018023A1C0
	public class CheckProperty : ConditionTask // TypeDefIndex: 15255
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected ReflectedFunctionWrapper functionWrapper; // 0x68
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected BBParameter checkValue; // 0x70
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected CompareMethod comparison; // 0x78
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x000000018079D0D0-0x000000018079D0F0 
		public override Type agentType { get; } // 0x00000001807F53B0-0x00000001807F54C0 
		protected override string info { get; } // 0x00000001807F54C0-0x00000001807F56B0 
	
		// Constructors
		public CheckProperty(); // 0x0000000180792480-0x0000000180792490
	
		// Methods
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018079CA80-0x000000018079CB50
		protected override string OnInit(); // 0x00000001807F52A0-0x00000001807F53B0
		protected override bool OnCheck(); // 0x00000001807F4F70-0x00000001807F52A0
		private void SetMethod(MethodInfo method); // 0x000000018079CB50-0x000000018079CBE0
	}
}
