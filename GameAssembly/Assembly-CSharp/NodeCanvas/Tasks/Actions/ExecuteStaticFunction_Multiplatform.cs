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
	[Category] // 0x00000001800E1C20-0x00000001800E1CD0
	[Description] // 0x00000001800E1C20-0x00000001800E1CD0
	[Name] // 0x00000001800E1C20-0x00000001800E1CD0
	[Obsolete] // 0x00000001800E1C20-0x00000001800E1CD0
	public class ExecuteStaticFunction_Multiplatform : ActionTask // TypeDefIndex: 14199
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected SerializedMethodInfo method; // 0x68
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected List<BBObjectParameter> parameters; // 0x70
		[BlackboardOnly] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		protected BBObjectParameter returnValue; // 0x78
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x0000000181251900-0x0000000181251910 
		protected override string info { get; } // 0x0000000181543C60-0x0000000181544090 
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 14200
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<BBObjectParameter, object> <>9__9_0; // 0x08
	
			// Constructors
			static <>c(); // 0x000000018155C810-0x000000018155C870
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal object <OnExecute>b__9_0(BBObjectParameter p); // 0x000000018155C260-0x000000018155C2B0
		}
	
		// Constructors
		public ExecuteStaticFunction_Multiplatform(); // 0x0000000181543C00-0x0000000181543C60
	
		// Methods
		public override void OnValidate(ITaskSystem ownerSystem); // 0x0000000181543890-0x0000000181543960
		protected override string OnInit(); // 0x0000000181543800-0x0000000181543890
		protected override void OnExecute(); // 0x0000000181543690-0x0000000181543800
		private void SetMethod(MethodInfo method); // 0x0000000181543960-0x0000000181543C00
	}
}
