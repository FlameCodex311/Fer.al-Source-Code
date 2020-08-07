/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Obsolete] // 0x00000001801D0F20-0x00000001801D0F50
	public class ExecuteStaticFunction : ActionTask, ISubParametersContainer // TypeDefIndex: 15588
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected ReflectedWrapper functionWrapper; // 0x68
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x000000018079D0D0-0x000000018079D0F0 
		protected override string info { get; } // 0x0000000180BAA030-0x0000000180BAA540 
	
		// Constructors
		public ExecuteStaticFunction(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		BBParameter[] ISubParametersContainer.GetSubParameters(); // 0x0000000180BA9DA0-0x0000000180BA9DC0
		public override void OnValidate(ITaskSystem ownerSystem); // 0x0000000180BA8BF0-0x0000000180BA8C70
		protected override string OnInit(); // 0x0000000180BA9F70-0x0000000180BAA030
		protected override void OnExecute(); // 0x0000000180BA9DC0-0x0000000180BA9F70
		private void SetMethod(MethodInfo method); // 0x0000000180BA8C70-0x0000000180BA8CC0
	}
}
