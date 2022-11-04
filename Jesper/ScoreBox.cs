using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ScoreBox : MonoBehaviour
{
    public GameObject Canvas;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("rotet");
        if (other.gameObject.name == "Body")
        {
            Canvas.GetComponent<Stats>().Score += 100;
            Destroy(this);
            //GameObject.Find("e").GetComponent<MakeTXTFile>().WriteString();
        }
    }
}
