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
	internal abstract class ABSPathDecoder // TypeDefIndex: 5656
	{
		// Constructors
		protected ABSPathDecoder(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		internal abstract void FinalizePath(Path p, Vector3[] wps, bool isClosedPath);
		internal abstract Vector3 GetPoint(float perc, Vector3[] wps, Path p, ControlPoint[] controlPoints);
	}
}
