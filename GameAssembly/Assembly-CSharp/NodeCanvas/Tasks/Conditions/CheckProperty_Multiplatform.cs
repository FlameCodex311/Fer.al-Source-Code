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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001800D4B70-0x00000001800D4BF0
	[Description] // 0x00000001800D4B70-0x00000001800D4BF0
	[Name] // 0x00000001800D4B70-0x00000001800D4BF0
	public class CheckProperty_Multiplatform : ConditionTask // TypeDefIndex: 14155
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected SerializedMethodInfo method; // 0x68
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected BBObjectParameter checkValue; // 0x70
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected CompareMethod comparison; // 0x78
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x0000000181251900-0x0000000181251910 
		public override Type agentType { get; } // 0x00000001812546F0-0x00000001812547F0 
		protected override string info { get; } // 0x00000001812547F0-0x00000001812549C0 
	
		// Constructors
		public CheckProperty_Multiplatform(); // 0x000000018124D940-0x000000018124D950
	
		// Methods
		public override void OnValidate(ITaskSystem ownerSystem); // 0x00000001812544C0-0x0000000181254630
		protected override string OnInit(); // 0x0000000181254460-0x00000001812544C0
		protected override bool OnCheck(); // 0x00000001812540D0-0x0000000181254460
		private void SetMethod(MethodInfo method); // 0x0000000181254630-0x00000001812546F0
	}
}
