using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TargetCollision : MonoBehaviour
{
    public int count;
    public TextMeshProUGUI countText;
    public GameObject pickupGun;

//starts score off at zero
    void Start()
    {
        count = 0;
        SetCountText();
    }


    // when the player walks into a cube, it will disappear and add to the score
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            // cubes disappear after picking up
            other.gameObject.SetActive(false);
            //score goes up after picking up cubes
            count = count + 1;
            SetCountText();
        } 
    }

    // displays the score with TMP and activates gun when score is 5
    public void SetCountText()
    {
        countText.text = "Score: " + count.ToString();
        if (count >= 5)
        {
            pickupGun.SetActive(true);
        }
    }
}
