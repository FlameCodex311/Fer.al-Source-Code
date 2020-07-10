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
	[Category] // 0x0000000180106380-0x0000000180106400
	[Description] // 0x0000000180106380-0x0000000180106400
	[Name] // 0x0000000180106380-0x0000000180106400
	public class SetProperty_Multiplatform : ActionTask // TypeDefIndex: 14319
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected SerializedMethodInfo method; // 0x68
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected BBObjectParameter parameter; // 0x70
	
		// Properties
		private MethodInfo targetMethod { get; } // 0x0000000181251900-0x0000000181251910 
		public override Type agentType { get; } // 0x0000000181261AA0-0x0000000181261BA0 
		protected override string info { get; } // 0x0000000181261BA0-0x0000000181261D40 
	
		// Constructors
		public SetProperty_Multiplatform(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		public override void OnValidate(ITaskSystem ownerSystem); // 0x00000001812617E0-0x00000001812619A0
		protected override string OnInit(); // 0x0000000181261750-0x00000001812617E0
		protected override void OnExecute(); // 0x0000000181261640-0x0000000181261750
		private void SetMethod(MethodInfo method); // 0x00000001812619A0-0x0000000181261AA0
	}
}
