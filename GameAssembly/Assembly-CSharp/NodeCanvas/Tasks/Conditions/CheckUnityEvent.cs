/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001800D2220-0x00000001800D2280
	[Description] // 0x00000001800D2220-0x00000001800D2280
	public class CheckUnityEvent : ConditionTask // TypeDefIndex: 14151
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Type targetType; // 0x68
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string eventName; // 0x70
	
		// Properties
		public override Type agentType { get; } // 0x0000000181255C00-0x0000000181255C70 
		protected override string info { get; } // 0x0000000181255C70-0x0000000181255CD0 
	
		// Constructors
		public CheckUnityEvent(); // 0x000000018124D940-0x000000018124D950
	
		// Methods
		protected override string OnInit(); // 0x0000000181255A30-0x0000000181255C00
		public void Raised(); // 0x000000018124D880-0x000000018124D890
		protected override bool OnCheck(); // 0x00000001803C28F0-0x00000001803C2900
	}
}
