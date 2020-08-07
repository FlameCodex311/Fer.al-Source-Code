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
	[Category] // 0x00000001801EE9B0-0x00000001801EEA70
	[Description] // 0x00000001801EE9B0-0x00000001801EEA70
	[Icon] // 0x00000001801EE9B0-0x00000001801EEA70
	[Name] // 0x00000001801EE9B0-0x00000001801EEA70
	public class CreatePixelRectTween : ActionTask<Camera> // TypeDefIndex: 15639
	{
		// Fields
		public BBParameter<float> Duration; // 0x68
		public BBParameter<Rect> To; // 0x70
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Tween> CreatedTween; // 0x78
	
		// Properties
		protected override string info { get; } // 0x00000001807FB630-0x00000001807FB740 
	
		// Constructors
		public CreatePixelRectTween(); // 0x00000001807FB5F0-0x00000001807FB630
	
		// Methods
		protected override void OnExecute(); // 0x00000001807FB510-0x00000001807FB5F0
	}
}
