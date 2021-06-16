using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorFollow : MonoBehaviour
{
    private Vector3 mousePos;

    private Camera cam;

    private Rigidbody2D rd;
    
    // Start is called before the first frame update
    void Start()
    {
        rd = this.GetComponent<Rigidbody2D> ();
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        rotateCamera();
    }

    void rotateCamera()
    {
        mousePos = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,
            Input.mousePosition.z));
        rd.transform.eulerAngles = new Vector3(0, 0,
            Mathf.Atan2((mousePos.y - transform.position.y), (mousePos.x - transform.position.x)) * Mathf.Rad2Deg);
        
    }
}
