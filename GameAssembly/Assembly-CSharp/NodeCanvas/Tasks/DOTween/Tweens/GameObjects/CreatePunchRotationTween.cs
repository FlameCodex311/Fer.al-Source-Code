/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.DOTween.Tweens.GameObjects
{
	[Category] // 0x00000001801EB5A0-0x00000001801EB660
	[Description] // 0x00000001801EB5A0-0x00000001801EB660
	[Icon] // 0x00000001801EB5A0-0x00000001801EB660
	[Name] // 0x00000001801EB5A0-0x00000001801EB660
	public class CreatePunchRotationTween : ActionTask // TypeDefIndex: 15631
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Vector3> PunchRotation; // 0x68
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> Duration; // 0x70
		public BBParameter<int> Vibration; // 0x78
		public BBParameter<float> Elasticity; // 0x80
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Tween> CreatedTween; // 0x88
	
		// Properties
		protected override string info { get; } // 0x00000001807FBD50-0x00000001807FBE50 
	
		// Constructors
		public CreatePunchRotationTween(); // 0x00000001807FBC80-0x00000001807FBD50
	
		// Methods
		protected override void OnExecute(); // 0x00000001807FBB10-0x00000001807FBC80
	}
}
