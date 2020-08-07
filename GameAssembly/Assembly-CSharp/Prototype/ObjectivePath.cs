/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype
{
	public class ObjectivePath : ManagedBehaviour // TypeDefIndex: 14820
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Transform _objectiveTarget; // 0x50
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Material _material; // 0x58
		private Vector3[] _vertices; // 0x60
		private int[] _triangles; // 0x68
		private Vector2[] _uvs; // 0x70
		private Vector3[] _normals; // 0x78
		private NavMeshPath _navMeshPath; // 0x80
		private List<Mesh> _meshes; // 0x88
		public List<Vector3> linePoints; // 0x90
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _pathWidth; // 0x98
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Color _pathColor; // 0x9C
		private int _minPoints; // 0xAC
	
		// Constructors
		public ObjectivePath(); // 0x0000000180ADDD70-0x0000000180ADDEC0
	
		// Methods
		public override void MStart(); // 0x0000000180ADCAA0-0x0000000180ADD080
		public override void MUpdate(); // 0x0000000180ADD080-0x0000000180ADD270
		public void SetDestination(); // 0x0000000180ADDBE0-0x0000000180ADDD70
		private void MakeMesh(int inIdx); // 0x0000000180ADD270-0x0000000180ADD980
		private List<Vector3> MakeSmoothCurve(Vector3[] inVector3Array); // 0x0000000180ADD980-0x0000000180ADDBE0
	}
}
