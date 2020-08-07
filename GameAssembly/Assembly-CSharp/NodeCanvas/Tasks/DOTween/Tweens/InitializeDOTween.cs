/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.DOTween.Tweens
{
	[Category] // 0x00000001801D3510-0x00000001801D35D0
	[Description] // 0x00000001801D3510-0x00000001801D35D0
	[Icon] // 0x00000001801D3510-0x00000001801D35D0
	[Name] // 0x00000001801D3510-0x00000001801D35D0
	public class InitializeDOTween : ActionTask // TypeDefIndex: 15594
	{
		// Fields
		public BBParameter<bool> RecycleAllByDefault; // 0x68
		public BBParameter<bool> UseSafeMode; // 0x70
		public LogBehaviour LogBehaviour; // 0x78
		public BBParameter<int> ExpectedMaximumConcurrentTweens; // 0x80
		public BBParameter<int> ExpectedMaximumConcurrentSequences; // 0x88
	
		// Properties
		protected override string info { get; } // 0x00000001807FDE90-0x00000001807FDEC0 
	
		// Constructors
		public InitializeDOTween(); // 0x00000001807FDD40-0x00000001807FDE90
	
		// Methods
		protected override void OnExecute(); // 0x00000001807FDB60-0x00000001807FDD40
	}
}
