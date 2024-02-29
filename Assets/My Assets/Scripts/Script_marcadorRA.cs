using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UI {
public class Script_marcadorRA : MonoBehaviour
{
	public GameObject objRA;
	public GameObject scrollView;
   
   void OnEnable(){
	   scrollView.GetComponent<PinchableScrollRect>().cubo01 = objRA;
   }
   
}
}