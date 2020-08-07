/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace FancyScrollView
{
	public abstract class FancyScrollView<TData, TContext> : MonoBehaviour // TypeDefIndex: 14322
		where TContext : class
	{
		// Fields
		[Range] // 0x0000000180211200-0x0000000180211240
		[SerializeField] // 0x0000000180211200-0x0000000180211240
		private float cellInterval;
		[Range] // 0x000000018020DD00-0x000000018020DD40
		[SerializeField] // 0x000000018020DD00-0x000000018020DD40
		private float cellOffset;
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected bool loop;
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private GameObject cellBase;
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Transform cellContainer;
		protected readonly List<FancyScrollViewCell<TData, TContext>> cells;
		private float currentPosition;
		protected List<TData> cellData;
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TContext <Context>k__BackingField;
	
		// Properties
		public bool Loop { get; }
		public List<TData> CellData { get; }
		protected TContext Context { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; }
		public bool HasContext { get; }
	
		// Constructors
		protected FancyScrollView();
	
		// Methods
		protected void SetContext(TContext context);
		protected void UpdateContents();
		protected void UpdatePosition(float position, bool forceUpdateContents = false /* Metadata: 0x007BA765 */);
		private void UpdateCell(FancyScrollViewCell<TData, TContext> cell, int dataIndex, bool forceUpdateContents = false /* Metadata: 0x007BA766 */);
		private FancyScrollViewCell<TData, TContext> CreateCell();
		private int GetCircularIndex(int index, int maxSize);
	}
}
