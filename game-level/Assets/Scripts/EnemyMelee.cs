using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMelee : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent agent;

    public GameObject player;

    public float health = 10.0f;

    public float agroRange = 10.0f;
    public float damage = 5.0f;

    //Rotation vars
    public float rotationSpeed;
    private float adjRotSpeed;
    public Quaternion targetRotation;

    //Collision Damage
    private float damageTimer;
    private float damageTime = 0.5f;

    public GameObject burning;
    public GameObject explosion;

    private Animation attack;
    private Animation walking;

    // Use this for initialization
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();

        attack = GetComponent<Animation>();
        walking = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {

        Behaviour();

        //Kill check - moved from takeDamage due to bug
        if (health <= 0)
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }

    void Behaviour()
    {

        if (!player)
            player = GameObject.FindGameObjectWithTag("Player");
        else if (player && !GameManager.instance.playerDead)
        {

            //Raycast in direction of Player
            RaycastHit hit;
            if (Physics.Raycast(transform.position, -(transform.position - player.transform.position).normalized, out hit, agroRange))
            {

                //If Raycast hits player
                if (hit.transform.tag == "Player")
                {

                    Debug.DrawLine(transform.position, player.transform.position, Color.red);

                    //Rotate slowly towards player
                    targetRotation = Quaternion.LookRotation(player.transform.position - transform.position);
                    adjRotSpeed = Mathf.Min(rotationSpeed * Time.deltaTime, 1);
                    transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, adjRotSpeed);

                    //Move towards player
                    if (Vector3.Distance(player.transform.position, transform.position) >= 5)
                    {
                        agent.SetDestination(player.transform.position);
                        walking.Play("Walking");
                    }
                    //Stop if close to player
                    else if (Vector3.Distance(player.transform.position, transform.position) < 5)
                    {
                        agent.SetDestination(transform.position);
                        attack.Play("Standing Melee Attack Horizontal");
                    }
                }
            }
        }
    }


    private void OnCollisionStay(Collision collision)
    {

        if (collision.transform.tag == "Player" && Time.time > damageTimer)
        {
            collision.transform.GetComponent<PlayerAvatar>().takeDamage(damage);
            damageTimer = Time.time + damageTime;

        }
    }

  //  private void OnTriggerEnter(Collider other)
  //  {
       // if (other.CompareTag("Player"))
       // {
       //     meleeAttack.SetTrigger("meleeAttack");
       // }
        
    //}

    public void takeDamage(float thisDamage)
    {
        health -= thisDamage;
    }
}
