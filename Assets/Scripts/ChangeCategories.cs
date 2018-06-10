using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCategories : MonoBehaviour {
    public GameObject ViewProducts;
    public int NumberContainer;

    public void ChangeContainer()
    {
        for(int i = 0; i < ViewProducts.transform.GetChildCount(); i++)
        {
            if(i == NumberContainer)
            {
                ViewProducts.transform.GetChild(i).gameObject.SetActive(true);
                ViewProducts.GetComponent<UnityEngine.UI.ScrollRect>().content = ViewProducts.transform.GetChild(i).gameObject.GetComponent<RectTransform>();
            }
            else
            {
                ViewProducts.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }

}
