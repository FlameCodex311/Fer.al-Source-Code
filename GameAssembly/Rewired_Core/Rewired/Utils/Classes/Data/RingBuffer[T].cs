/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Utils.Classes.Data
{
	[Serializable]
	[CustomClassObfuscation] // 0x00000001801CE320-0x00000001801CE390
	[CustomObfuscation] // 0x00000001801CE320-0x00000001801CE390
	internal sealed class RingBuffer<T> : ICollection<T> // TypeDefIndex: 6975
	{
		// Fields
		private readonly T[] SvFrJoHFoPAEpRGoybiMjILSeKAc;
		private readonly int LHcUXOytTkIjlqPoenVhkyCFGKR;
		private int NlWaJxeSXNEewltcjZzcJjBCzdQ;
		private int lQXhFEatgRugRtDTSluKswoNsmY;
		private int kswtyGmohuOlSPFexjaYYjNtnYw;
		private int IjqwTBwdrSirVKbWYwOPxLyUCyW;
		private int wNPCYmLfYxcqAQsDPfNrFaPUdXp;
		private IEqualityComparer<T> BpqgKwtwxiCJWBlAQLLFXpVLOJgD;
	
		// Properties
		public int Count { get; }
		public int Capacity { get; }
		public int OverrunCount { get; }
		public IEqualityComparer<T> EqualityComparer { get; set; }
		public T this[int index] { get => default; set {} }
		int ICollection<T>.Count { get; }
		bool ICollection<T>.IsReadOnly { get; }
	
		// Nested types
		[Serializable]
		public struct xGVRUybGTbbONRCsFRNctcqMGbN : IEnumerator<T> // TypeDefIndex: 6976
		{
			// Fields
			private RingBuffer<T> buffer;
			private int index;
			private int version;
			private T current;
	
			// Properties
			public T iqRXBCFJzSXINtBNEmUcRPMPsKE { get; }
			object lEHmhZcDVBCvVkmanIeFkjDMVct { get; }
	
			// Constructors
			internal xGVRUybGTbbONRCsFRNctcqMGbN(RingBuffer<T> buffer);
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			private bool mGRuCjPDMbxAnMBLgXgjddgPkSL();
			void IEnumerator.Reset();
		}
	
		// Constructors
		public RingBuffer(int capacity);
	
		// Methods
		public void Enqueue(T item);
		public bool EnqueueIfUnique(T item);
		public T Dequeue();
		public T Peek();
		public bool Contains(T item);
		public bool Contains(T item, IEqualityComparer<T> comparer);
		public int IndexOf(T item);
		public int IndexOf(T item, IEqualityComparer<T> comparer);
		public bool Remove(T item);
		public bool Remove(T item, IEqualityComparer<T> comparer);
		public void RemoveAt(int index);
		public int RemoveAll(T item);
		public int RemoveAll(T item, IEqualityComparer<T> comparer);
		public void Clear();
		private int krhhhaALxgFpBwsYFvdYiuJUKqH(T param_0000ede5);
		private int krhhhaALxgFpBwsYFvdYiuJUKqH(T param_0000ede6, IEqualityComparer<T> param_0000ede7);
		private void EcPaTBhqvVCbAARRSpUqPrXBwLYb(int param_0000ede8);
		private bool WlHpcgiRtAxMgNHXMSeSFsPVxLS(int param_0000ede9);
		private int nNgyCpxLaUYDrbXaStDJcACPIFLa(int param_0000edea);
		private int mKWyrxHycmOFoPTqCJHdLyJPItb(int param_0000edeb);
		void ICollection<T>.Add(T item);
		void ICollection<T>.Clear();
		bool ICollection<T>.Contains(T item);
		void ICollection<T>.CopyTo(T[] array, int arrayIndex);
		bool ICollection<T>.Remove(T item);
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
	}
}
