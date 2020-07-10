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
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180102AA0-0x0000000180102B20
	[Description] // 0x0000000180102AA0-0x0000000180102B20
	[Name] // 0x0000000180102AA0-0x0000000180102B20
	public class GetField : ActionTask // TypeDefIndex: 14308
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected Type targetType; // 0x68
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected string fieldName; // 0x70
		[BlackboardOnly] // 0x00000001800B4050-0x00000001800B4080
		[SerializeField] // 0x00000001800B4050-0x00000001800B4080
		protected BBObjectParameter saveAs; // 0x78
		private FieldInfo field; // 0x80
	
		// Properties
		public override Type agentType { get; } // 0x0000000181548090-0x0000000181548140 
		protected override string info { get; } // 0x0000000181548140-0x00000001815481E0 
	
		// Constructors
		public GetField(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override string OnInit(); // 0x0000000181547FD0-0x0000000181548090
		protected override void OnExecute(); // 0x0000000181547F30-0x0000000181547FD0
	}
}
