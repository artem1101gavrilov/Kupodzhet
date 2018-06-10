using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {
    public GameObject TextCount;
    public GameObject TextCost;
    public static int NumberInTable;

    public void Start()
    {
        NumberInTable = 3;
    }

    public void EnterButton()
    {
        //Принимаем значения с текстовых полей
        int Count = int.Parse(TextCount.GetComponent<UnityEngine.UI.InputField>().text);
        double Cost = TextCost.GetComponent<UnityEngine.UI.InputField>().text != "" ? double.Parse(TextCost.GetComponent<UnityEngine.UI.InputField>().text) : 0;
        Debug.Log(Cost);

        if (Count > 0 && Cost > 0)
        {
            //тут будет функция ввода в БД

            //А тут очищаем поля для следующих вводов значений
            TextCount.GetComponent<UnityEngine.UI.InputField>().text = "1";
            TextCost.GetComponent<UnityEngine.UI.InputField>().text = "";
        }
    }
}
