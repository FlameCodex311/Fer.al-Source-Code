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
using ParadoxNotion.Serialization;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001802708D0-0x0000000180270950
	[Description] // 0x00000001802708D0-0x0000000180270950
	[Name] // 0x00000001802708D0-0x0000000180270950
	public class ImplementedAction : ActionTask, IReflectedWrapper // TypeDefIndex: 15426
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected ReflectedFunctionWrapper functionWrapper; // 0x68
		private Status actionStatus; // 0x70
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x000000018079D0D0-0x000000018079D0F0 
		public override Type agentType { get; } // 0x0000000180BB2640-0x0000000180BB2750 
		protected override string info { get; } // 0x0000000180BB2750-0x0000000180BB29B0 
	
		// Constructors
		public ImplementedAction(); // 0x0000000180BB2630-0x0000000180BB2640
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x00000001807A6AE0-0x00000001807A6AF0
		public override void OnValidate(ITaskSystem ownerSystem); // 0x0000000180BB0930-0x0000000180BB09B0
		protected override string OnInit(); // 0x0000000180BB2460-0x0000000180BB2570
		protected override void OnUpdate(); // 0x0000000180BB2580-0x0000000180BB2630
		protected override void OnStop(); // 0x0000000180BB2570-0x0000000180BB2580
		private void SetMethod(MethodInfo method); // 0x0000000180BB09B0-0x0000000180BB0A00
	}
}
