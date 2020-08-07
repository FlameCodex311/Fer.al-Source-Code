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
using ParadoxNotion.Serialization;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x0000000180235EB0-0x0000000180235F30
	[Description] // 0x0000000180235EB0-0x0000000180235F30
	[Name] // 0x0000000180235EB0-0x0000000180235F30
	public class CheckProperty_Multiplatform : ConditionTask, IReflectedWrapper // TypeDefIndex: 15247
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected SerializedMethodInfo method; // 0x68
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected BBObjectParameter checkValue; // 0x70
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected CompareMethod comparison; // 0x78
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x000000018079C630-0x000000018079C640 
		public override Type agentType { get; } // 0x00000001807F4CC0-0x00000001807F4DA0 
		protected override string info { get; } // 0x00000001807F4DA0-0x00000001807F4F70 
	
		// Constructors
		public CheckProperty_Multiplatform(); // 0x0000000180792480-0x0000000180792490
	
		// Methods
		ISerializedReflectedInfo IReflectedWrapper.GetSerializedInfo(); // 0x00000001803765E0-0x00000001803765F0
		public override void OnValidate(ITaskSystem ownerSystem); // 0x00000001807F4B20-0x00000001807F4C00
		protected override string OnInit(); // 0x00000001807F4AA0-0x00000001807F4B20
		protected override bool OnCheck(); // 0x00000001807F4730-0x00000001807F4AA0
		private void SetMethod(MethodInfo method); // 0x00000001807F4C00-0x00000001807F4CC0
	}
}
