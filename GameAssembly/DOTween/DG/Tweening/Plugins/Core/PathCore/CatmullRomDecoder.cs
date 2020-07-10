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
	internal class CatmullRomDecoder : ABSPathDecoder // TypeDefIndex: 5657
	{
		// Fields
		private static readonly ControlPoint[] _PartialControlPs; // 0x00
		private static readonly Vector3[] _PartialWps; // 0x08
	
		// Constructors
		public CatmullRomDecoder(); // 0x000000018036B6C0-0x000000018036B6D0
		static CatmullRomDecoder(); // 0x0000000180BC0010-0x0000000180BC0080
	
		// Methods
		internal override void FinalizePath(Path p, Vector3[] wps, bool isClosedPath); // 0x0000000180BBEBF0-0x0000000180BBF050
		internal override Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints); // 0x0000000180BBF050-0x0000000180BBF720
		internal void SetTimeToLengthTables(Path p, int subdivisions); // 0x0000000180BBF720-0x0000000180BBF9C0
		internal void SetWaypointsLengths(Path p, int subdivisions); // 0x0000000180BBF9C0-0x0000000180BC0010
	}
}
