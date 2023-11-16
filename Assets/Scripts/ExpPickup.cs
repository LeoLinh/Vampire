using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpPickup : MonoBehaviour
{
    public int expValue;

    private bool movingToPlayer;
    public float moveSpeed;

    public float timeBetweenChecks = .2f;
    private float checkCounter;

    private PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        player = PlayerHealthController.Instance.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(movingToPlayer == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, PlayerHealthController.Instance.transform.position, moveSpeed * Time.deltaTime);
        }
        else
        {
            checkCounter -= Time.deltaTime;
            if(checkCounter <= 0)
            {
                checkCounter = timeBetweenChecks;

                if(Vector3.Distance(transform.position, PlayerHealthController.Instance.transform.position) < )
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            ExperienceLevelController.instance.getExp(expValue);

            Destroy(gameObject);
        }
    }
}
