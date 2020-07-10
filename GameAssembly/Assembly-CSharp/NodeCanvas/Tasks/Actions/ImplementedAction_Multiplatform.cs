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
using ParadoxNotion.Design;
using ParadoxNotion.Serialization;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180105E40-0x0000000180105EC0
	[Description] // 0x0000000180105E40-0x0000000180105EC0
	[Name] // 0x0000000180105E40-0x0000000180105EC0
	public class ImplementedAction_Multiplatform : ActionTask // TypeDefIndex: 14317
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private SerializedMethodInfo method; // 0x68
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private List<BBObjectParameter> parameters; // 0x70
		private Status actionStatus; // 0x78
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x0000000181251900-0x0000000181251910 
		public override Type agentType { get; } // 0x000000018154C1E0-0x000000018154C2E0 
		protected override string info { get; } // 0x000000018154C2E0-0x000000018154C4D0 
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 14318
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<BBObjectParameter, object> <>9__11_0; // 0x08
	
			// Constructors
			static <>c(); // 0x000000018155C750-0x000000018155C7B0
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal object <OnUpdate>b__11_0(BBObjectParameter p); // 0x000000018155C2B0-0x000000018155C300
		}
	
		// Constructors
		public ImplementedAction_Multiplatform(); // 0x000000018154C170-0x000000018154C1E0
	
		// Methods
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018154BF00-0x000000018154BFD0
		protected override string OnInit(); // 0x000000018154BC90-0x000000018154BD20
		protected override void OnUpdate(); // 0x000000018154BD30-0x000000018154BF00
		protected override void OnStop(); // 0x000000018154BD20-0x000000018154BD30
		private void SetMethod(MethodInfo method); // 0x000000018154BFD0-0x000000018154C170
	}
}
