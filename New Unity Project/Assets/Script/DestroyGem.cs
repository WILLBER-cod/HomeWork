using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGem : MonoBehaviour
{
    private Movement _move;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Movement>(out Movement move))
            Destroy(gameObject);
    }
}
