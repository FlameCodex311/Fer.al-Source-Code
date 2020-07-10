/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace FancyScrollView
{
	public abstract class FancyScrollViewCell<TData, TContext> : MonoBehaviour // TypeDefIndex: 15878
		where TContext : class
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <DataIndex>k__BackingField;
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private TContext <Context>k__BackingField;
	
		// Properties
		public int DataIndex { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; }
		public virtual bool IsVisible { get; }
		public virtual bool IsSelectable { get; }
		protected TContext Context { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; }
	
		// Constructors
		protected FancyScrollViewCell();
	
		// Methods
		public virtual void SetContext(TContext context);
		public virtual void SetVisible(bool visible);
		public virtual void UpdateContent(TData itemData);
		public virtual void UpdatePosition(float position);
	}
}
