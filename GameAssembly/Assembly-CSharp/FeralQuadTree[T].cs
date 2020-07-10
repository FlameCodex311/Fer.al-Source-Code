/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class FeralQuadTree<T> // TypeDefIndex: 11649
	where T : MonoBehaviour
{
	// Fields
	private int _maxBehavioursPerCell;
	private QuadTreeCell _head;

	// Nested types
	public class QuadTreeCell // TypeDefIndex: 11650
	{
		// Fields
		private FeralQuadTree<T> _parentTree;
		private int _maxBehaviours;
		private Rect _bounds;
		private List<T> _behavioursInCell;
		private QuadTreeCell<T>[] _innerCells;

		// Constructors
		public QuadTreeCell(FeralQuadTree<T> inParentTree, Rect inBounds);

		// Methods
		public QuadTreeCell<T> Add(T inBehaviour, Vector2 inBehaviourPositionXZ);
		private void Split();
		public void GetOverlappedCells(Rect inBounds, List<QuadTreeCell<T>> inList);
		public void GetBehavioursWithinDistance(Vector2 inPos, float inDistance, List<T> inList);
		public void OnDrawGizmos();
	}

	// Constructors
	public FeralQuadTree(int inMaxBehavioursPerCell, Rect inOuterBounds);

	// Methods
	public QuadTreeCell Add(T inBehaviour);
	public List<QuadTreeCell> GetCellsWithinDistance(Transform inTransform, float inDistance);
	public List<T> GetBehavioursWithinDistance(Transform inTransform, float inDistance);
	private static bool InRange(float inValue, float inMin, float inMax);
	private static bool RectsOverlap(Rect inRect1, Rect inRect2);
	public void OnDrawGizmos();
}

