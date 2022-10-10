using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyHealth : MonoBehaviour
{

    public int health = 10;
    public TextMeshProUGUI EnemyhealthText;
    // Update is called once per frame
    void Update()
    {
        EnemyhealthText.text = "Emeny Health: " + health;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        string otherTag = collision.gameObject.tag;
        if (otherTag == "playerbullet")
        {
            health--;
            if (health <= 0)
            {
                Destroy(gameObject);
               
            }

        }
    }
}
