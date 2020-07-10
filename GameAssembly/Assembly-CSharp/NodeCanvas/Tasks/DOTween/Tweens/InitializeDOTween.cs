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

namespace NodeCanvas.Tasks.DOTween.Tweens
{
	[Category] // 0x000000018012FFF0-0x00000001801300B0
	[Description] // 0x000000018012FFF0-0x00000001801300B0
	[Icon] // 0x000000018012FFF0-0x00000001801300B0
	[Name] // 0x000000018012FFF0-0x00000001801300B0
	public class InitializeDOTween : ActionTask // TypeDefIndex: 14485
	{
		// Fields
		public BBParameter<bool> RecycleAllByDefault; // 0x68
		public BBParameter<bool> UseSafeMode; // 0x70
		public LogBehaviour LogBehaviour; // 0x78
		public BBParameter<int> ExpectedMaximumConcurrentTweens; // 0x80
		public BBParameter<int> ExpectedMaximumConcurrentSequences; // 0x88
	
		// Properties
		protected override string info { get; } // 0x0000000180E8E890-0x0000000180E8E8C0 
	
		// Constructors
		public InitializeDOTween(); // 0x0000000180E8E740-0x0000000180E8E890
	
		// Methods
		protected override void OnExecute(); // 0x0000000180E8E550-0x0000000180E8E740
	}
}
