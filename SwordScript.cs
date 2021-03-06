using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordScript : MonoBehaviour {

	// Use this for initialization
	public Transform sword, sword_unequip, sword_equip;
	public bool swordequipped;

	private Valve.VR.EVRButtonId TriggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;
	private SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int)trackedObj.index); } }
	private SteamVR_TrackedObject trackedObj;
	void Start () {
		trackedObj = GetComponent<SteamVR_TrackedObject> ();
	}

	void Update () {
		if (controller.GetPressDown(TriggerButton))
		if (swordequipped) {
			sword.position = sword_equip.position;
			sword.rotation = sword_equip.rotation;
			sword.transform.parent = (sword_equip); 
			sword_equip.rotation = Quaternion.Euler(-80,360,90);
			//Instantiate (sword, sword_equip.position, Quaternion.Euler(0,90,0)); 
		} if (controller.GetPressUp (TriggerButton)) 
		 {
			
			sword.transform.parent = (sword_unequip);
		}
	}
	public void Sword_Equip () {
		swordequipped = true;
	}
	public void Sword_Unequiped () {
		swordequipped = false;

	}
}


