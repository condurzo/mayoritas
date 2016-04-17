using UnityEngine;
using System.Collections;

public class MenuBtn : MonoBehaviour {
	public GameObject MenuGO;
	public bool states;

	public void OpenMenu () {
		if (!states) {
			iTween.MoveTo (MenuGO, iTween.Hash ("x", 115, "time", .4, "loopType", "none"
			, "delay", 0, "easeType", "easeInOutQuad"));
			states = true;
		}
	}
	public void CloseMenu(){
		if (states) {
			iTween.MoveTo (MenuGO, iTween.Hash ("x", -120, "time", .4, "loopType", "none"
				, "delay", 0, "easeType", "easeInOutQuad"));
			states = false;
		}
	}
	

}
