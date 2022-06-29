using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseEvent : MonoBehaviour
{
    public Image child;
    GameObject target;

   // public Text Quest;
    //public Text Time;
    //public Text btn1;
    //public Text btn2;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
         
            CastRay();

            if (target == this.gameObject)
            {
                child.gameObject.SetActive(true);
            }

        }
    }

    public void CastRay()
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero,0f);

        if (hit.collider != null)
        {
            target = hit.collider.gameObject;
            Debug.Log(target);
            Debug.Log(target.GetHashCode());
        }
    }
}
