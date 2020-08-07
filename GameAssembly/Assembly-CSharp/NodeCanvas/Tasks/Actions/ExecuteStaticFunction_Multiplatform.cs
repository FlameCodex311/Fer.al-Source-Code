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
using ParadoxNotion.Serialization;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Obsolete] // 0x00000001801D0F20-0x00000001801D0F50
	public class ExecuteStaticFunction_Multiplatform : ActionTask // TypeDefIndex: 15589
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected SerializedMethodInfo method; // 0x68
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected List<BBObjectParameter> parameters; // 0x70
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		protected BBObjectParameter returnValue; // 0x78
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x000000018079C630-0x000000018079C640 
		protected override string info { get; } // 0x0000000180BA9970-0x0000000180BA9DA0 
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 15590
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<BBObjectParameter, object> <>9__9_0; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000180BC10A0-0x0000000180BC1100
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal object <OnExecute>b__9_0(BBObjectParameter p); // 0x0000000180BC0C10-0x0000000180BC0C60
		}
	
		// Constructors
		public ExecuteStaticFunction_Multiplatform(); // 0x0000000180BA9910-0x0000000180BA9970
	
		// Methods
		public override void OnValidate(ITaskSystem ownerSystem); // 0x0000000180BA9620-0x0000000180BA9660
		protected override string OnInit(); // 0x0000000180BA9590-0x0000000180BA9620
		protected override void OnExecute(); // 0x0000000180BA9420-0x0000000180BA9590
		private void SetMethod(MethodInfo method); // 0x0000000180BA9660-0x0000000180BA9910
	}
}
