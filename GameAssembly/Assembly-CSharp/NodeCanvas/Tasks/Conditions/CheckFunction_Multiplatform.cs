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
using ParadoxNotion;
using ParadoxNotion.Design;
using ParadoxNotion.Serialization;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x0000000180235260-0x00000001802352E0
	[Description] // 0x0000000180235260-0x00000001802352E0
	[Name] // 0x0000000180235260-0x00000001802352E0
	public class CheckFunction_Multiplatform : ConditionTask, IReflectedWrapper // TypeDefIndex: 15246
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected SerializedMethodInfo method; // 0x68
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected List<BBObjectParameter> parameters; // 0x70
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected CompareMethod comparison; // 0x78
		[BlackboardOnly] // 0x00000001801CDDD0-0x00000001801CDE00
		[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
		protected BBObjectParameter checkValue; // 0x80
		private object[] args; // 0x88
		private bool[] parameterIsByRef; // 0x90
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x000000018079C630-0x000000018079C640 
		public override Type agentType { get; } // 0x000000018079C1A0-0x000000018079C280 
		protected override string info { get; } // 0x000000018079C280-0x000000018079C630 
	
		// Constructors
		public CheckFunction_Multiplatform(); // 0x000000018079C140-0x000000018079C1A0
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x00000001803765E0-0x00000001803765F0
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018079BE80-0x000000018079BEC0
		protected override string OnInit(); // 0x000000018079BCB0-0x000000018079BE80
		protected override bool OnCheck(); // 0x000000018079B750-0x000000018079BCB0
		private void SetMethod(MethodInfo method); // 0x000000018079BEC0-0x000000018079C140
	}
}
