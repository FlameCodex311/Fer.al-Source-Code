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
	[Category] // 0x00000001800C6210-0x00000001800C6270
	[Obsolete] // 0x00000001800C6210-0x00000001800C6270
	public class CheckUnityObject : ConditionTask // TypeDefIndex: 14125
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<UnityEngine.Object> valueA; // 0x68
		public BBParameter<UnityEngine.Object> valueB; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000181255D70-0x0000000181255DB0 
	
		// Constructors
		public CheckUnityObject(); // 0x000000018124D940-0x000000018124D950
	
		// Methods
		protected override bool OnCheck(); // 0x0000000181255CD0-0x0000000181255D70
	}
}
