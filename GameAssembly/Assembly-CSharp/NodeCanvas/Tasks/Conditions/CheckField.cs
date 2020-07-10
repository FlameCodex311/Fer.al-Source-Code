/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001800CFD20-0x00000001800CFDA0
	[Description] // 0x00000001800CFD20-0x00000001800CFDA0
	[Name] // 0x00000001800CFD20-0x00000001800CFDA0
	public class CheckField : ConditionTask // TypeDefIndex: 14148
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected BBParameter checkValue; // 0x68
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected Type targetType; // 0x70
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected string fieldName; // 0x78
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected CompareMethod comparison; // 0x80
		private FieldInfo field; // 0x88
	
		// Properties
		public override Type agentType { get; } // 0x00000001812508A0-0x0000000181250950 
		protected override string info { get; } // 0x0000000181250950-0x0000000181250AB0 
	
		// Constructors
		public CheckField(); // 0x000000018124D940-0x000000018124D950
	
		// Methods
		protected override string OnInit(); // 0x00000001812507F0-0x00000001812508A0
		protected override bool OnCheck(); // 0x0000000181250490-0x00000001812507F0
	}
}
