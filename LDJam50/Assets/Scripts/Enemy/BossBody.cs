using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBody : MonoBehaviour
{
    public Transform parent;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
                                Mathf.Lerp(transform.position.x, parent.transform.position.x + BossController.bodyOffset.x, BossController.bodySpeed.x),
                                Mathf.Lerp(transform.position.y, parent.transform.position.y + BossController.bodyOffset.y, BossController.bodySpeed.y));

    }
}
