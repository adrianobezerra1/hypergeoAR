using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IUControl : MonoBehaviour
{
	private bool buttonRotateAddY = false;
	private bool buttonRotateSubY = false;
	private bool buttonRotateAddX = false;
	private bool buttonRotateSubX = false;
	private bool buttonTranslateAddX = false;
	private bool buttonTranslateSubX = false;
	private GameObject objRA;
	private GameObject objRA1;
    // Start is called before the first frame update
    void Start()
    {
		StartCoroutine(AtualizarObjRA());
    }

    // Update is called once per frame
    void Update()
    {
        if(buttonRotateAddY)
		objRA.transform.Rotate(0,0,1f, Space.Self);
	
        if(buttonRotateSubY)
		objRA.transform.Rotate(0,0,-1f, Space.Self);
	
        if(buttonRotateAddX)
		objRA.transform.Rotate(1f,0,0, Space.Self);
	
        if(buttonRotateSubX)
		objRA.transform.Rotate(-1f,0,0, Space.Self);
	
        if(buttonTranslateAddX)
		objRA1.transform.Translate(0,0,-0.005f);
	
        if(buttonTranslateSubX)
		objRA1.transform.Translate(0,0,0.005f);
    }
	
	IEnumerator AtualizarObjRA (){
		objRA = GameObject.FindWithTag("RA.obj2");
		objRA1 = GameObject.FindWithTag("RA.obj3");
		yield return new WaitForSeconds(1f);
		StartCoroutine(AtualizarObjRA());
	}
	
	public void StartRotateAddY(){
		buttonRotateAddY = true;
	}
	public void StopRotateAddY(){
		buttonRotateAddY = false;
	}
	public void StartRotateSubY(){
		buttonRotateSubY = true;
	}
	public void StopRotateSubY(){
		buttonRotateSubY = false;
	}
	
	public void StartRotateAddX(){
		buttonRotateAddX = true;
	}
	public void StopRotateAddX(){
		buttonRotateAddX = false;
	}
	
	public void StartRotateSubX(){
		buttonRotateSubX = true;
	}
	
	public void StopRotateSubX(){
		buttonRotateSubX = false;
	}
	
	public void StartTranslateSubX(){
		buttonTranslateSubX = true;
	}
	public void StopTranslateSubX(){
		buttonTranslateSubX = false;
	}
	public void StartTranslateAddX(){
		buttonTranslateAddX = true;
	}
	public void StopTranslateAddX(){
		buttonTranslateAddX = false;
	}
	
	
}
