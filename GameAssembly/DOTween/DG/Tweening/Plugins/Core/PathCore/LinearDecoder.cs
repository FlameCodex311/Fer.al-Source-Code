/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 49: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5670-5860

namespace DG.Tweening.Plugins.Core.PathCore
{
	internal class LinearDecoder : ABSPathDecoder // TypeDefIndex: 5817
	{
		// Constructors
		public LinearDecoder(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		internal override void FinalizePath(Path p, Vector3[] wps, bool isClosedPath); // 0x0000000181790EC0-0x0000000181790F00
		internal override Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints); // 0x0000000181790F00-0x00000001817911B0
		internal void SetTimeToLengthTables(Path p, int subdivisions); // 0x00000001817911B0-0x0000000181791450
		internal void SetWaypointsLengths(Path p, int subdivisions); // 0x00000001803774A0-0x00000001803774B0
	}
}
