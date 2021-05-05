using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInteraction : MonoBehaviour
{
    [SerializeField] private float red;
    [SerializeField] private float green;
    [SerializeField] private float blue;
    [SerializeField] private float opacity;

    [SerializeField] private GameObject sphere;

    public void CreateSpheres()
    {
        if(sphere)
        {
            for(int i = 0; i < 3; ++i)
            {
                Vector3 Position = new Vector3(Random.Range(-15, 15), 1,30);
                Instantiate(sphere, Position, new Quaternion(0,0,0,0));
            }
            
        }
    }

    public void ChangeColor()
    {
        ColorBlock cb = this.gameObject.GetComponent<Button>().colors;
        Vector4 newColor = new Vector4(red, green, blue, opacity);
        cb.selectedColor = newColor;
        this.gameObject.GetComponent<Button>().colors  = cb;
    }
}
