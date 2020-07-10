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
	internal class CubicBezierDecoder : ABSPathDecoder // TypeDefIndex: 5654
	{
		// Fields
		private static readonly ControlPoint[] _PartialControlPs; // 0x00
		private static readonly Vector3[] _PartialWps; // 0x08
	
		// Constructors
		public CubicBezierDecoder(); // 0x000000018036B6C0-0x000000018036B6D0
		static CubicBezierDecoder(); // 0x0000000180BC28E0-0x0000000180BC2950
	
		// Methods
		internal override void FinalizePath(Path p, Vector3[] wps, bool isClosedPath); // 0x0000000180BC16C0-0x0000000180BC1D70
		internal override Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints); // 0x0000000180BC1D70-0x0000000180BC2140
		internal void SetTimeToLengthTables(Path p, int subdivisions); // 0x0000000180BC2140-0x0000000180BC23E0
		internal void SetWaypointsLengths(Path p, int subdivisions); // 0x0000000180BC23E0-0x0000000180BC28E0
	}
}
