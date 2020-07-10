/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 48: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5511-5701

namespace DG.Tweening.Plugins.Core.PathCore
{
	internal class LinearDecoder : ABSPathDecoder // TypeDefIndex: 5658
	{
		// Constructors
		public LinearDecoder(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		internal override void FinalizePath(Path p, Vector3[] wps, bool isClosedPath); // 0x0000000180BCDC70-0x0000000180BCDCC0
		internal override Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints); // 0x0000000180BCDCC0-0x0000000180BCDF90
		internal void SetTimeToLengthTables(Path p, int subdivisions); // 0x0000000180BCDF90-0x0000000180BCE250
		internal void SetWaypointsLengths(Path p, int subdivisions); // 0x00000001803581E0-0x00000001803581F0
	}
}
