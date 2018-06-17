using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoveEnemy : MonoBehaviour {

    public Text health; //100
    float speed = 0.1f;
    public Transform player;
    public bool playerLookingAway = false;
	// Use this for initialization
	void Start () {
		
	}

    public void TakeDamage(float damage) //50
    {
        float d = damage * -1; //-50
        float h = System.Convert.ToInt32(health.text); //100
        h = h + d; //100 = 100  - 50 = 50
        health.text = h.ToString();
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 directionToPlayer = player.position - transform.position;

        if(playerLookingAway)
        {
            transform.Translate(directionToPlayer * speed * Time.deltaTime);
        }
	}
}
