using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float hideTime;
    private MeshRenderer mr;
    private bool b_moveRight;

    private void Awake()
    {
        mr = this.gameObject.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
            b_moveRight = true;
        if (Input.GetKeyDown("q"))
        {
            if (mr.enabled)
                StartCoroutine(HideBall());
            else
            {
                print("q is pressed");
                StopCoroutine(HideBall());
            }
                    
        }
        
            
    }

    private void FixedUpdate()
    {
        if (b_moveRight)
            this.transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
        if(this.transform.position.x >= 50)
        {
            Vector3 newPosition = new Vector3(-50, this.transform.position.y, this.transform.position.z);
            this.transform.position = newPosition;
        }
    }

    public void BeginCoroutine()
    {
        StartCoroutine(HideBall());
    }

    public IEnumerator HideBall()
    {
        mr.enabled = false;
        yield return new WaitForSeconds(hideTime);
        mr.enabled = true;
    }


}
