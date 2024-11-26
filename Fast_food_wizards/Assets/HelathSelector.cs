using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelathSelector : MonoBehaviour
{
    [SerializeField] UnityEngine.UI.Image HP0;
    [SerializeField] UnityEngine.UI.Image HP1;
    [SerializeField] UnityEngine.UI.Image HP2;
    [SerializeField] UnityEngine.UI.Image HP3;

    public int hpOverride;

    private void Start()
    {
        HideAll();
        HP3.enabled = true;
    }

    private void HideAll ()
    {
        HP0.enabled = false;
        HP1.enabled = false;
        HP2.enabled = false;
        HP3.enabled = false;
    }




    public void SetHPImage (int hp)
    {
        switch (hp)
        {
            case 0:
                HideAll();
                HP0.enabled = true;
                break;

            case 1:
                HideAll();
                HP1.enabled = true;
                break;

            case 2:
                HideAll();
                HP2.enabled = true;
                break;

            case 3:
                HideAll();
                HP3.enabled = true;
                break;




        }
    }


    private void Update()
    {
        SetHPImage(hpOverride);
    }

}
