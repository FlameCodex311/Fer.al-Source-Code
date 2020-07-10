/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace Crosstales.Common.Util
{
	public class FFTAnalyzer : UnityEngine.MonoBehaviour // TypeDefIndex: 9956
	{
		// Fields
		[Tooltip] // 0x0000000180117170-0x00000001801171A0
		public float[] Samples; // 0x18
		[Range] // 0x00000001801173D0-0x0000000180117430
		[Tooltip] // 0x00000001801173D0-0x0000000180117430
		public int Channel; // 0x20
		[Tooltip] // 0x00000001801176C0-0x00000001801176F0
		public FFTWindow FFTMode; // 0x24
	
		// Constructors
		public FFTAnalyzer(); // 0x00000001815DC290-0x00000001815DC2E0
	
		// Methods
		public void Update(); // 0x00000001815DC270-0x00000001815DC290
	}
}
