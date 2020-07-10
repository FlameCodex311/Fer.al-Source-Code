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

namespace NodeCanvas.Tasks.DOTween.Sequences
{
	[Category] // 0x000000018014D330-0x000000018014D3F0
	[Description] // 0x000000018014D330-0x000000018014D3F0
	[Icon] // 0x000000018014D330-0x000000018014D3F0
	[Name] // 0x000000018014D330-0x000000018014D3F0
	public class AppendInterval : ActionTask // TypeDefIndex: 14538
	{
		// Fields
		[BlackboardOnly] // 0x00000001800B4050-0x00000001800B4080
		[RequiredField] // 0x00000001800B4050-0x00000001800B4080
		public BBParameter<Sequence> Sequence; // 0x68
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> Interval; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018124D6B0-0x000000018124D750 
	
		// Constructors
		public AppendInterval(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x000000018124D620-0x000000018124D6B0
	}
}
