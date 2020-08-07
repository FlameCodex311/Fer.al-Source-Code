/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia
{
	public class Quadtree<T> // TypeDefIndex: 9254
	{
		// Fields
		private readonly int nodeCapacity;
		private readonly List<QuadtreeNode> nodes;
		private Quadtree<T>[] children;
		private Rect boundaries;
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <Count>k__BackingField;
	
		// Properties
		public int Count { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; }
	
		// Nested types
		private class QuadtreeNode // TypeDefIndex: 9255
		{
			// Fields
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private Vector2 <Position>k__BackingField;
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private T <Value>k__BackingField;
	
			// Properties
			public Vector2 Position { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; }
			public T Value { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; }
	
			// Constructors
			public QuadtreeNode(Vector2 position, T value);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Find>d__12 : IEnumerable<T>, IEnumerator<T> // TypeDefIndex: 9256
		{
			// Fields
			private int <>1__state;
			private T <>2__current;
			private int <>l__initialThreadId;
			public Quadtree<T> <>4__this;
			private Rect range;
			public Rect <>3__range;
			private float <rangexMax>5__2;
			private float <rangexMin>5__3;
			private float <rangeyMax>5__4;
			private float <rangeyMin>5__5;
			private int <index>5__6;
			private IEnumerator<T> <>7__wrap6;
	
			// Properties
			T IEnumerator<T>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Find>d__12(int <>1__state);
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose();
			private bool MoveNext();
			private void <>m__Finally1();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<T> IEnumerable<T>.GetEnumerator();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		// Constructors
		public Quadtree(Rect boundaries, int nodeCapacity = 32 /* Metadata: 0x00778F59 */);
	
		// Methods
		public bool Insert(float x, float y, T value);
		public bool Insert(Vector2 position, T value);
		private bool Insert(QuadtreeNode node);
		[IteratorStateMachine] // 0x000000018024E180-0x000000018024E1D0
		public IEnumerable<T> Find(Rect range);
		public bool Remove(float x, float z, T value);
		public bool Remove(Vector2 position, T value);
		private void Subdivide();
		private void Combine();
	}
}
