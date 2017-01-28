using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TabsMenuItem : MonoBehaviour {

	public GameObject tab;
	public bool isActive;

	private TabsManager TM;
	private Text thisText;
	private Image thisImage;
	private Color highlightColor = new Color(1,1,1,1);
	private Color dehighlightColor = new Color(72f/255f, 76f/255f, 85f/255f,1);

	public void Awake() {
		TM = GameObject.Find ("TabsManager").GetComponent<TabsManager> ();
		thisText = transform.Find ("Text").GetComponent<Text> ();
		thisImage = GetComponent<Image> ();
	}

	public void ClickTabItem() {
		TM.ToggleTabs (tab, this);
	}

	public void SetMenuItemState() {
		if (isActive) {
			thisImage.color = highlightColor;
			thisText.color = dehighlightColor;
		} else {
			thisImage.color = dehighlightColor;
			thisText.color = highlightColor;
		}
	}
}
