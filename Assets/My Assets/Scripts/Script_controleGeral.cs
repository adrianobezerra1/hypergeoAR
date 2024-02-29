using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script_controleGeral : MonoBehaviour
{
	public Transform contentOrigem;
	public Text texto01;
	public GameObject cubo01;
	private float positionXOrigin;
	private float scaleXOrigin;
	public GameObject scrollView;
	private PinchableScrollRect script_scrollView;
	//public String texto02;
	
    // Start is called before the first frame update
    void Start()
    {
		script_scrollView = scrollView.GetComponent<PinchableScrollRect>();
        positionXOrigin = contentOrigem.position.x;
       scaleXOrigin = contentOrigem.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
		
        texto01.text = script_scrollView.zoomVelocity.ToString();//contentOrigem.position.x.ToString();
		//cubo01.transform.localScale = new Vector3(cubo01.transform.localScale.x + (1000 * script_scrollView.zoomVelocity), cubo01.transform.localScale.y,cubo01.transform.localScale.z);
		//if(positionXOrigin - contentOrigem.position.x)
	}
}
