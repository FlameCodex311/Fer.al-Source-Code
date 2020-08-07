/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace Crosstales.Common.Util
{
	public class FFTAnalyzer : UnityEngine.MonoBehaviour // TypeDefIndex: 9742
	{
		// Fields
		[Tooltip] // 0x00000001801FB770-0x00000001801FB7A0
		public float[] Samples; // 0x18
		[Range] // 0x00000001801FCDF0-0x00000001801FCE50
		[Tooltip] // 0x00000001801FCDF0-0x00000001801FCE50
		public int Channel; // 0x20
		[Tooltip] // 0x00000001801FD180-0x00000001801FD1B0
		public FFTWindow FFTMode; // 0x24
	
		// Constructors
		public FFTAnalyzer(); // 0x0000000181084630-0x0000000181084680
	
		// Methods
		public void Update(); // 0x0000000181084610-0x0000000181084630
	}
}
