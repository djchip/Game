using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pick_heart : MonoBehaviour
{
    Player player;
    public int healAmount;
    public GameObject effect;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            player.Heal(healAmount);
            Destroy(gameObject);
        }
    }
}
