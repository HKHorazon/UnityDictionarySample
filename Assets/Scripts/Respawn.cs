using UnityEngine;

// BA17 Trigger 觸發器：掛在勾了 Is Trigger 的物件上
// 有東西掉進來，就把它移回 respawnPoint 重新掉落
public class Respawn : MonoBehaviour
{
    // 重新掉落的位置，從 Hierarchy 把物件拖進來
    public Transform respawnPoint;

    // other 就是碰到觸發器的物件
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + " 掉進觸發區");
        other.transform.position = respawnPoint.position;

        // 把速度歸零，不然會帶著原本的速度繼續往下衝
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
