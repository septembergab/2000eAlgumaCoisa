﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickmouse : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject click;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //RaycastHit hit;
            // Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //if (Physics.Raycast(ray, out hit))

            //{
            //  BoxCollider bc = hit.collider as BoxCollider;
            //  if (bc != null)
            // {
            Destroy(click.gameObject);
        }

        // }

        // }
        // }
    }
}
