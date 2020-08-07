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
	[Category] // 0x0000000180270C40-0x0000000180270CC0
	[Description] // 0x0000000180270C40-0x0000000180270CC0
	[Name] // 0x0000000180270C40-0x0000000180270CC0
	public class SetProperty : ActionTask, IReflectedWrapper // TypeDefIndex: 15427
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected ReflectedActionWrapper functionWrapper; // 0x68
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x000000018079D0D0-0x000000018079D0F0 
		public override Type agentType { get; } // 0x00000001807A6D20-0x00000001807A6E30 
		protected override string info { get; } // 0x00000001807A6E30-0x00000001807A7020 
	
		// Constructors
		public SetProperty(); // 0x000000018079E240-0x000000018079E250
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x00000001807A6AE0-0x00000001807A6AF0
		public override void OnValidate(ITaskSystem ownerSystem); // 0x00000001807A6C50-0x00000001807A6CD0
		protected override string OnInit(); // 0x00000001807A6B40-0x00000001807A6C50
		protected override void OnExecute(); // 0x00000001807A6AF0-0x00000001807A6B40
		private void SetMethod(MethodInfo method); // 0x00000001807A6CD0-0x00000001807A6D20
	}
}
