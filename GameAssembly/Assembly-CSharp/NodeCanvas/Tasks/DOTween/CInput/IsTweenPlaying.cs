/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.DOTween.CInput
{
	[Category] // 0x000000018012F420-0x000000018012F4E0
	[Description] // 0x000000018012F420-0x000000018012F4E0
	[Icon] // 0x000000018012F420-0x000000018012F4E0
	[Name] // 0x000000018012F420-0x000000018012F4E0
	public class IsTweenPlaying : ConditionTask // TypeDefIndex: 14483
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B4050-0x00000001800B4080
		[RequiredField] // 0x00000001800B4050-0x00000001800B4080
		public BBParameter<Tween> Tween; // 0x68
	
		// Constructors
		public IsTweenPlaying(); // 0x000000018124D940-0x000000018124D950
	
		// Methods
		protected override bool OnCheck(); // 0x00000001812577C0-0x0000000181257810
	}
}
