/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype
{
	public class SceneLoader : ManagedBehaviour // TypeDefIndex: 14821
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static SceneLoader <instance>k__BackingField; // 0x00
	
		// Properties
		public static SceneLoader instance { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180A3C420-0x0000000180A3C460 0x0000000180A3C460-0x0000000180A3C4A0
	
		// Constructors
		public SceneLoader(); // 0x0000000180A3C3C0-0x0000000180A3C420
	
		// Methods
		public static void LoadScene(string inLevelDefId); // 0x0000000180A3C110-0x0000000180A3C230
		public override void MStart(); // 0x0000000180A3C2D0-0x0000000180A3C370
		public void StartLoadingScene(string inLevelDefId); // 0x0000000180A3C370-0x0000000180A3C3C0
		public override void MOnDestroy(); // 0x0000000180A3C290-0x0000000180A3C2D0
		private void Log(string inLog); // 0x0000000180A3C230-0x0000000180A3C290
	}
}
