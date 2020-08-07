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

namespace NodeCanvas.Tasks.DOTween.Tweens.LineRenderer
{
	[Category] // 0x00000001801DF2B0-0x00000001801DF370
	[Description] // 0x00000001801DF2B0-0x00000001801DF370
	[Icon] // 0x00000001801DF2B0-0x00000001801DF370
	[Name] // 0x00000001801DF2B0-0x00000001801DF370
	public class CreateColourTween : ActionTask<LineRenderer> // TypeDefIndex: 15616
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Color> StartColour; // 0x68
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Color> EndColour; // 0x70
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> Duration; // 0x78
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<Tween> CreatedTween; // 0x80
	
		// Properties
		protected override string info { get; } // 0x00000001807F8D50-0x00000001807F8E00 
	
		// Constructors
		public CreateColourTween(); // 0x00000001807F8AB0-0x00000001807F8AF0
	
		// Methods
		protected override void OnExecute(); // 0x00000001807F87F0-0x00000001807F8A30
	}
}
