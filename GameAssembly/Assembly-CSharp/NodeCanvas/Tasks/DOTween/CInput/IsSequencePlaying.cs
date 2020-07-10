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
	[Category] // 0x000000018012EEC0-0x000000018012EF80
	[Description] // 0x000000018012EEC0-0x000000018012EF80
	[Icon] // 0x000000018012EEC0-0x000000018012EF80
	[Name] // 0x000000018012EEC0-0x000000018012EF80
	public class IsSequencePlaying : ConditionTask // TypeDefIndex: 14482
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B4050-0x00000001800B4080
		[RequiredField] // 0x00000001800B4050-0x00000001800B4080
		public BBParameter<Sequence> Sequence; // 0x68
	
		// Constructors
		public IsSequencePlaying(); // 0x000000018124D940-0x000000018124D950
	
		// Methods
		protected override bool OnCheck(); // 0x0000000181257770-0x00000001812577C0
	}
}
