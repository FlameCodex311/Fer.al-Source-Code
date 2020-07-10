/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace FancyScrollView
{
	public abstract class FancyScrollView<TData, TContext> : MonoBehaviour // TypeDefIndex: 15875
		where TContext : class
	{
		// Fields
		[Range] // 0x00000001800B5D40-0x00000001800B5D80
		[SerializeField] // 0x00000001800B5D40-0x00000001800B5D80
		private float cellInterval;
		[Range] // 0x00000001800B5F40-0x00000001800B5F80
		[SerializeField] // 0x00000001800B5F40-0x00000001800B5F80
		private float cellOffset;
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected bool loop;
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private GameObject cellBase;
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Transform cellContainer;
		protected readonly List<FancyScrollViewCell<TData, TContext>> cells;
		private float currentPosition;
		protected List<TData> cellData;
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private TContext <Context>k__BackingField;
	
		// Properties
		public bool Loop { get; }
		public List<TData> CellData { get; }
		protected TContext Context { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; }
		public bool HasContext { get; }
	
		// Constructors
		protected FancyScrollView();
	
		// Methods
		protected void SetContext(TContext context);
		protected void UpdateContents();
		protected void UpdatePosition(float position, bool forceUpdateContents = false /* Metadata: 0x00784FAD */);
		private void UpdateCell(FancyScrollViewCell<TData, TContext> cell, int dataIndex, bool forceUpdateContents = false /* Metadata: 0x00784FAE */);
		private FancyScrollViewCell<TData, TContext> CreateCell();
		private int GetCircularIndex(int index, int maxSize);
	}
}
