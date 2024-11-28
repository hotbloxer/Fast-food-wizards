using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Image Health1;
    public Image Health2;
    public Image Health3;
    public Image Health4;
    private float falltime;
    public Rigidbody2D PlayerRB;
    public float iframes;

    public Image Spatter;
    public SpriteRenderer PlayerSprite;

    public Player player;

    public RectTransform RectTransform;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Fall damage ------------
       if (PlayerRB.velocity.y < 0)
        {
            falltime += Time.deltaTime;
        } 
       else 
        {
            if (falltime > 1.0f)
            {
                take_damage(4 + (falltime * falltime) * 4);
                PlayerRB.velocity = new Vector2(0.0f, 0.0f);
                falltime = 0.0f;
            }
            else
            {
                falltime = 0.0f;
            }
        }
        //Fall damage --------------

       //invincibility frames (in seconds, nuværende sat til 1 sekund.)
        iframes -= Time.deltaTime;
        if (iframes < 0) { iframes = 0; }
        print("Iframes:" + iframes);

    }

    public void take_damage(float damage)
    {
        if (iframes == 0)
        {
            player._health -= damage;
            //player._hitStun = 1.0f;
            iframes = 1.0f;
            VisualHit();
        }        
    }

    public void heal(float health)
    {
        player._health += health;
        VisualHit();
    }

    public void VisualHit()
    {
        Spatter.enabled = true;
        switch (player._health)
        {
            case < 25:
                Health4.enabled = true;
                Health1.enabled = false;
                Health2.enabled = false;
                Health3.enabled = false;
                break;

            case < 50:
                Health3.enabled = true;
                Health1.enabled = false;
                Health2.enabled = false;
                Health4.enabled = false;
                break;

            case < 75:
                Health2.enabled = true;
                Health1.enabled = false;
                Health3.enabled = false;
                Health4.enabled = false;
                break;

            default:
                Health1.enabled = true;
                Health2.enabled = false;
                Health3.enabled = false;
                Health4.enabled = false;
                break;
        }
        /*for (int i = 0; i < 4; i++)
        {
            if (i % 2 == 0)
            {
                Invoke("flashOff", 0.25f + (i / 4));
            }
            else
            {
                Invoke("flashOn", 0.25f + (i / 4));
            }
            
        }*/

        flashOff();

        Invoke("flashOn", 0.25f);

        Invoke("flashOff1", 0.5f);

        Invoke("flashOn1", 0.75f);

        Invoke("disableSpatter", 1);
    }

    private void disableSpatter()
    {
        Spatter.enabled = false;
    }
    private void flashOff()
    {
        PlayerSprite.enabled = false;
    }

    private void flashOff1()
    {
        PlayerSprite.enabled = false;
    }

    private void flashOn()
    {
        PlayerSprite.enabled = true;
    }

    private void flashOn1()
    {
        PlayerSprite.enabled = true;
    }
}
