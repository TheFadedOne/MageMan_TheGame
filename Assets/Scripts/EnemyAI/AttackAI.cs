using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAI : MonoBehaviour
{
    [SerializeField] GameObject attackTarget;
    [SerializeField] LayerMask layer;
    RaycastHit2D inRange;
  


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = attackTarget.transform.position - transform.position;
        inRange = Physics2D.Raycast(transform.position, direction, 20f, layer);
        if (inRange)
        {
            Debug.Log("Target In Range");
            attack(attackTarget, 20);
            Destroy(this.gameObject);
        }
    }

    public void chase()
    {

    }

    public void attack(GameObject target, int damage)
    {
        PlayerInfo pInfo = (PlayerInfo)target.GetComponent("PlayerInfo");
        pInfo.takeDamage(damage);
        
    }
}
