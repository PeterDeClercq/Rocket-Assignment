using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrabCoin : MonoBehaviour
{
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindWithTag("Score").GetComponent<Text>().text = score.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject);
            score += 1;
            GameObject.FindWithTag("Score").GetComponent<Text>().text = score.ToString();
        }
    }
}
