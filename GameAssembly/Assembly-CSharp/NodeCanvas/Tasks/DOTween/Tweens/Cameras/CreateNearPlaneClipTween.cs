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
	[Category] // 0x00000001801EDEE0-0x00000001801EDFA0
	[Description] // 0x00000001801EDEE0-0x00000001801EDFA0
	[Icon] // 0x00000001801EDEE0-0x00000001801EDFA0
	[Name] // 0x00000001801EDEE0-0x00000001801EDFA0
	public class CreateNearPlaneClipTween : ActionTask<Camera> // TypeDefIndex: 15637
	{
		// Fields
		public BBParameter<float> Duration; // 0x68
		public BBParameter<float> To; // 0x70
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Tween> CreatedTween; // 0x78
	
		// Properties
		protected override string info { get; } // 0x00000001807FACD0-0x00000001807FADE0 
	
		// Constructors
		public CreateNearPlaneClipTween(); // 0x00000001807FAC90-0x00000001807FACD0
	
		// Methods
		protected override void OnExecute(); // 0x00000001807FABB0-0x00000001807FAC90
	}
}
