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
	[Category] // 0x00000001801EAC50-0x00000001801EAD10
	[Description] // 0x00000001801EAC50-0x00000001801EAD10
	[Icon] // 0x00000001801EAC50-0x00000001801EAD10
	[Name] // 0x00000001801EAC50-0x00000001801EAD10
	public class CreatePunchPositionTween : ActionTask // TypeDefIndex: 15630
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Vector3> PunchVector; // 0x68
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> Duration; // 0x70
		public BBParameter<int> Vibration; // 0x78
		public BBParameter<float> Elasticity; // 0x80
		public BBParameter<bool> UseSnapping; // 0x88
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Tween> CreatedTween; // 0x90
	
		// Properties
		protected override string info { get; } // 0x00000001807FB9D0-0x00000001807FBB10 
	
		// Constructors
		public CreatePunchPositionTween(); // 0x00000001807FB900-0x00000001807FB9D0
	
		// Methods
		protected override void OnExecute(); // 0x00000001807FB740-0x00000001807FB900
	}
}
