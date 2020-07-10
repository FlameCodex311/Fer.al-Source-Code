/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001800CBE00-0x00000001800CBE30
	public class CheckMousePick2D : ConditionTask // TypeDefIndex: 14143
	{
		// Fields
		public ButtonKeys buttonKey; // 0x68
		public LayerMask mask; // 0x6C
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<GameObject> saveGoAs; // 0x70
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> saveDistanceAs; // 0x78
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Vector3> savePosAs; // 0x80
		private int buttonID; // 0x88
		private RaycastHit2D hit; // 0x8C
	
		// Properties
		protected override string info { get; } // 0x0000000181253A20-0x0000000181253B40 
	
		// Constructors
		public CheckMousePick2D(); // 0x00000001812539F0-0x0000000181253A20
	
		// Methods
		protected override bool OnCheck(); // 0x00000001812536D0-0x00000001812539F0
	}
}
