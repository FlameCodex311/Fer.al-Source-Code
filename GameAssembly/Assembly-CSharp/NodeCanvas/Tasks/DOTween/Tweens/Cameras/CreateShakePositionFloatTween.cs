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

namespace NodeCanvas.Tasks.DOTween.Tweens.Cameras
{
	[Category] // 0x00000001801EF320-0x00000001801EF3E0
	[Description] // 0x00000001801EF320-0x00000001801EF3E0
	[Icon] // 0x00000001801EF320-0x00000001801EF3E0
	[Name] // 0x00000001801EF320-0x00000001801EF3E0
	public class CreateShakePositionFloatTween : ActionTask<Camera> // TypeDefIndex: 15641
	{
		// Fields
		public BBParameter<float> Duration; // 0x68
		public BBParameter<float> Strength; // 0x70
		public BBParameter<int> vibrato; // 0x78
		public BBParameter<float> randomness; // 0x80
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Tween> CreatedTween; // 0x88
	
		// Properties
		protected override string info { get; } // 0x00000001807FCCC0-0x00000001807FCE60 
	
		// Constructors
		public CreateShakePositionFloatTween(); // 0x00000001807FCC80-0x00000001807FCCC0
	
		// Methods
		protected override void OnExecute(); // 0x00000001807FCB30-0x00000001807FCC80
	}
}
