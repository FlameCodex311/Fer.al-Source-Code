/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype
{
	public class SceneLoader : ManagedBehaviour // TypeDefIndex: 16082
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static SceneLoader <instance>k__BackingField; // 0x00
	
		// Properties
		public static SceneLoader instance { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000181600090-0x00000001816000D0 0x00000001816000D0-0x0000000181600110
	
		// Constructors
		public SceneLoader(); // 0x0000000181600030-0x0000000181600090
	
		// Methods
		public static void LoadScene(string inLevelDefId); // 0x00000001815FFD80-0x00000001815FFEA0
		public override void MStart(); // 0x00000001815FFF40-0x00000001815FFFE0
		public void StartLoadingScene(string inLevelDefId); // 0x00000001815FFFE0-0x0000000181600030
		public override void MOnDestroy(); // 0x00000001815FFF00-0x00000001815FFF40
		private void Log(string inLog); // 0x00000001815FFEA0-0x00000001815FFF00
	}
}
