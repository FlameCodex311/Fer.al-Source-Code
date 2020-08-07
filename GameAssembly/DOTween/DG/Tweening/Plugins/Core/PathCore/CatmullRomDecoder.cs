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
	internal class CatmullRomDecoder : ABSPathDecoder // TypeDefIndex: 5816
	{
		// Fields
		private static readonly ControlPoint[] _PartialControlPs; // 0x00
		private static readonly Vector3[] _PartialWps; // 0x08
	
		// Constructors
		public CatmullRomDecoder(); // 0x0000000180373240-0x0000000180373250
		static CatmullRomDecoder(); // 0x0000000181783740-0x00000001817837B0
	
		// Methods
		internal override void FinalizePath(Path p, Vector3[] wps, bool isClosedPath); // 0x00000001817823C0-0x00000001817827F0
		internal override Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints); // 0x00000001817827F0-0x0000000181782EA0
		internal void SetTimeToLengthTables(Path p, int subdivisions); // 0x0000000181782EA0-0x0000000181783130
		internal void SetWaypointsLengths(Path p, int subdivisions); // 0x0000000181783130-0x0000000181783740
	}
}
