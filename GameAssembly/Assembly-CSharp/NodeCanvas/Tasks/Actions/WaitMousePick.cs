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

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001800CBE00-0x00000001800CBE30
	public class WaitMousePick : ActionTask // TypeDefIndex: 14282
	{
		// Fields
		public ButtonKeys buttonKey; // 0x68
		public LayerMask mask; // 0x6C
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<GameObject> saveObjectAs; // 0x70
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> saveDistanceAs; // 0x78
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Vector3> savePositionAs; // 0x80
		private int buttonID; // 0x88
		private RaycastHit hit; // 0x8C
	
		// Properties
		protected override string info { get; } // 0x0000000181269080-0x00000001812690E0 
	
		// Nested types
		public enum ButtonKeys // TypeDefIndex: 14283
		{
			Left = 0,
			Right = 1,
			Middle = 2
		}
	
		// Constructors
		public WaitMousePick(); // 0x0000000181268E00-0x0000000181268E30
	
		// Methods
		protected override void OnUpdate(); // 0x0000000181268E90-0x0000000181269080
	}
}
