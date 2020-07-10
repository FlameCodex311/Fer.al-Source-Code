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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180105800-0x0000000180105880
	[Description] // 0x0000000180105800-0x0000000180105880
	[Name] // 0x0000000180105800-0x0000000180105880
	public class GetProperty_Multiplatform : ActionTask // TypeDefIndex: 14316
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected SerializedMethodInfo method; // 0x68
		[BlackboardOnly] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		protected BBObjectParameter returnValue; // 0x70
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x0000000181251900-0x0000000181251910 
		public override Type agentType { get; } // 0x000000018154A5A0-0x000000018154A6A0 
		protected override string info { get; } // 0x000000018154A6A0-0x000000018154A840 
	
		// Constructors
		public GetProperty_Multiplatform(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		public override void OnValidate(ITaskSystem ownerSystem); // 0x000000018154A370-0x000000018154A4E0
		protected override string OnInit(); // 0x000000018154A2E0-0x000000018154A370
		protected override void OnExecute(); // 0x000000018154A200-0x000000018154A2E0
		private void SetMethod(MethodInfo method); // 0x000000018154A4E0-0x000000018154A5A0
	}
}
