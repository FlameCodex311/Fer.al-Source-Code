/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180292960-0x00000001802929C0
	[Description] // 0x0000000180292960-0x00000001802929C0
	public class SetCineCameraCut : ActionTask // TypeDefIndex: 15558
	{
		// Fields
		public BBParameter<CinemachineVirtualCamera> cinemachineVirtualCamera; // 0x68
		public BBParameter<bool> setActive; // 0x70
		public BBParameter<FeralAudioEmitter> audioEmitter; // 0x78
		public BBParameter<float> audioDelay; // 0x80
	
		// Properties
		protected override string info { get; } // 0x00000001807A3560-0x00000001807A3660 
	
		// Constructors
		public SetCineCameraCut(); // 0x00000001807A3510-0x00000001807A3560
	
		// Methods
		protected override string OnInit(); // 0x00000001807A3420-0x00000001807A34B0
		protected override void OnExecute(); // 0x00000001807A31F0-0x00000001807A3420
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <OnExecute>b__7_0(); // 0x00000001807A34B0-0x00000001807A3510
	}
}
