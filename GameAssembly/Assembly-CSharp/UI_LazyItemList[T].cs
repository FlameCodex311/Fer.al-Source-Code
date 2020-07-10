/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using WW.Waiters;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public abstract class UI_LazyItemList<T> : MonoBehaviour, IFilterable // TypeDefIndex: 12168
	where T : class
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private LazyLayoutGroup _layout;
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _allowLayoutAnimation;
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected ScrollRect _scrollRect;
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected int _itemsPerRow;
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected Vector2 _cellSize;
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _noItemsGroup;
	[SerializeField] // 0x00000001801039A0-0x00000001801039E0
	[Tooltip] // 0x00000001801039A0-0x00000001801039E0
	private bool _detailPanelIsExternal;
	[SerializeField] // 0x0000000180103BE0-0x0000000180103C20
	[Tooltip] // 0x0000000180103BE0-0x0000000180103C20
	private AutoSetupMethod _autoSetupMethod;
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _scrollToClickedItem;
	protected int _currentCategoryIndex;
	[RootSelector] // 0x0000000180104260-0x00000001801042E0
	[SerializeField] // 0x0000000180104260-0x00000001801042E0
	protected string _supportedFiltersListDefId;
	protected List<string> _supportedFilters;
	protected Dictionary<string, HashSet<string>> _currentFilters;
	protected string _currentSearchString;
	private Waiter _searchWaiter;
	protected int _currentSortMethod;
	protected List<LazyListItem> _items;
	protected Dictionary<LazyLayoutElement, LazyListItem> _itemsByLayoutElement;
	protected Dictionary<T, LazyListItem> _itemsByData;
	protected T _currentlySelectedData;
	protected Tweener _scrollTween;
	protected VisibilityCalculator _visibilityCalculator;
	protected ItemPool _itemPool;
	protected List<LazyLayoutElement> _extraBottomElements;
	public Action<T> OnItemSelected;
	public Action<T> OnItemClicked;
	public Action OnCalculateNavigation;

	// Properties
	public LazyLayoutGroup Layout { get; }
	public ScrollRect ScrollRect { get; }
	public int ItemsPerRow { get; }
	public int CategoryIndex { get; set; }
	public List<string> SupportedFilters { get; }
	public string CurrentSearchString { get; set; }
	public int CurrentSortMethod { get; set; }
	public List<LazyListItem> Items { get; }
	private List<T> DataItems { get; }
	public T CurrentlySelectedData { get; }
	public UI_LazyListItem<T> CurrentlySelectedItem { get; }
	public ItemPool Pool { get; }
	public UI_LazyListItemDetailPanel<T> DetailPanel { get; }
	private UI_LazyListItem<T> ItemPrefab { get; }

	// Nested types
	public enum AutoSetupMethod // TypeDefIndex: 12169
	{
		None = 0,
		Start = 1,
		Enable = 2
	}

	public enum Filter // TypeDefIndex: 12170
	{
		All = 0,
		Rare = 1,
		WishList = 2
	}

	public enum SortMethod // TypeDefIndex: 12171
	{
		AToZ = 0,
		ZToA = 1,
		CommonToRare = 2,
		RareToCommon = 3,
		FavToNot = 4,
		NotToFav = 5
	}

	public class LazyListItem // TypeDefIndex: 12172
	{
		// Fields
		public LazyLayoutElement layoutElement;
		public T data;
		public int categoryIndex;
		public UI_LazyListItem<T> uiItem;
		private bool _isSearchMode;
		public string Name;
		public List<string> Filters;
		public List<string> Tags;

		// Properties
		public bool IsSearchMode { get; }

		// Constructors
		public LazyListItem(LazyLayoutElement inLayoutElement, T inData, string inName, List<string> inFilters, List<string> inTags);

		// Methods
		public void SetUIItem(UI_LazyListItem<T> inUIItem);
		public void SetSearchMode(bool inIsSearchMode);
	}

	public class ItemPool // TypeDefIndex: 12173
	{
		// Fields
		private Transform _itemParent;
		private UI_LazyListItem<T> _itemPrefab;
		private List<UI_LazyListItem<T>> _availableItems;
		private List<UI_LazyListItem<T>> _itemsInUse;

		// Constructors
		public ItemPool(Transform inItemParent, UI_LazyListItem<T> inItemPrefab, int inInitialPoolSize = 50 /* Metadata: 0x00782DF0 */);

		// Methods
		public UI_LazyListItem<T> GetItemFromPool();
		public void ReturnItemToPool(UI_LazyListItem<T> inItem);
		public List<UI_LazyListItem<T>> GetAllLivingItems();
		private void SpawnItem();
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass101_0 // TypeDefIndex: 12174
	{
		// Fields
		public string filter;

		// Constructors
		public <>c__DisplayClass101_0();

		// Methods
		internal bool <ItemMatchesFilter>b__0(string supportedFilter);
		internal bool <ItemMatchesFilter>b__1(string supportedFilter);
	}

	// Constructors
	protected UI_LazyItemList();

	// Methods
	public void AddFilter(string inFilter);
	public void RemoveFilter(string inFilter);
	public void ClearFilters();
	protected virtual void Start();
	protected virtual void OnEnable();
	protected virtual void Setup();
	protected virtual void SetupItem(UI_LazyListItem<T> inUIItem, Action<UI_LazyListItem<T>> inOnClicked, Action<UI_LazyListItem<T>> inOnSelected, LazyListItem inListItem);
	protected virtual void SetupSupportedFilters();
	private void SpawnListItems();
	private void SpawnDetailPanel();
	private void SpawnNoItemsGroup();
	protected virtual List<string> CreateCategoryNames();
	private void SetItemVisible(LazyLayoutElement inLayoutElement, bool inIsVisible);
	private void ItemClicked(UI_LazyListItem<T> inItem);
	private void ItemSelected(UI_LazyListItem<T> inItem);
	protected virtual int CalcDesiredDetailIndex(UI_LazyListItem<T> inItemToDetail);
	private void ScrollToSelectedItem();
	protected void ScrollToItem(LazyListItem inItem, bool inInstant = false /* Metadata: 0x00782DB5 */, float inOffset = 0f /* Metadata: 0x00782DB6 */);
	protected void ScrollToTop();
	protected virtual void SortData();
	protected virtual void SortAToZ();
	protected virtual void SortZToA();
	protected virtual string GetDataItemName(T inData);
	protected virtual List<string> GetDataItemFilters(T inData);
	protected virtual List<string> GetDataItemTags(T inData);
	protected virtual void SortCommonToRare();
	protected virtual void SortRareToCommon();
	protected virtual int GetDataItemRarity(T inData);
	protected virtual void SortFavToNotFav();
	protected virtual void SortNotFavToFav();
	protected virtual bool GetDataItemFav(T inData);
	protected virtual void SortNewToOld();
	protected virtual void SortOldToNew();
	protected virtual long GetDataItemAge(T inData);
	protected virtual void CalculateUINavigation();
	protected abstract UI_LazyListItem<T> GetListItemPrefab();
	protected abstract UI_LazyListItemDetailPanel<T> GetDetailPanelReference();
	protected abstract List<T> GetDataItems();
	protected virtual bool ItemMatchesCategory(LazyListItem inItem);
	protected virtual bool ItemMatchesFilter(LazyListItem inItem);
	protected virtual bool ItemMatchesFilter(LazyListItem inItem, string inFilterCategory);
	protected virtual bool ItemMatchesSearch(LazyListItem inItem);
	protected void InitializeSiblingIndicies();
	public void FilterList(bool inInstant = true /* Metadata: 0x00782DBA */);
	protected virtual void PostListFilter(int inShownItemsCount);
	protected virtual LazyLayoutInfo CreateLayoutInfo(T inItem);
	public void SelectItem(T inItem);
	public void DeselectCurrentItem();
	public bool AddItem(T inItem, bool inFromSetup = false /* Metadata: 0x00782DBB */, int inSiblingIndex = -1 /* Metadata: 0x00782DBC */);
	public void RemoveItem(T inItem);
	public void ClearAllData();
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <set_CurrentSearchString>b__30_0();
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__66_0();
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__66_1(int i, bool isVisible);
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <ItemClicked>b__74_0();
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <ScrollToSelectedItem>b__77_0(LazyListItem item);
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <SortAToZ>b__81_0(LazyListItem a, LazyListItem b);
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <SortZToA>b__82_0(LazyListItem a, LazyListItem b);
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <SortCommonToRare>b__86_0(LazyListItem a, LazyListItem b);
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <SortRareToCommon>b__87_0(LazyListItem a, LazyListItem b);
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <SortFavToNotFav>b__89_0(LazyListItem a, LazyListItem b);
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <SortNotFavToFav>b__90_0(LazyListItem a, LazyListItem b);
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <SortNewToOld>b__92_0(LazyListItem a, LazyListItem b);
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <SortOldToNew>b__93_0(LazyListItem a, LazyListItem b);
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <ItemMatchesSearch>b__102_0(string tag);
}

