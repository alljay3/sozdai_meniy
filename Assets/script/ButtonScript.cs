using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] private Transform ObjectCollectionPanel;
    [SerializeField] private Sprite MyImage;
    [SerializeField] private GameObject objectModified;
    [SerializeField] private GameObject CalledObject;
    [SerializeField] private GameObject DopObject;
    [SerializeField] private Sprite DopImage;
    public void CallObject()
    {
        int childCount = ObjectCollectionPanel.childCount;
            for (int i = 0; i < childCount; i++)
            {
                ObjectCollectionPanel.GetChild(i).gameObject.SetActive(false);
            }
        CalledObject.SetActive(true);
    }

    public void ChangeColor()
    {
        Color color = gameObject.GetComponent<Image>().color;
        objectModified.SetActive(true);
        objectModified.GetComponent<Image>().color = color;
    }

    public void ChangeImage()
    {
        objectModified.SetActive(true);
        objectModified.GetComponent<Image>().sprite = MyImage;
    }

    public void DopChangeImage()
    {
        DopObject.SetActive(true);
        DopObject.GetComponent<Image>().sprite = DopImage;
    }

    public void ChangeImageAndCallObject()
    {
        ChangeImage();
        CallObject();
    }
    public void ChangeColorAndCallObject()
    {
        ChangeColor();
        CallObject();
    }
 

    public void DopChangeImageAndCallObject()
    {
        ChangeImage();
        DopChangeImage();
        CallObject();
    }

    public void RemoveObject()
    {
        objectModified.SetActive(false);
    }

}
