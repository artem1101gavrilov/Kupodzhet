using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeProduct : MonoBehaviour {

    public Image Img;
    public Text txt;
    public string NameButton;
    public int CurrentNumberInTable;

	public void SetPictureInImage()
    {
        Img.sprite = this.gameObject.GetComponent<UnityEngine.UI.Image>().sprite;
        txt.text = NameButton;
        Button.NumberInTable = CurrentNumberInTable;
    }
}
