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
	public class GetInputAxis : ActionTask // TypeDefIndex: 14279
	{
		// Fields
		public BBParameter<string> xAxisName; // 0x68
		public BBParameter<string> yAxisName; // 0x70
		public BBParameter<string> zAxisName; // 0x78
		public BBParameter<float> multiplier; // 0x80
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Vector3> saveAs; // 0x88
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> saveXAs; // 0x90
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> saveYAs; // 0x98
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> saveZAs; // 0xA0
		public bool repeat; // 0xA8
	
		// Constructors
		public GetInputAxis(); // 0x0000000181548800-0x0000000181548880
	
		// Methods
		protected override void OnExecute(); // 0x00000001815487F0-0x0000000181548800
		protected override void OnUpdate(); // 0x00000001815487F0-0x0000000181548800
		private void Do(); // 0x00000001815484A0-0x00000001815487F0
	}
}
