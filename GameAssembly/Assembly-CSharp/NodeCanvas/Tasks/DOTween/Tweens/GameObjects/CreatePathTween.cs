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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.DOTween.Tweens.GameObjects
{
	[Category] // 0x0000000180144130-0x00000001801441F0
	[Description] // 0x0000000180144130-0x00000001801441F0
	[Icon] // 0x0000000180144130-0x00000001801441F0
	[Name] // 0x0000000180144130-0x00000001801441F0
	public class CreatePathTween : ActionTask // TypeDefIndex: 14520
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<List<Vector3>> VectorPath; // 0x68
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> Duration; // 0x70
		public PathType PathType; // 0x78
		public PathMode PathMode; // 0x7C
		public BBParameter<int> Resolution; // 0x80
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<Tween> CreatedTween; // 0x88
	
		// Properties
		protected override string info { get; } // 0x0000000180E8B060-0x0000000180E8B170 
	
		// Constructors
		public CreatePathTween(); // 0x0000000180E8AFD0-0x0000000180E8B060
	
		// Methods
		protected override void OnExecute(); // 0x0000000180E8AE30-0x0000000180E8AFD0
	}
}
