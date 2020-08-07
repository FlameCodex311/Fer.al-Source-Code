/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;

// Image 49: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5670-5860

namespace DG.Tweening.Plugins.Core.PathCore
{
	[Serializable]
	public class Path // TypeDefIndex: 5818
	{
		// Fields
		private static CatmullRomDecoder _catmullRomDecoder; // 0x00
		private static LinearDecoder _linearDecoder; // 0x08
		private static CubicBezierDecoder _cubicBezierDecoder; // 0x10
		public float[] wpLengths; // 0x10
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		internal PathType type; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		internal int subdivisionsXSegment; // 0x1C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		internal int subdivisions; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		internal Vector3[] wps; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		internal ControlPoint[] controlPoints; // 0x30
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		internal float length; // 0x38
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		internal bool isFinalized; // 0x3C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		internal float[] timesTable; // 0x40
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		internal float[] lengthsTable; // 0x48
		internal int linearWPIndex; // 0x50
		internal bool addedExtraStartWp; // 0x54
		internal bool addedExtraEndWp; // 0x55
		private Path _incrementalClone; // 0x58
		private int _incrementalIndex; // 0x60
		private ABSPathDecoder _decoder; // 0x68
		private bool _changed; // 0x70
		internal Vector3[] nonLinearDrawWps; // 0x78
		internal Vector3 targetPosition; // 0x80
		internal Vector3? lookAtPosition; // 0x8C
		internal Color gizmoColor; // 0x9C
	
		// Constructors
		public Path(PathType type, Vector3[] waypoints, int subdivisionsXSegment, Color? gizmoColor = default); // 0x0000000181793170-0x00000001817934C0
		internal Path(); // 0x0000000181793100-0x0000000181793170
	
		// Methods
		internal void FinalizePath(bool isClosedPath, AxisConstraint lockPositionAxes, Vector3 currTargetVal); // 0x0000000181792B50-0x0000000181792D20
		internal Vector3 GetPoint(float perc, bool convertToConstantPerc = false /* Metadata: 0x007634AD */); // 0x0000000181792E70-0x0000000181792F00
		internal float ConvertToConstantPathPerc(float perc); // 0x00000001817923E0-0x00000001817925A0
		internal int GetWaypointIndexFromPerc(float perc, bool isMovingForward); // 0x0000000181792F00-0x0000000181792FC0
		internal static Vector3[] GetDrawPoints(Path p, int drawSubdivisionsXSegment); // 0x0000000181792D20-0x0000000181792E70
		internal static void RefreshNonLinearDrawWps(Path p); // 0x0000000181792FC0-0x0000000181793100
		internal void Destroy(); // 0x00000001817925A0-0x00000001817926A0
		internal Path CloneIncremental(int loopIncrement); // 0x0000000181791B50-0x00000001817923E0
		internal void AssignWaypoints(Vector3[] newWps, bool cloneWps = false /* Metadata: 0x007634AE */); // 0x0000000181791A60-0x0000000181791B50
		internal void AssignDecoder(PathType pathType); // 0x0000000181791920-0x0000000181791A60
		internal void Draw(); // 0x0000000181792B40-0x0000000181792B50
		private static void Draw(Path p); // 0x00000001817926A0-0x0000000181792B40
	}
}
