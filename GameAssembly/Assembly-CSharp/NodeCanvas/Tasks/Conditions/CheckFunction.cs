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
	[Category] // 0x0000000180239740-0x00000001802397C0
	[Description] // 0x0000000180239740-0x00000001802397C0
	[Name] // 0x0000000180239740-0x00000001802397C0
	public class CheckFunction : ConditionTask // TypeDefIndex: 15254
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
		public override Type agentType { get; } // 0x000000018079CBE0-0x000000018079CCF0 
		protected override string info { get; } // 0x000000018079CCF0-0x000000018079D0D0 
	
		// Constructors
		public CheckFunction(); // 0x0000000180792480-0x0000000180792490
	
		// Methods
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018079CA80-0x000000018079CB50
		protected override string OnInit(); // 0x000000018079C970-0x000000018079CA80
		protected override bool OnCheck(); // 0x000000018079C640-0x000000018079C970
		private void SetMethod(MethodInfo method); // 0x000000018079CB50-0x000000018079CBE0
	}
}
