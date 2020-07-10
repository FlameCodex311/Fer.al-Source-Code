/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180128280-0x00000001801282E0
	[Description] // 0x0000000180128280-0x00000001801282E0
	public class SetCineCameraCut : ActionTask // TypeDefIndex: 14452
	{
		// Fields
		public BBParameter<CinemachineVirtualCamera> cinemachineVirtualCamera; // 0x68
		public BBParameter<bool> setActive; // 0x70
		public BBParameter<FeralAudioEmitter> audioEmitter; // 0x78
		public BBParameter<float> audioDelay; // 0x80
	
		// Properties
		protected override string info { get; } // 0x000000018125EA30-0x000000018125EB30 
	
		// Constructors
		public SetCineCameraCut(); // 0x000000018125E9E0-0x000000018125EA30
	
		// Methods
		protected override string OnInit(); // 0x000000018125E8F0-0x000000018125E980
		protected override void OnExecute(); // 0x000000018125E6C0-0x000000018125E8F0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <OnExecute>b__7_0(); // 0x000000018125E980-0x000000018125E9E0
	}
}
