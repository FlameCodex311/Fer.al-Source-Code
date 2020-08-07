/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.DOTween.Tweens.GameObjects
{
	[Category] // 0x00000001801EA2E0-0x00000001801EA3A0
	[Description] // 0x00000001801EA2E0-0x00000001801EA3A0
	[Icon] // 0x00000001801EA2E0-0x00000001801EA3A0
	[Name] // 0x00000001801EA2E0-0x00000001801EA3A0
	public class CreatePathTween : ActionTask // TypeDefIndex: 15629
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<List<Vector3>> VectorPath; // 0x68
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> Duration; // 0x70
		public PathType PathType; // 0x78
		public PathMode PathMode; // 0x7C
		public BBParameter<int> Resolution; // 0x80
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Tween> CreatedTween; // 0x88
	
		// Properties
		protected override string info { get; } // 0x00000001807FB240-0x00000001807FB350 
	
		// Constructors
		public CreatePathTween(); // 0x00000001807FB1B0-0x00000001807FB240
	
		// Methods
		protected override void OnExecute(); // 0x00000001807FB010-0x00000001807FB1B0
	}
}
