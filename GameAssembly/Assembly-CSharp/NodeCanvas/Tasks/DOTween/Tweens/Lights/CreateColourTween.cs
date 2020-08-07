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

namespace NodeCanvas.Tasks.DOTween.Tweens.Lights
{
	[Category] // 0x00000001801DFF90-0x00000001801E0050
	[Description] // 0x00000001801DFF90-0x00000001801E0050
	[Icon] // 0x00000001801DFF90-0x00000001801E0050
	[Name] // 0x00000001801DFF90-0x00000001801E0050
	public class CreateColourTween : ActionTask<Light> // TypeDefIndex: 15617
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Color> NewColour; // 0x68
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> Duration; // 0x70
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Tween> CreatedTween; // 0x78
	
		// Properties
		protected override string info { get; } // 0x00000001807F8C20-0x00000001807F8D50 
	
		// Constructors
		public CreateColourTween(); // 0x00000001807F8A70-0x00000001807F8AB0
	
		// Methods
		protected override void OnExecute(); // 0x00000001807F8510-0x00000001807F85F0
	}
}
