/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

namespace Cinemachine.Utility
{
	internal abstract class GaussianWindow1d<T> // TypeDefIndex: 7570
	{
		// Fields
		protected T[] mData;
		protected float[] mKernel;
		protected float mKernelSum;
		protected int mCurrentPos;
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float <Sigma>k__BackingField;
	
		// Properties
		private float Sigma { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; }
		public int KernelSize { get; }
	
		// Constructors
		public GaussianWindow1d(float sigma, int maxKernelRadius = 10 /* Metadata: 0x00776693 */);
	
		// Methods
		private void GenerateKernel(float sigma, int maxKernelRadius);
		protected abstract T Compute(int windowPos);
		public void Reset();
		public bool IsEmpty();
		public void AddValue(T v);
		public T Value();
	}
}
