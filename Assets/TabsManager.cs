using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TabsManager : MonoBehaviour {

	public List<GameObject> tabsMenuButtons = new List<GameObject>();
	public List<GameObject> tabsContainers = new List<GameObject>();

	void Start() {
		CloseAllTabs ();
		tabsContainers [0].SetActive (true);
		SetAllTabItems (tabsMenuButtons [0].GetComponent<TabsMenuItem> ());
	}

	public void ToggleTabs(GameObject tab, TabsMenuItem menuItem) {
		CloseAllTabs ();
		SetAllTabItems (menuItem);
		tab.SetActive (true);
	}

	private void CloseAllTabs() {
		foreach (GameObject tabs in tabsContainers) {
			tabs.SetActive(false);
		}
	}

	private void SetAllTabItems(TabsMenuItem menuItem) {
		foreach (GameObject item in tabsMenuButtons) {
			item.GetComponent<TabsMenuItem>().isActive = false;
			item.GetComponent<TabsMenuItem>().SetMenuItemState ();
		}

		menuItem.isActive = true;
		menuItem.SetMenuItemState ();
	}
}
