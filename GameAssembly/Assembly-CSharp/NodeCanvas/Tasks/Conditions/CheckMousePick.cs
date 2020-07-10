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
	public class CheckMousePick : ConditionTask // TypeDefIndex: 14142
	{
		// Fields
		public ButtonKeys buttonKey; // 0x68
		[LayerField] // 0x00000001800B36B0-0x00000001800B36C0
		public int layer; // 0x6C
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<GameObject> saveGoAs; // 0x70
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> saveDistanceAs; // 0x78
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Vector3> savePosAs; // 0x80
		private RaycastHit hit; // 0x88
	
		// Properties
		protected override string info { get; } // 0x0000000181253D20-0x0000000181253E60 
	
		// Constructors
		public CheckMousePick(); // 0x000000018124D940-0x000000018124D950
	
		// Methods
		protected override bool OnCheck(); // 0x0000000181253B40-0x0000000181253D20
	}
}
