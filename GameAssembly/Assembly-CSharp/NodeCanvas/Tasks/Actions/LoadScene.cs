/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine.SceneManagement;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001800E5A60-0x00000001800E5A90
	public class LoadScene : ActionTask // TypeDefIndex: 14211
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<string> sceneName; // 0x68
		public BBParameter<LoadSceneMode> mode; // 0x70
	
		// Properties
		protected override string info { get; } // 0x000000018154E3D0-0x000000018154E410 
	
		// Constructors
		public LoadScene(); // 0x0000000180E87F80-0x0000000180E87F90
	
		// Methods
		protected override void OnExecute(); // 0x000000018154E340-0x000000018154E3D0
	}
}
